﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twobooks
{
    struct book
    {

        public string title;
        public string author;

    }
    class NoBooks
    {
        public static void Main()
        {
            book[] books = new book[2];
            int i, j;
            Console.WriteLine("Insert The Information of Two Books.");
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("Information of book : {0} ", i + 1);

                Console.Write("Input name of the book : ");
                books[i].title = Console.ReadLine();

                Console.Write("Input the author : ");
                books[i].author = Console.ReadLine();
                Console.WriteLine();
            }

            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("{0}: Title = {1},  Author = {2}", i + 1, books[i].title, books[i].author);
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
