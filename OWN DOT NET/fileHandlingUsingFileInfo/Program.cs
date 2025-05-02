using System;
using System.IO;

namespace fileHandlingUsingFileInfo
{
    // FileInfo class provides instance methods for creating, copying, deleting, moving, and opening files.

    class FileHandlingUsingFileInfo
    {
        //path to the file
        string filePath = @"D:\ALL PROGRAMMING\Dot-Net-\OWN DOT NET\fileHandlingUsingFileInfo\hello.txt";


        // creation of the file
        public void CreateFile()
        {
            FileInfo fileInfo = new FileInfo(filePath);
            if (!fileInfo.Exists)
            {
                fileInfo.Create();
                Console.WriteLine("File created successfully.");
            }
            else
            {
                Console.WriteLine("File already exists.");
            }
        }

        // writing to the file
        public void WriteToFile()
        {
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
            {
                using (StreamWriter writer = fileInfo.CreateText())
                {
                    writer.WriteLine("It pauses the program execution.\r\n\r\nOnce the user presses any key, the method returns, and the program continues (or exits if it's the last line).");
                    Console.WriteLine("Data written to file successfully.");
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }

        // reading from the file
        public void ReadFromFile()
        {
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
            {
                using (StreamReader reader = fileInfo.OpenText())
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine("Data read from file:  " + content);
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }

        // Check file properties 
        public void CheckFileProperties()
        {
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
            {
                Console.WriteLine("File Name: " + fileInfo.Name);
                Console.WriteLine("File Size: " + fileInfo.Length + " bytes");
                Console.WriteLine("File Creation Time: " + fileInfo.CreationTime);
                Console.WriteLine("File Last Access Time: " + fileInfo.LastAccessTime);
                Console.WriteLine("File Last Write Time: " + fileInfo.LastWriteTime);
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }

        // copy the file 
        public void CopyFile()
        {
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
            {
                string copyPath = @"D:\ALL PROGRAMMING\Dot-Net-\OWN DOT NET\fileHandlingUsingFileInfo\hello_copy.txt";
                fileInfo.CopyTo(copyPath, true);
                Console.WriteLine("File copied successfully To the path " + copyPath);
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }

        // move the file
        public void MoveFile()
        {
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
            {
                string movePath = @"D:\ALL PROGRAMMING\Dot-Net-\OWN DOT NET\FileHandling\hello_move.txt";
                fileInfo.MoveTo(movePath);
                Console.WriteLine("File moved successfully to the path " + movePath);
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }

        // delete the moved file
        public void DeleteMovedFile()
        {
            string movedPath = @"D:\ALL PROGRAMMING\Dot-Net-\OWN DOT NET\FileHandling\hello_move.txt";
            FileInfo moveFile = new FileInfo(movedPath);
            if (moveFile.Exists)
            {
                moveFile.Delete();
                Console.WriteLine("Moved file deleted successfully.");
            }
            else
            {
                Console.WriteLine("Moved file does not exist.");
            }
        }

        // copy file delete

        public void DeleteCopiedFile()
        {
            string copiedPath = @"D:\ALL PROGRAMMING\Dot-Net-\OWN DOT NET\fileHandlingUsingFileInfo\hello_copy.txt";
            FileInfo copyFile = new FileInfo(copiedPath);
            if (copyFile.Exists)
            {
                copyFile.Delete();
                Console.WriteLine("Copied file deleted successfully.");
            }
            else
            {
                Console.WriteLine("Copied file does not exist.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // object creation of the class fileHandlingUsingFileInfo
            FileHandlingUsingFileInfo fileHandling = new FileHandlingUsingFileInfo();

            // calling the methods
            //fileHandling.CreateFile();
            //fileHandling.WriteToFile();
            //fileHandling.ReadFromFile();
            //fileHandling.CheckFileProperties();
            //fileHandling.CopyFile();
            //fileHandling.MoveFile();
            //fileHandling.DeleteMovedFile();
            fileHandling.DeleteCopiedFile();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
