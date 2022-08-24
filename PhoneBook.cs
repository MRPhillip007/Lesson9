using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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

        public string SearchContact(string name = "", string surname = "", string phoneNumber = "")
        {
            FileAction _ = new FileAction(_phoneBookName);
            string[] content = FileAction.Data;

            for (int i = 0; i < content.Length; i++)
            {
                if (Regex.IsMatch(content[i], RegexFind.Name, RegexOptions.IgnoreCase) && content[i].Contains(name))
                {
                    Console.WriteLine(content[i]);
                }
            }
            return "";
        }
    }
}
