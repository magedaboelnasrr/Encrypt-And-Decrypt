using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {


        // Encrypt Function
        static string Encrypt(string Text)
        {
            Text = Convert.ToBase64String(Encoding.Unicode.GetBytes(Text));
            return Text;
        }

        // Decrypt Function
        static string Decrypt(string Text)
        {
            Text = Encoding.Unicode.GetString(Convert.FromBase64String(Text));
            return Text;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Text");
            Console.ForegroundColor = ConsoleColor.Green;
            string text = Console.ReadLine();

           var encrypted =  Encrypt(text);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The Encrypted Text you Entered : {encrypted} " );

            var decrypted = Decrypt(encrypted);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The Decrypted Text :  {decrypted} ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
    }
}
