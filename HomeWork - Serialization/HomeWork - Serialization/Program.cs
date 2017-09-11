using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace HomeWork___Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Random r = new Random();
            
            for(int i=0;i<3;++i)
            {
                Book book = new Book();
                Console.WriteLine("Введите название книги: ");
                book.Name = Console.ReadLine();
                Console.WriteLine("Введите инициалы автора: ");
                book.Author = Console.ReadLine();
                book.Price = r.NextDouble();
                book.PubDate = DateTime.Now;
                books.Add(book);
            }

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream(@"C:\temp\check.dat", FileMode.OpenOrCreate))
            {
                
                for (int i = 0; i < 3; ++i)
                {
                    formatter.Serialize(fileStream, books[i]);
                }
            }

            using (FileStream fileStream = new FileStream(@"C:\temp\check.dat", FileMode.OpenOrCreate))
            {
                for (int i = 0; i < 3; ++i)
                {
                    Book newBook = (Book)formatter.Deserialize(fileStream);
                    Console.WriteLine("Название книги: {0}, автор книги: {1}, стоимость книги: {2}, дата издания книги: {3}", newBook.Name, newBook.Author,newBook.Price,newBook.PubDate);
                }
            }
            Console.ReadLine();
        }
    }
}
