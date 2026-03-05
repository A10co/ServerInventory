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
                        }
                    }
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Exit selected");
                    break;
                }
                else { Console.WriteLine("ungültige Eingabe"); }



            }

        }
    }
}