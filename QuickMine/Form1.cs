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

namespace QuickMine
{
    public partial class EZNANO : Form
    {
        public bool amdIsSelected = false;
        public bool nvidiaIsSelected = false;
        public bool gpuSelected = false;
        public bool running = false;
        public double hashrate = 0;
        public int sharesAccepted = 0;
        public int sharesRejected = 0;
        public double power = 0;

        public System.Diagnostics.Process proc = new System.Diagnostics.Process();

        public EZNANO()
        {
            InitializeComponent();
        }

        private void AMD_Click(object sender, EventArgs e)
        {
            nvidiaIsSelected = false;
            Nvidia.BackColor = Color.OldLace;
            amdIsSelected = true;
            AMD.BackColor = Color.Lime;
            gpuSelected = true;
            Console.Out.WriteLine("AMD Selected");
        }

        private void Nvidia_Click(object sender, EventArgs e)
        {
            amdIsSelected = false;
            AMD.BackColor = Color.OldLace;
            nvidiaIsSelected = true;
            Nvidia.BackColor = Color.Lime;
            gpuSelected = true;
            Console.Out.WriteLine("Nvidia Selected");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartStop_Click(object sender, EventArgs e)
        {
            if(NanoAddress.Text != null && NanoAddress.Text != "Nano Address..." && gpuSelected)
            {
                if (StartStop.Text == "Start!")
                {
                    running = true;
                    StartStop.Text = "Stop";
                    StartStop.BackColor = Color.Red;
                    NanoAddress.Enabled = false;
                    Console.Out.WriteLine("Started Miner");
                    Nvidia.Enabled = false;
                    AMD.Enabled = false;
                    if (amdIsSelected)
                    {
                        amdStart();
                    }
                    else
                    {
                        nvidiaStart();
                    }
                    runStats();
                }
                else
                {
                    running = false;
                    proc.Kill();
                    NanoAddress.Enabled = true;
                    Nvidia.Enabled = true;
                    AMD.Enabled = true;
                    StartStop.Text = "Start!";
                    StartStop.BackColor = Color.DodgerBlue;
                    Console.Out.WriteLine("Stopped Miner");
                }
            }
            
        }

        private void amdStart()
        {
            string path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.Length - 9);
            path = path + "Resources\\amd\\amdstart";

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = path;
            proc.StartInfo.WorkingDirectory = path.Substring(0, path.Length - 10);
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();

            Console.Out.WriteLine(path);
        }

        private void nvidiaStart()
        {
            string args = "--server zec-us-east1.nanopool.org --user t1gi2N8yiQn8zsVEgeABNuYxEoKeFNVbqHG.Desktop/fineouttechnology@gmail.com --port 6666 --intensity 55 --api 0.0.0.0:42000";
            args = args.Replace("Desktop", NanoAddress.Text);
            string path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.Length - 9);
            path = path + "Resources\\nvidia\\miner.exe";

            proc.StartInfo.FileName = path;
            proc.StartInfo.Arguments = args;
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            proc.Start();
        }

        public async Task runStats()
        {
            while (running)
            {
                await Task.Delay(60000);
                getStats();
                Console.Out.WriteLine("Hashrate:" + hashrate + " power:" + (power / 1000).ToString());
                sols.Text = "SOL/s: " + hashrate;
                acceptedShares.Text = "Accepted Shares: " + sharesAccepted;
                rejectedShares.Text = "Rejected Shares: " + sharesRejected;
                double kwh = (power / 1000);
                kWh.Text = "GPU kWh: " + kwh;
                double dailyCost = Math.Round((kwh * .17 * 24), 2);
                electricCost.Text = "Electric Cost/day: ≈$" + dailyCost;
                double dailyRevenue = Math.Round((hashrate / 215 * .95), 2);
                revenueDay.Text = "Rev/day: ≈$" + dailyRevenue;
                double profit = Math.Round((dailyRevenue - dailyCost), 2);
                dailyProfit.Text = "Profit/day: ≈$" + profit;
            }
        }

        public async void getStats()
        {
            try
            {
                var clientSocket = new System.Net.Sockets.TcpClient();

                try
                {
                    await clientSocket.ConnectAsync("127.0.0.1", 42000);
                }
                catch (SocketException)
                {
                    Debug.Assert(!clientSocket.Connected);
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

                if (result.result.Count > 0)
                {
                    foreach (EWBFOBjectTemplate gpu in result.result)
                    {
                        // Speed
                        hashrate = gpu.speed_sps;
                        power = gpu.gpu_power_usage;

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
            }
        }

        private void sols_Click(object sender, EventArgs e)
        {

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
