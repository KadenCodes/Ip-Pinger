using System;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace AmIOnline
{
    public partial class AmIOnline
    {
        public static void Main(string[] args)
        {
            Console.Write("What is the ip?");
            string ip = Console.ReadLine();

            //pinger

            Ping myPing = new Ping();
            PingReply reply = myPing.Send(ip, 1000);
            Console.WriteLine("Status : " + reply.Status);
            Console.WriteLine("T.O.P ===> " + reply.RoundtripTime.ToString());
            Console.WriteLine("Sent To : " + reply.Address);
        }
    }
}