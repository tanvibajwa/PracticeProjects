using System;
using System.Net;
using System.Net.Sockets;

namespace udp_receiver
{
    class Program
    {
        static void Main(string[] args)
        {
            var udp_receiver = new UdpClient();

            udp_receiver.Connect(new IPAddress(new byte[] { 127, 0, 0, 0 }), 50000);

            Console.WriteLine("Receiving data");
            IPEndPoint senders_ip = new IPEndPoint(
                                                    new IPAddress(new byte[] { 127, 0, 0, 0 }), 
                                                    50000);

            var result = udp_receiver.Receive(ref senders_ip);

            if (result != null)
            {
                Console.WriteLine("received result: %d %d %d %d", result[0], result[1], result[2], result[3]);
            }
        }
    }
}
