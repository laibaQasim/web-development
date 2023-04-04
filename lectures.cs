using System;
using System.IO;
namespace HW_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //READ DATA FROM ONE FILE AND WRITE TO OTHER FILE
            FileStream fout = new FileStream("file1.txt", FileMode.Open, FileAccess.Read);
            FileStream fin = new FileStream("file2.txt", FileMode.Create, FileAccess.Write);
            int i = fout.ReadByte();
            char c = (char)i;
            if (i == -1)
                return;

            while (i != -1)
            {
                c = (char)i;
                fin.WriteByte((byte)c);
                i = fout.ReadByte();
                Console.WriteLine(c);

            }
            fin.Close();
            fout.Close();

            //CODE FOR READING FROM FILE
            //for (char ch = 'A'; ch <= 'Z'; ch++)
            //    fout.WriteByte((byte)ch);
            //fout.Close();

        }
    }
}