using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json.Linq;

namespace EZNANO
{
    public partial class EZNANO : Form
    {
        public string graphics = "Nvidia";
        public bool gpuSelected = true;
        public bool running = false;
        public double hashratePulled = 0;
        public double sharesAccepted = 0;
        public double sharesRejected = 0;
        public double power = 0;
        public double currentNanoPrice = 0;
        public string Address;
        public static string resourcePath = Directory.GetCurrentDirectory();
        public double dailyProfitPulled = 0;
        public double kwhCostLocal = 0;
        public double currentZcashPrice = 0;
        public double nanoMined = 0.0;
        public double networkHashrate = 0;
        public double nanoToZecRatio = 0;
        public dynamic personal = new JObject();
        public double kwh = 0;
        public double zecBlockReward = 12.5;

        public System.Diagnostics.Process proc = new System.Diagnostics.Process();

        public EZNANO()
        {
            InitializeComponent();

            resourcePath = Directory.GetCurrentDirectory() + "\\Resources\\";
            if(File.ReadAllText(resourcePath + "personal.json") != "")
            {
                var json = File.ReadAllText(resourcePath + "personal.json");
                dynamic dynJson = JsonConvert.DeserializeObject(json);
                NanoAddress.Text = dynJson.address;
                kwhCost.Text = dynJson.kWh;
                Intensity.Text = dynJson.intensity;
                autoStart.Checked = dynJson.autoStart;
                graphics = dynJson.graphics;
            }
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (NanoAddress.Text != null && NanoAddress.Text.Length == 64 && Int64.Parse(Intensity.Text) <= 100 && Int64.Parse(Intensity.Text) > 0)
            {
                running = true;
                Address = NanoAddress.Text;
                NanoAddress.Enabled = false;
                Console.Out.WriteLine("Started Miner");
                try
                {
                    kwhCostLocal = Double.Parse(kwhCost.Text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("EWBF Exception: " + ex.Message);
                    string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    File.AppendAllText(resourcePath + "debugLog.txt", date + "  Exception: " + ex.Message + System.Environment.NewLine);
                }
                kwhCost.Enabled = false;
                Intensity.Enabled = false;
                personal.address = NanoAddress.Text;
                personal.kWh = kwhCost.Text;
                personal.intensity = Intensity.Text;
                personal.autoStart = autoStart.Checked;
                personal.graphics = graphics;
                File.WriteAllText(resourcePath + "personal.json", personal.ToString());

                if (graphics == "AMD")
                {
                    amdStart();
                }
                else
                {
                    nvidiaStart();
                }
                runStats();
                amountMined();
                StartButton.SendToBack();
            }
            else
            {
                if(NanoAddress.Text == null || NanoAddress.Text.Length != 64)
                {
                    MessageBox.Show("Warning: NANO address doesnt appear correct.");
                    string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    File.AppendAllText(resourcePath + "debugLog.txt", date + "  Warning: NANO address doesnt appear correct." + System.Environment.NewLine);
                }
                else if(Int64.Parse(Intensity.Text) > 100 || Int64.Parse(Intensity.Text) < 1)
                {
                    MessageBox.Show("Warning: Intensity must be between 1 and 100.");
                    string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    File.AppendAllText(resourcePath + "debugLog.txt", date + "  Warning: Intensity must be between 1 and 100." + System.Environment.NewLine);
                }
            }
        }

        private void amdStart()
        {
            string args = "-zpool zec-us-east1.nanopool.org:6666 -zwal t1Mkjca4yn8DXppNPY5nH58U1xP3sjnR8DF.Desktop/fineouttechnology@gmail.com -zpsw z -ftime 1 -i 7 -tt 75";
            args = args.Replace("Desktop", Address);
            args = args.Replace("7", (Math.Ceiling(Int64.Parse(Intensity.Text) * .1)).ToString());

            proc.StartInfo.FileName = resourcePath + "amd\\miner.exe";
            proc.StartInfo.Arguments = args;
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.Start();
            string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Started AMD Miner." + System.Environment.NewLine);
        }

        private void nvidiaStart()
        {
            string args = "--server zec-us-east1.nanopool.org --user t1Mkjca4yn8DXppNPY5nH58U1xP3sjnR8DF.Desktop/fineouttechnology@gmail.com --port 6666 --intensity 55 --api 0.0.0.0:42000";
            args = args.Replace("Desktop", NanoAddress.Text);
            args = args.Replace("55", (Math.Ceiling(Int64.Parse(Intensity.Text) * .64)).ToString());

            proc.StartInfo.FileName = resourcePath + "nvidia\\miner.exe";
            proc.StartInfo.Arguments = args;
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.Start();
            string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Started Nvidia Miner." + System.Environment.NewLine);
        }

        public async Task runStats()
        {
            while (running)
            {
                await Task.Delay(3000);
                if (graphics == "Nvidia")
                {
                    GetNvidiaStats();
                } else
                {
                    GetAMDStats();
                }
                webStats();
                sols.Text = "" + hashratePulled;
                acceptedShares.Text = "" + sharesAccepted;
                rejectedShares.Text = "" + sharesRejected;
                kWh.Text = "" + kwh;
                
                double dailyCost = Math.Round((kwh * kwhCostLocal * 24), 2);
                electricCost.Text = "≈$" + dailyCost;
                double revenue = dailyProfitPulled * .92;
                revenueDay.Text = "≈$" + revenue;
                dailyProfit.Text = "≈$" + (revenue - dailyCost);
                currentNanoPrice = Math.Round(currentNanoPrice, 2);
                nanoPrice.Text = "$" + currentNanoPrice;
            } 
        }

        public async Task amountMined()
        {
            while (running)
            {
                await Task.Delay(100);
                nanoToZecRatio = currentZcashPrice / currentNanoPrice;
                if (currentNanoPrice > 0 && nanoToZecRatio > 0 && hashratePulled > 0 && networkHashrate > 0 && zecBlockReward > 0)
                {
                    double coinsPerDay = (567 * 12.5 * hashratePulled) / (networkHashrate);
                    double coinsPerTenMilliseconds = Math.Round(((coinsPerDay / 864000) * nanoToZecRatio), 15);
                    nanoMined += coinsPerTenMilliseconds;
                    if (nanoMined > 0)
                    {
                        minedLabel.Text = ("≈" + nanoMined.ToString("0.00000000"));
                    }
                }
            }
        }

        public async void webStats()
        {
            //Getting NANO Price
            try
            {
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Attempting to connect to coinmarketcap." + System.Environment.NewLine);
                var client = new WebClient();
                var json = client.DownloadString("https://api.coinmarketcap.com/v1/ticker/nano/");
                date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Connection to coinmarketcap Successful." + System.Environment.NewLine);
                dynamic dynJson = JsonConvert.DeserializeObject(json);
                foreach (var item in dynJson)
                {
                    currentNanoPrice = item.price_usd;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Wasnt able to pull data from coinmarketcap for nano price.");
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Exception: " + ex.Message + System.Environment.NewLine);
            }

            try
            {
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Attempting to connect to coinmarketcap." + System.Environment.NewLine);
                var client = new WebClient();
                var json = client.DownloadString("https://api.coinmarketcap.com/v1/ticker/zcash/");
                date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Connection to coinmarketcap Successful." + System.Environment.NewLine);
                dynamic dynJson = JsonConvert.DeserializeObject(json);
                foreach (var item in dynJson)
                {
                    currentZcashPrice = item.price_usd;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Wasnt able to pull data from coinmarketcap for nano price.");
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Exception: " + ex.Message + System.Environment.NewLine);
            }

            //Getting ZEC network Hashrate
            try
            {
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Attempting to connect to coinmarketcap." + System.Environment.NewLine);
                var client = new WebClient();
                var json = client.DownloadString("https://api.zcha.in/v2/mainnet/network");
                date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Connection to coinmarketcap Successful." + System.Environment.NewLine);
                dynamic dynJson = JsonConvert.DeserializeObject(json);

                networkHashrate = dynJson.hashrate;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Wasnt able to pull data from coinmarketcap for nano price.");
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Exception: " + ex.Message + System.Environment.NewLine);
            }
            

            //Getting Current Hashrate
            /*try
            {
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Attempting to connect to nanopool for current Hashrate." + System.Environment.NewLine);
                var client = new WebClient();
                var json = client.DownloadString("https://api.nanopool.org/v1/zec/workers/t1Mkjca4yn8DXppNPY5nH58U1xP3sjnR8DF");
                date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Connection to nanopool successful." + System.Environment.NewLine);
                dynamic stuff = JObject.Parse(json);
                foreach (var item in stuff.data)
                {
                    if (item.id == NanoAddress.Text)
                    {
                        hashratePulled = item.hashrate;
                    }
                }
            }
            catch (Exception ex)
            {
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Exception: " + ex.Message + System.Environment.NewLine);
            }
            */

            //Getting profit per day
            try
            {
                if (hashratePulled != 0)
                {
                    string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Attempting to connect to nanopool for profit per day." + System.Environment.NewLine);
                    var client = new WebClient();
                    var json = client.DownloadString("https://api.nanopool.org/v1/zec/approximated_earnings/" + hashratePulled);
                    date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Connection to nanopool successful." + System.Environment.NewLine);
                    dynamic stuff = JObject.Parse(json);
                    double data = stuff.data.day.dollars;
                    dailyProfitPulled = Math.Round(data, 2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wasnt able to pull data from Nanopool for profit per day.");
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Exception: " + ex.Message + System.Environment.NewLine);
            }
        }

        private async void GetAMDStats()
        {
            try
            {
                var clientSocket = new System.Net.Sockets.TcpClient();

                try
                {
                    string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Attempting to connect to AMD stats. " + System.Environment.NewLine);
                    await clientSocket.ConnectAsync("127.0.0.1", 3333);
                    date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Connection to AMD stats Successful." + System.Environment.NewLine);
                }
                catch (SocketException)
                {
                    Debug.Assert(!clientSocket.Connected);
                    string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    File.AppendAllText(resourcePath + "debugLog.txt", date + "  " + !clientSocket.Connected + System.Environment.NewLine);
                }

                string get_menu_request = "{\"id\":0,\"jsonrpc\":\"2.0\",\"method\":\"miner_getstat1\"}";
                NetworkStream serverStream = clientSocket.GetStream();
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(get_menu_request);
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                byte[] inStream = new byte[clientSocket.ReceiveBufferSize];
                serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                string _returndata = System.Text.Encoding.ASCII.GetString(inStream);
                string jsonData = _returndata.Substring(0, _returndata.LastIndexOf("}") + 1);

                dynamic result = JObject.Parse(jsonData);
                hashratePulled = 0;
                power = 0;
                if (result.result.Count > 0)
                {
                    string[] response = result.result[2].ToString().Split(';');
                    hashratePulled = double.Parse(response[0]);
                    sharesAccepted = double.Parse(response[1]);
                    sharesRejected = double.Parse(response[2]);
                }
                // Close socket
                clientSocket.Close();
                clientSocket = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("EWBF Exception: " + ex.Message);
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Exception: " + ex.Message + System.Environment.NewLine);
            }
            
        }

        public async void GetNvidiaStats()
        {
            try
            {
                var clientSocket = new System.Net.Sockets.TcpClient();

                try
                {
                    string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Attempting to connect to Nvidia stats. " + System.Environment.NewLine);
                    await clientSocket.ConnectAsync("127.0.0.1", 42000);
                    date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Connection to nvidia stats Successful." + System.Environment.NewLine);
                }
                catch (SocketException)
                {
                    Debug.Assert(!clientSocket.Connected);
                    string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    File.AppendAllText(resourcePath + "debugLog.txt", date + "  " + !clientSocket.Connected + System.Environment.NewLine);
                }

                string get_menu_request = "{\"id\":1, \"method\":\"getstat\"}\n";
                NetworkStream serverStream = clientSocket.GetStream();
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(get_menu_request);
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                byte[] inStream = new byte[clientSocket.ReceiveBufferSize];
                serverStream.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                string _returndata = System.Text.Encoding.ASCII.GetString(inStream);
                string jsonData = _returndata.Substring(0, _returndata.LastIndexOf("}") + 1);

                EWBFTemplate result = JsonConvert.DeserializeObject<EWBFTemplate>(jsonData);
                hashratePulled = 0;
                power = 0;
                if (result.result.Count > 0)
                {
                    foreach (EWBFOBjectTemplate gpu in result.result)
                    {
                        // Speed
                        hashratePulled += gpu.speed_sps;
                        power += gpu.gpu_power_usage;

                        // Shares
                        sharesAccepted = gpu.accepted_shares;
                        sharesRejected = gpu.rejected_shares;

                    }
                }
                // Close socket
                clientSocket.Close();
                clientSocket = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("EWBF Exception: " + ex.Message);
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Exception: " + ex.Message + System.Environment.NewLine);
            }
            kwh = (power / 1000);
            
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            running = false;
            //proc.Kill();
            NanoAddress.Enabled = true;
            kwhCost.Enabled = true;
            Intensity.Enabled = true;
            kwhCost.Enabled = false;
            Intensity.Enabled = false;
            personal.address = NanoAddress.Text;
            personal.kWh = kwhCost.Text;
            personal.intensity = Intensity.Text;
            personal.autoStart = autoStart.Checked;
            personal.graphics = graphics;
            File.WriteAllText(resourcePath + "personal.json", personal.ToString());
            try
            {
                foreach (Process proc in Process.GetProcessesByName("miner"))
                {
                    proc.Kill();
                }
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Killed the Miner process." + System.Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wasnt able to kill the miner process");
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Warning: Wasn't able to kill the miner process! " + ex.Message + System.Environment.NewLine);
            }
            stopButton.SendToBack();
        }

        private void leftGPU_Click(object sender, EventArgs e)
        {
            if (graphics == "Nvidia")
            {
                graphics = "AMD";
                NvidiaPicture.SendToBack();
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: AMD is selected." + System.Environment.NewLine);
            }
            else
            {
                graphics = "Nvidia";
                NvidiaPicture.BringToFront();
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Nvidia is selected." + System.Environment.NewLine);
            }
        }

        private void RightGPU_Click_1(object sender, EventArgs e)
        {
            if (graphics == "Nvidia")
            {
                graphics = "AMD";
                NvidiaPicture.SendToBack();
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: AMD is selected." + System.Environment.NewLine);
            }
            else
            {
                graphics = "Nvidia";
                NvidiaPicture.BringToFront();
                string date = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                File.AppendAllText(resourcePath + "debugLog.txt", date + "  Normal: Nvidia is selected." + System.Environment.NewLine);
            }
        }

        private void EZNANO_FormClosing(Object sender, FormClosingEventArgs e)
        {

            stopButton.PerformClick();
            Application.Exit();
        }

        private void EZNANO_Load(object sender, EventArgs e)
        {
            if (autoStart.Checked)
            {
                StartButton.PerformClick();
            }
            if(graphics == "AMD")
            {
                graphics = "Nvidia";
                leftGPU.PerformClick();
            }
            /*if (File.ReadLines(resourcePath + "debugLog.txt").Count() > 100)
            {
                string temp = File.ReadLines(resourcePath + "debugLog.txt").Reverse().Take(100).ToString();
                File.WriteAllText(resourcePath + "debugLog.txt", temp);
            }*/
        }
    }

    class EWBFOBjectTemplate
    {
        public int temperature { get; set; }
        public int speed_sps { get; set; }
        public int accepted_shares { get; set; }
        public int rejected_shares { get; set; }
        public int gpu_power_usage { get; set; }
    }

    class EWBFTemplate
    {
        public int id { get; set; }
        public List<EWBFOBjectTemplate> result { get; set; }
    }
}
