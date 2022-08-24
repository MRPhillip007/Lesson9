using System;
using System.Text.RegularExpressions;

namespace ExceptionHw
{
    class RegexFind
    {
        public static string Contact { get { return "[^;]*^[^:]*"; } }
    }
    class RegexValidCheck
    {
        public static string Name { get { return @"^(.{2})"; } }
        public static string Surname { get { return @"^(.{4})"; } }
        public static string Phone { get { return "(^\\+\\d{1,3})\\([0-9]{2}\\)-[0-9]{3}-[0-9]{2}-[0-9]{2}"; } }
    }
}
