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
                    Console.WriteLine("Add Server selected");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Show Servers selected");
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