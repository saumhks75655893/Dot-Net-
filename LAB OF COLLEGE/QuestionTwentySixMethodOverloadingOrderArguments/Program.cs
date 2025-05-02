using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwentySixMethodOverloadingOrderArguments
{
    class MessageSender
    {
        // Method 1: int first, then string
        public void SendMessage(int id, string message)
        {
            Console.WriteLine($"Sending message to user #{id}: {message}");
        }

        // Method 2: string first, then int
        public void SendMessage(string message, int id)
        {
            Console.WriteLine($"Message '{message}' sent to user #{id}");
        }
    }

    class Program
    {
        static void Main()
        {
            MessageSender sender = new MessageSender();

            sender.SendMessage(1101, "Hello! Himanshu Kumar");     // int, string
            sender.SendMessage("Welcome to India, Mr. President", 2201);   // string, int
        }
    }
}
