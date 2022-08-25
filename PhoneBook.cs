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

        public string[] SearchContact(string contactInfo = "")
        {
            FileAction _ = new FileAction(_phoneBookName);
            string[] content = FileAction.Data;
            List<string> result = new List<string>();

            for (int i = 0; i < content.Length; i++)
            {
                if (Regex.IsMatch(content[i], RegexFind.Contact, RegexOptions.IgnoreCase) && content[i].Contains(contactInfo.Trim()))
                {
                    result.Add(content[i]);
                }
            }
            return result.ToArray();
        }

        public void AddContact(string name, string surname, string phone)
        {
            if (String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(surname) || String.IsNullOrWhiteSpace(phone))
            {
                Console.WriteLine("Enter valid contact data!");
                return;
            }
            if (Regex.IsMatch(name, RegexValidCheck.Name, RegexOptions.IgnoreCase))
            {
                if (Regex.IsMatch(surname, RegexValidCheck.Surname, RegexOptions.IgnoreCase))
                {
                    if (Regex.IsMatch(phone.Trim(), RegexValidCheck.Phone, RegexOptions.IgnoreCase))
                    {
                        FileAction _ = new FileAction(_phoneBookName);
                        Contact user = new Contact();

                        string customContact = user.CustomUser = name + " " + surname + ": " + phone;
                        FileAction.WriteToFile(customContact);
                        return;
                    }
                    Console.WriteLine("Invalid phone number syntax. Try (+380(##)-###-##-##)");
                    return;

                }
                Console.WriteLine("surname must be grather than 4 characters! ");
                return;

            }
            Console.WriteLine("name must be grather than 2 characters! ");
            return;
        }

        public void View()
        {
            FileAction _ = new FileAction(_phoneBookName);
            foreach (string contact in FileAction.Data)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
