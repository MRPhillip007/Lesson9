using ExceptionHw;

class Program
{
    static void Main()
    {
        const string PhoneBookFileName = "main.txt";

        bool isTrue = true;
        PhoneBook book = new PhoneBook(PhoneBookFileName);

        while (isTrue)
        {
            PrintMenu();
            Console.WriteLine("Enter command: ");
            Console.Write(">>>> ");

            string? command = Console.ReadLine();
            ParamsHandler(command, book);

            if (command == "exit")
            {
                isTrue = false;
            }
        }

    }
    static void PrintMenu()
    {
        Console.WriteLine("");
        Console.WriteLine("<= Welcome to the PhoneBook program =>");
        Console.WriteLine("create - create contact ");
        Console.WriteLine("show - view all contacts ");
        Console.WriteLine("search - search for specific contact");
        Console.WriteLine("add - add new contact");
        Console.WriteLine("cls - clear the console ");
        Console.WriteLine("menu - call main menu ");
        Console.WriteLine("");
    }

    static void ParamsHandler(string action, PhoneBook phoneBook)
    {
        switch (action.ToLower())
        {
            case "create":
                Console.WriteLine("Enter amount of contact to create: ");
                Console.Write(">>>> ");
                int.TryParse(Console.ReadLine(), out int amount);
                phoneBook.Create(amount);
                break;

            case "show":
                phoneBook.View();
                break;

            case "search":
                Console.WriteLine("Enter (name, surname or phone of contact)");
                Console.Write(">>>> ");

                string? contact = Console.ReadLine();
                string[] result = phoneBook.SearchContact(contact);

                Console.WriteLine("");

                foreach (string resultItem in result)
                {
                    Console.WriteLine(resultItem);
                }
                break;

            case "add":
                Console.WriteLine("Enter contact name: ");
                Console.Write(">>>> ");
                string? name = Console.ReadLine();

                Console.WriteLine("Enter surname: ");
                Console.Write(">>>> ");
                string? surname = Console.ReadLine();

                Console.WriteLine("Enter phone number: ");
                Console.Write(">>>> ");
                string? phone = Console.ReadLine();

                phoneBook.AddContact(name, surname, phone);
                break;

            case "cls":
                Console.Clear();
                break;

            case "menu":
                PrintMenu();
                break;

            default:
                Console.WriteLine("Wrong command");
                break;
        }
    }
}