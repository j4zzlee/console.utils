using System;

namespace st2forget.console.utils.test
{
    class Program
    {
        static void Main(string[] args)
        {
            "db:migrate:up{t:40}Migrate up database version".PrettyPrint(ConsoleColor.White);
            $"db:migrate:up{{t:40}}Migrate up database version".PrettyPrint(ConsoleColor.White);
            "\tdb:migrate:up{t:40}Migrate up database version".PrettyPrint(ConsoleColor.White);
            $"\tdb:migrate:up{{t:40}}Migrate up database version".PrettyPrint(ConsoleColor.White);

            $"\t{{f:Green}}-t|--ticket{{f:d}}{{t:30}}{{f:Red}}Required{{f:d}}{{t:20}}ABC XYZ".PrettyPrint(ConsoleColor.White);
            $"\t{{f:Green}}-t|--ticket{{f:d}}{{t:30}}{{t:20}}ABC XYZ".PrettyPrint(ConsoleColor.White);
            $"\t{{f:Green}}-t|--ticket{{f:d}}{{t:30}}{{f:Red}}RequiredRequiredRequiredRequiredRequiredRequiredRequired{{f:d}}{{t:20}}ABC XYZ".PrettyPrint(ConsoleColor.White);
            Console.ReadKey();
        }
    }
}