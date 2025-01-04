using System;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace NetworkCommandTool.PingModule
{
    public class PingManager
    {
        public string PingHost(string host, int count)
        {
            string result = string.Empty;
            using (Ping ping = new Ping())
            {
                try
                {
                    for (int i = 0; i < count; i++)
                    {
                        PingReply reply = ping.Send(host);
                        result += $"Reply from {reply.Address}: bytes={reply.Buffer.Length} time={reply.RoundtripTime}ms TTL={reply.Options.Ttl}\n";
                    }
                }
                catch (Exception ex)
                {
                    result = $"Error: {ex.Message}";
                }
            }
            return result;
        }

        public void PingHostAsync(string host, int count, Action<string> callback)
        {
            var ping = new Ping();
            ping.PingCompleted += (sender, e) =>
            {
                string result = string.Empty;
                foreach (var reply in e.Replies)
                {
                    result += $"Reply from {reply.Address}: bytes={reply.Buffer.Length} time={reply.RoundtripTime}ms TTL={reply.Options.Ttl}\n";
                }
                callback(result);
            };

            for (int i = 0; i < count; i++)
            {
                ping.SendAsync(host, null);
            }
        }
    }
}
