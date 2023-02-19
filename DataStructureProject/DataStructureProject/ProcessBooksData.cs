using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProject
{
    public class ProcessBooksData
    {
        //Created ReadDataFile object to show books by category without needing to load all the books first
        public ReadDataFile readData = new ReadDataFile();

        //Creating separate stacks for each book category
        public Stack <Book> getComputerScienceBooks()
        {
            //Reading each book
            readData.readFile();
            Stack<Book> ComputerScience = new Stack<Book>();
            foreach (Book book in BookDataStructure.books)
            {
                if (book.Category.Equals("Computer Science"))
                {
                    //Adds every Computer Science book in the stack
                    ComputerScience.Push(book);
                }
            }
            return ComputerScience;
        }

        public Stack<Book> getNetworkingBooks()
        {
            readData.readFile();
            Stack<Book> Networking = new Stack<Book>();
            foreach (Book book in BookDataStructure.books)
            {
                if (book.Category.Equals("Computer Networks"))
                {
                    Networking.Push(book);
                }
            }
            return Networking;
        }

        public Stack<Book> getMathematicsBooks()
        {
            readData.readFile();
            Stack<Book> Mathematics = new Stack<Book>();
            foreach (Book book in BookDataStructure.books)
            {
                if (book.Category.Equals("Mathematics"))
                {
                    Mathematics.Push(book);
                }
            }
            return Mathematics;
        }

        public Stack<Book> getSoftwareDevelopmentBooks()
        {
            readData.readFile();
            Stack<Book> softwareDevelopment = new Stack<Book>();
            foreach (Book book in BookDataStructure.books)
            {
                if (book.Category.Equals("Software Development"))
                {
                    softwareDevelopment.Push(book);
                }
            }
            return softwareDevelopment;
        }
    }
}
