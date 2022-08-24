using ExceptionHw;

Contact contact = new Contact("380");
FileAction file = new FileAction("test.txt");

foreach (var item in FileAction.Data)
{
    Console.WriteLine(item);
}

//Console.WriteLine(contact.User + ": " + contact.Number);