using System;
using System.Net.Sockets;
using System.Text;

namespace TCPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the server IP address and port number
            string serverIP = "127.0.0.1";
            int serverPort = 8080;

            // Create a TCP client socket
            TcpClient client = new TcpClient();

            try
            {
                // Connect to the server
                client.Connect(serverIP, serverPort);

                // Get the network stream for reading and writing
                NetworkStream stream = client.GetStream();

                // Convert the message to bytes
                string message = "Hello, server!";
                byte[] data = Encoding.ASCII.GetBytes(message);

                // Send the message to the server
                stream.Write(data, 0, data.Length);

                // Receive the response from the server
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string response = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                // Display the response
                Console.WriteLine("Server response: " + response);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Close the client socket
                client.Close();
            }
        }
    }
}
