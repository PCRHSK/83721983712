using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
 
namespace Project
{
  class Program
    {
        static void Main(string[] args)
        {
        string target = Console.ReadLine();
        string gateway = Console.ReadLine();
        string smtpserv = Console.ReadLine();
        int smtpport = Convert.ToInt32(Console.ReadLine());
        string smtpuser = Console.ReadLine();
        string smtppass = Console.ReadLine();
        int Amount2Send = Convert.ToInt32(Console.ReadLine());
        StartSpam(target, gateway, smtpserv, smtpport, smtpuser, smtppass, Amount2Send);
        }
        
        static bool StartSpam(string target, string gateway, string smtpserv, int smtpport, string smtpuser, string smtppass, int Amount2Send) 
        {
          
        
        }
    }
} 
