using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private string id;
        private Book next;
        public Book(string bookId)

        {

            this.id = bookId;
            this.next = null;

        }
        public string BookId

        {

            get { return this.id; }
            set { this.id = value; }

        }



        public Book Next

        {

            get { return this.Next; }
            set { this.Next = value; }

        }



        public override string ToString()

        {

            return $"Book {this.id}";

        }

    }
}
