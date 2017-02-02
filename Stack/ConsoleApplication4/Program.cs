using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;//убираем видимость курсора
            Stack<string> level = new Stack<string>();//создаем стэк
            level.Push(@"C:\Users\Aida\Desktop\track"); //прописываем путь к папке
            while (true)//ставим условие - пока папка не пуста
            {
                DirectoryInfo f = new DirectoryInfo(level.Pop());// функция pop возвращает первый стоящий файл и удаляет его
                DirectoryInfo[] dirs = f.GetDirectories();// создаем массив для папок
                FileInfo[] files = f.GetFiles();// массив для файлов

                Console.WriteLine("Directories:" + f.GetDirectories().Length);//выводим количество папок
                foreach (DirectoryInfo d in dirs)
                {
                    level.Push(d.FullName);//выводим название папки
                }
                Console.WriteLine("Files:" + f.GetFiles().Length);//выводим количество файлолв
                foreach (FileInfo file in files)
                {

                    Console.WriteLine(file.Name);//название файлов
                }

            }
        }
    }
}
