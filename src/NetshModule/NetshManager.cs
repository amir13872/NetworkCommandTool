using System;
using System.Diagnostics;

namespace NetworkCommandTool.NetshModule
{
    public class NetshManager
    {
        public string GetNetworkConfigurations()
        {
            return ExecuteCommand("netsh interface ip show config");
        }

        public string ConfigureStaticIP(string interfaceName, string ipAddress, string subnetMask, string gateway)
        {
            string command = $"netsh interface ip set address name=\"{interfaceName}\" static {ipAddress} {subnetMask} {gateway}";
            return ExecuteCommand(command);
        }

        private string ExecuteCommand(string command)
        {
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = $"/C {command}";
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();
                    string result = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();
                    return result;
                }
            }
            catch (Exception ex)
            {
                return $"Error executing command: {ex.Message}";
            }
        }
    }
}
