using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void showInfo(DirectoryInfo dir, int cursor) // create class to write thenames of folder and files
        {
            Console.Clear(); 
            FileSystemInfo[] infos = dir.GetFileSystemInfos(); // get all folders and files
            for (int i = 0; i < infos.Length; i++)
            {
               
                Console.BackgroundColor = (i == cursor) ? ConsoleColor.Blue : ConsoleColor.Black; //if the cursor is on the fail or folder, it is blue, the others are black
                
                Console.ForegroundColor = (infos[i].GetType() == typeof(DirectoryInfo)) ? ConsoleColor.Yellow : ConsoleColor.Magenta; // checking if it's folder then yellow, if it's fail then pink

                Console.WriteLine(infos[i].Name); // show the names of the folders and files
            }
        }

        static void F1(string fil) // create function that will bring out the contents of the files
        {
            FileStream f = new FileStream(fil, FileMode.Open, FileAccess.Read); // cretae constructor to read the contents
            StreamReader sr = new StreamReader(f); // create class that will read and write the quantity of symbols

            string text = sr.ReadToEnd();

            Console.WriteLine(text); // write the contents on the console

            sr.Close();
            f.Close();
        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false; // making cursor invisible
            int cursor = 0;
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Aida\Desktop\track"); // assigning the path to dir

            while (true)
            {
                showInfo(dir, cursor);
                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow: // if user pressed uparrow
                        if (cursor > 0) cursor--; // until it is not less than the 0 element, cursor goes up
                        break;
                    case ConsoleKey.DownArrow: // if user pressed downarrow
                        if (cursor < dir.GetFileSystemInfos().Length - 1) cursor++; // until it is not more than the quantity of files, cursor goes down
                        break;
                    case ConsoleKey.Enter: // if user pressed enter
                        FileSystemInfo fs = dir.GetFileSystemInfos()[cursor]; // 
                        if (fs.GetType() == typeof(DirectoryInfo)) // check if it's folder
                        {
                            dir = new DirectoryInfo(fs.FullName); // when we open the folder, we add new path to dir
                        }
                        else // when we open the file
                        {
                            //Process.Start(fs.FullName);

                            string fil = fs.FullName;

                            F1(fil);
                        }
                        break;
                    case ConsoleKey.Escape: // if user pressed escape
                        dir = dir.Parent; // return to the previous stage
                        break;
                    case ConsoleKey.Backspace: // if user ipressed backspace
                        dir = dir.Parent; // return to the previous stage
                        break;
                }
            }
        }
    }
}