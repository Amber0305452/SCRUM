using System;
using System.Net;
using System.Net.NetworkInformation;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an IP-Address.");
            string ipAddress = Console.ReadLine(); 
            /*
             * Method to have a ping that works for sure.
            using (var ping = new Ping())
            {
                var reply = ping.Send(IPAddress.Loopback);

                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine("Pinging with server: " + reply.Address);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);
                }            
            }*/
            
            //Creates a new ping. 
            Ping ping = new Ping();
            //Creates a pingreply, sending the inserted ipaddress here.
            PingReply pingReply = ping.Send(ipAddress);
            //If the reply is a succes it will state the ip is reachable and else not.
            if (pingReply.Status == IPStatus.Success)
            {
                Console.WriteLine("This IP is reachable.");
            }
            else
            {
                Console.WriteLine("The IP is not reachable. Press any key to close the application.");
            }
            Console.ReadKey();
        }        
    }
}
