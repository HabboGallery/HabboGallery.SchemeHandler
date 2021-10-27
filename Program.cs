using System.Text;
using System.Net.Sockets;

if (args.Length < 1) return;

using var client = new UdpClient("127.0.0.1", 9119);
client.Send(Encoding.ASCII.GetBytes(args[0]));