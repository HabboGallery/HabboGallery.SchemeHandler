using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace HabboGallerySchemeHandler
{
    public partial class MainFrm : Form
    {
        private static UdpClient _client = new UdpClient("127.0.0.1", 9119);

        public MainFrm()
        {
            InitializeComponent();
            Run();
        }

        public async void Run()
        {
            var args = Environment.GetCommandLineArgs();
            byte[] data = Encoding.ASCII.GetBytes(args[1].Replace("habbogallery:", "").Replace("//", ""));

            await _client.SendAsync(data, data.Length);
            Environment.Exit(0);
        }
    }
}
