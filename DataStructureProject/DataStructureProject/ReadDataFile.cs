using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProject
{
    public class ReadDataFile
    {
        public Queue<Book> readFile()
        {
            //To read .txt file
            StreamReader reader = new StreamReader("Data.txt");

            string lines = "";

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            while ((lines = reader.ReadLine()) != null)
            {
                string[] words = lines.Split(',');

                //Creating Book Object
                Book book = new Book();
                book.ISBN = words[0];
                book.Author = words[1];
                //Checking if author has : and splitting the names
                if (book.Author.Contains(':'))
                {
                    string[] names = book.Author.Split(':');
                    book.Author = names[0];
                    book.Second_Author = names[1];
                    book.Book_Name = words[2];
                    book.Publisher = words[3];
                    book.Released_Year = int.Parse(words[4]);
                    book.Category = words[5];
                }
                else
                {
                    book.Second_Author = "None";
                    book.Book_Name = words[2];
                    book.Publisher = words[3];
                    book.Released_Year = int.Parse(words[4]);
                    book.Category = words[5];
                }

                //Keeping only books that are published after 1990 and those that belong in the following categories
                if (book.Released_Year > 1990 && (book.Category.Contains("Mathematics") || book.Category.Contains("Computer Networks") || book.Category.Contains("Computer Science") || book.Category.Contains("Software Development")))
                {
                    //Validation to ensure that imported data will not be repeated after clicking button again
                    int originalBookCount = File.ReadLines("Data.txt").Count();
                    int loadedBookCount = BookDataStructure.books.Count();

                    if(loadedBookCount < originalBookCount)
                    {
                        //Adding it to the queue if it meets the condition
                        BookDataStructure.books.Enqueue(book);
                    }                              
                }
                else
                {
                    MessageBox.Show("Released Year must be after 1990");
                }
            }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            return BookDataStructure.books;
        }
    }
}
