using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHw
{
    class PhoneBook
    {
        // TODO
        // 1. fill the phonebook. Create| PhoneBook mainBook = new PhoneBook("main.txt"); mainBook.Create(13);
        // 2. Searching contact (name, surname, phone)| mainBook.SearchContact(name: "Алекс");
        // 3. Add contact| mainBook.AddContact(name: "Peter", surname: "Peterson", phone:"380975673423");
        // 4. View contacts| mainBook.ViewContacts();

        string _phoneBookName = "";
        public PhoneBook(string phoneBookName)
        {
            _phoneBookName = phoneBookName;
        }

        public void Create(int quantity = 0)
        {
            if (quantity == 0)
            {
                FileAction.CreateFile(_phoneBookName);
                return;
            }

            FileAction _ = new FileAction(_phoneBookName);
            Contact contact = new Contact();

            for (int i = 0; i < quantity; i++)
            {
                string user = contact.User + ": " + contact.Number;
                FileAction.WriteToFile(user);
            }
            Console.WriteLine("");
            Console.WriteLine($"[+] PhoneBook {_phoneBookName} created ");
        }
    }
}
