using System;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace NetworkCommandTool.ARPModule
{
    public class ARPManager
    {
        public string ViewARPCache()
        {
            return ExecuteCommand("arp -a");
        }

        public string SendARPRequest(string ipAddress)
        {
            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                throw new ArgumentException("IP address cannot be null or empty.", nameof(ipAddress));
            }

            return ExecuteCommand($"arp -d {ipAddress}");
        }

        private string ExecuteCommand(string command)
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + command)
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(processStartInfo))
                {
                    using (System.IO.StreamReader reader = process.StandardOutput)
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error executing command: {ex.Message}";
            }
        }
    }
}
