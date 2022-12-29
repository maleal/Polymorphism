using System;

namespace Polymorphis_Interfaces
{
    public class Program
    {


        public static void Main()
        {
            IFile file1 = new FileInfo();

            FileInfo file2 = new FileInfo();
            UsbInfo usb2 = new UsbInfo();

            file1.ReadFile();
            file1.WriteFile("file content");

            file2.ReadFile();
            file2.WriteFile("file content");

            Caller(file2);
            Caller(usb2);

        }

        public static void Caller(IFile fce)
        {
            fce.WriteFile("-Caller-");
        }
    }

    public interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
    }

    class FileInfo : IFile
    {
        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        public void WriteFile(string text)
        {
            Console.WriteLine("Writing to File:{0}", text);
        }
    }

    class UsbInfo : IFile
    {
        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        public void WriteFile(string text)
        {
            Console.WriteLine("Writing to Usb:{0}", text);
        }
    }

}
