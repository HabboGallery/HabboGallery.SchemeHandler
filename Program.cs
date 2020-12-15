using System.Text;
using System.Net.Sockets;

namespace HabboGallery.SchemeHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1) return;
            byte[] data = Encoding.ASCII.GetBytes(args[0]);

            using var client = new UdpClient("127.0.0.1", 9119);
            client.Send(data, data.Length);
        }
    }
}
