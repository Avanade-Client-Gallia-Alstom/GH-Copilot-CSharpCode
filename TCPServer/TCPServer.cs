using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPServer
{
    class TCPServer
    {
        static void Main(string[] args)
        {
            StartServer();
        }

        static void StartServer()
        {
            // Set the IP address and port number
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int port = 8080;

            // Create a TCP listener
            TcpListener listener = new TcpListener(ipAddress, port);

            try
            {
                // Start listening for incoming connections
                listener.Start();
                Console.WriteLine("Server started. Waiting for connections...");

                while (true)
                {
                    // Accept the client connection
                    TcpClient client = listener.AcceptTcpClient();
                    Console.WriteLine("Client connected.");

                    // Get the network stream from the client
                    NetworkStream stream = client.GetStream();

                    // Read the incoming data
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    Console.WriteLine("Received data: " + data);

                    // Process the data (e.g., perform some operation)

                    // Send a response back to the client
                    string response = "Hello from the server!";
                    byte[] responseData = Encoding.ASCII.GetBytes(response);
                    stream.Write(responseData, 0, responseData.Length);
                    Console.WriteLine("Sent response: " + response);

                    // Close the client connection
                    client.Close();
                    Console.WriteLine("Client disconnected.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Stop listening for incoming connections
                listener.Stop();
                Console.WriteLine("Server stopped.");
            }
        }
    }
}
