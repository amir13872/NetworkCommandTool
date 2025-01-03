using System;
using System.Diagnostics;

namespace NetworkCommandTool.Core
{
    public class CommandExecutor
    {
        public string ExecuteCommand(string command, string arguments)
        {
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = command;
                    process.StartInfo.Arguments = arguments;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;

                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    return output;
                }
            }
            catch (Exception ex)
            {
                return $"Error executing command: {ex.Message}";
            }
        }

        public string SanitizeInput(string input)
        {
            // Implement input sanitization logic here
            return input; // Placeholder for actual sanitization
        }

        public string ExecuteSafeCommand(string command, string arguments)
        {
            string sanitizedArguments = SanitizeInput(arguments);
            return ExecuteCommand(command, sanitizedArguments);
        }
    }
}
