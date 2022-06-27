using System.Text;
using System.Net.Sockets;

if (args.Length < 1) return;

using var socket = new Socket(SocketType.Dgram, ProtocolType.Udp);
socket.Connect("127.0.0.1", 9119);
socket.Send(Encoding.ASCII.GetBytes(args[0]));