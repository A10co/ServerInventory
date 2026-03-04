namespace ServerInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Server Inventory gestartet!");

            List<Server> servers = new List<Server>();

            while (true)
            {

                Console.WriteLine("1 - Add Server");
                Console.WriteLine("2 - Show Servers");
                Console.WriteLine("3 - Delete Server");
                Console.WriteLine("4 - Exit");

                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.Write("Server Name: ");
                    string name = Console.ReadLine();

                    Console.Write("IP Address: ");
                    string ip = Console.ReadLine();

                    Console.Write("Operating System: ");
                    string os = Console.ReadLine();

                    Console.Write("Location: ");
                    string location = Console.ReadLine();

                    Console.Write("Status: ");
                    string status = Console.ReadLine();

                    Server newServer = new Server();

                    newServer.Name = name;
                    newServer.IPAddress = ip;
                    newServer.OperatingSystem = os;
                    newServer.Location = location;
                    newServer.Status = status;

                    servers.Add(newServer);

                    Console.WriteLine("Server added successfully!");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Saved Servers:");

                    foreach (Server server in servers)
                    {
                        Console.WriteLine("Name: " + server.Name);
                        Console.WriteLine("IP: " + server.IPAddress);
                        Console.WriteLine("OS: " + server.OperatingSystem);
                        Console.WriteLine("Location: " + server.Location);
                        Console.WriteLine("Status: " + server.Status);
                        Console.WriteLine("----------------------");
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Delete Server selected");
                }
                else if (choice == "4")
                {
                   Console.WriteLine("Exit selected");
                 break;
                }



            }

        }
    }
}