using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        string str;
        int shift;

        Console.Write("Enter string: ");
        str = Console.ReadLine();

        Console.Write("Enter shifting: ");
        shift = int.Parse(Console.ReadLine());

        string alphabet = "абвгдежзиіїйклмнопрстуфхцчшщьюя";

        string cesar_str = "";

        foreach (char ch in str)
        {
            int index = alphabet.IndexOf(ch);
            if (index != -1)
            {
                int newIndex = (index + shift) % alphabet.Length;
                char newChar = alphabet[newIndex];
                cesar_str += newChar;
            }
            else
            {
                cesar_str += ch;
            }
        }

        Console.WriteLine("Cesar string: " + cesar_str);
    }
}