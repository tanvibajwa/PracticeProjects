using System;
using System.Net;
using System.Net.Sockets;

namespace udp_sender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sat Sri Akal Ji!");
            var udp_sender = new UdpClient();
            udp_sender.Connect(new IPAddress(new byte[] { 127, 0, 0, 0 }), 50000);

            var payload = new byte[] { 1, 2, 3, 4 };
            udp_sender.Send(payload, payload.Length);

            Console.WriteLine("Packet Sent!");
        }
    }
}
