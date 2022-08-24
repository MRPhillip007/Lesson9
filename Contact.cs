using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHw
{
    public class Contact
    {
        string _countryCode = "";
        public string Number { get => CreateNumber(_countryCode); }
        public string User { get { return CreateContact(); } }
        public string CustomUser { get => GetCustomUser(); set => SetCustomUser(value, value, value); }
        Random random = new Random();

        string[] _names = new string[] {

            "Вася", "Александр", "Роман", "Дима", "Ваня", "Петя", "Максим"
        };
        string[] _surnames = new string[] {
            "Пупкин", "Ерманченко", "Калосов", "Нагилевич", "Галенко", "Нестрович", "Хлебоедов"
        };


        public Contact(string countryCode = "380")
        {
            _countryCode = countryCode;
        }
        string CreateNumber(string coutryCode)
        {
            int number = random.Next(100000000, 999999999);
            string phoneNumber = Convert.ToInt64(number).ToString($"+{coutryCode}(##)-###-##-##");
            return phoneNumber;
        }

        string CreateContact()
        {
            int nameIndex = random.Next(0, _names.Length);
            int surnameIndex = random.Next(0, _surnames.Length);

            return _names[nameIndex] + " " + _surnames[surnameIndex];
        }

        string SetCustomUser(string name, string surname, string phone)
        {
            return name + " " + surname + ": " + phone;
        }
        string GetCustomUser()
        {
            return CustomUser;
        }
    }
}
