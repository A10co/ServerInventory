namespace ServerInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Server Inventory gestartet!");

            List<Server> servers = new List<Server>();
            if (File.Exists("servers.txt"))
            {
                string[] lines = File.ReadAllLines("servers.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    Server server = new Server();

                    server.Name = parts[0];
                    server.IPAddress = parts[1];
                    server.OperatingSystem = parts[2];
                    server.Location = parts[3];
                    server.Status = parts[4];

                    servers.Add(server);
                }
            }
                   
                while (true) { 
             

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

                    string line = newServer.Name + "," +
                                  newServer.IPAddress + "," +
                                  newServer.OperatingSystem + "," +
                                  newServer.Location + "," +
                                  newServer.Status;

                    File.AppendAllText("servers.txt", line + Environment.NewLine);

                    Console.WriteLine("Server added successfully!");
                    Console.WriteLine();
                }
                else if (choice == "2")
                {
                    if (servers.Count == 0)
                    {
                        Console.WriteLine("No servers available.");
                    }
                    else
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

                    Console.WriteLine();
                }
                else if (choice == "3")
                {
                    if (servers.Count == 0)
                    {
                        Console.WriteLine("No servers to delete.");
                    }
                    else
                    {
                        Console.WriteLine("Select server to delete:");

                        for (int i = 0; i < servers.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + servers[i].Name);
                        }

                        Console.Write("Enter server number: ");

                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            index = index - 1;

                            if (index >= 0 && index < servers.Count)
                            {
                                servers.RemoveAt(index);
                                Console.WriteLine("Server deleted successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid server number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number.");
                            Console.WriteLine();
                        }
                    }
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Exit selected");
                    break;
                }
                else { Console.WriteLine("ungültige Eingabe");

                    Console.WriteLine();
                }



            }

        }
    }
}