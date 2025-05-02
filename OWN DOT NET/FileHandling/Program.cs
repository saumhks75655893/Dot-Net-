using System;
using System.IO; 

namespace FileHandling
{
    class fileHandlinginCSharp
    {
        //path of the file 
        string path = @"D:\ALL PROGRAMMING\Dot-Net-\OWN DOT NET\FileHandling\text.txt";
        // using FileStream

        // write in the file 
        public void writeToFile()
        {
            try
            {
                string text = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z..";

                // Create a new file and write text to it
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(text);
                fs.Write(bytes, 0, bytes.Length);


                Console.WriteLine("Files have been created and written successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        // read from the file
        public void readFromFile()
        {
            try
            {
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                byte[] bytes = new byte[fileStream.Length];
                fileStream.Read(bytes, 0, bytes.Length);
                string text = System.Text.Encoding.UTF8.GetString(bytes);
                Console.WriteLine("Text read from file: " + text);
            }catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            fileHandlinginCSharp fs = new fileHandlinginCSharp();

            //fs.writeToFile();
            fs.readFromFile();
        }
    }
}
