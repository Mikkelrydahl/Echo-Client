using System;
using System.IO;
using System.Net.Sockets;

namespace Echo_Client_ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client!");
            TcpClient socket = new TcpClient("LocalHost", 7);

            NetworkStream ns = socket.GetStream();
            StreamReader reader = new StreamReader(ns);
            StreamWriter writer = new StreamWriter(ns);

            string message = Console.ReadLine();
            writer.WriteLine(message);
            writer.Flush();

            string receivemessage = reader.ReadLine();
            Console.WriteLine("Sent" + receivemessage);
        }


    }
}
