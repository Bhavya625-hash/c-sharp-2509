using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__exceptionalhandling
{
    public class Library

    {
        public string[] books;
        public Library(int size)
        {
            books = new string[size];
        }

        public void AddBook(int index, string title)
        {
            if (index >= 0 && index < books.Length)
            {
                books[index] = title;
            }
            else
            {
                Console.WriteLine("Index out of range.");
            }
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Library Books:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

        }
        public class Classroom
        {
            private string[,] seats;

            public Classroom(int rows, int columns)
            {
                seats = new string[rows, columns];
            }

            public void AssignSeat(int row, int column, string studentName)
            {
                if (row >= 0 && row < seats.GetLength(0) && column >= 0 && column < seats.GetLength(1))
                {
                    seats[row, column] = studentName;
                }
                else
                {
                    Console.WriteLine("Seat position out of range.");
                }
            }

            public void DisplaySeatingArrangement()
            {
                Console.WriteLine("Classroom Seating Arrangement:");
                for (int i = 0; i < seats.GetLength(0); i++)
                {
                    for (int j = 0; j < seats.GetLength(1); j++)
                    {
                        Console.Write($"[{seats[i, j]}]\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
