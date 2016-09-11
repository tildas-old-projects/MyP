using System;
using System.Net;

namespace MyP
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine ("< MyP /> (c) S Stewart 2016");
			Console.WriteLine ("Contacting ipify API - please wait");
			WebClient webClient = new WebClient();
			string MyP = webClient.DownloadString("https://api.ipify.org");
			Console.WriteLine("IP is: {0}", MyP);


		}
	}
} 
