﻿using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

namespace TcpEchoClient
{
	class TcpEchoClient
	{

		static void Main(string[] args)
		{
			string selection = "";

			string username = "";
			string ip = "";
			int port;

			Console.WriteLine("Starting Strings against Medialogy game client...");

			Console.WriteLine ("Select your username");
			username = Console.ReadLine ();

			Console.WriteLine ("Enter server IP adress");
			ip = Console.ReadLine ();

			Console.WriteLine ("Enter server port");
			selection = Console.ReadLine ();
			port = Int32.Parse (selection);

			Console.WriteLine ("Connecting to server: " + ip + " on port: " + port);


			TcpClient client = new TcpClient(ip, port);
			NetworkStream stream = client.GetStream();
			StreamReader reader = new StreamReader(stream);
			StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

			Console.Clear ();

			Console.WriteLine ("Hello! Welcome to Strings Against Medialogy.");

			Console.Write("Press [p] to join game\n");
			Console.Write("Press [x] to exit game\n");

			string lineToSend = Console.ReadLine();
			writer.WriteLine(lineToSend);
			Console.Clear ();

			while (true)
			{
				switch (lineToSend) {

				case "p":

				
					//string lineReceived = reader.ReadLine ();
					//Console.WriteLine (lineReceived);
				//	Console.WriteLine (" ");
					Console.WriteLine ("Your hand of strings have been dealt \n Choose the string you find the most suitable \n for the missing part in the following statement: \n \n");

					string lineReceived = reader.ReadLine();
					lineReceived = reader.ReadLine();
					List<string> yourHandOfCards = new List<string> (lineReceived.Split ('.'));
					yourHandOfCards.ForEach (Console.WriteLine);
					//lineToSend = Console.ReadLine();
					//writer.WriteLine(lineToSend);

					Console.WriteLine ("Press [1] to choose the first statement");
					Console.WriteLine ("Press [2] to choose the second"); 
					Console.WriteLine ("Press [3] to choose the third"); 
					Console.WriteLine ("Press [4] to choose the fourth");
					Console.WriteLine ("Press [5] to choose the fifth"); 


					lineToSend = Console.ReadLine();
					writer.WriteLine(lineToSend);

					break;

				case "x":



					break;
				}

			}
		}
	}
}



