using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Shelf
    {
        private Book head;
        private Book tail;
        private int count;
        public Shelf()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }
        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }
        public void AddBook(string bookId)
        {
            if (this.head == null)
            {
                var next = new Book(bookId);
                this.head = next;
                this.tail = next;
            }
            else
            {
                var next = new Book(bookId);
                tail.Next = next;
                tail = next;
            }

            this.Count++;
        }
        public void AddSpecialBook(string bookId)
        {
            if (this.head == null)
            {
                var next = new Book(bookId);
                this.head = next;
                this.tail = next;
            }
            else
            {

                var next = new Book(bookId);
                next.Next = head;
                this.head = next;


            }
            this.Count++;
        }

        public Book CheckBookIsPresent(string bookId)
        {
            throw new NotImplementedException();
        }

        public bool ReleaseBook(string bookId)
        {
            throw new NotImplementedException();
        }

        public bool ReleaseBook(int index)
        {


        }

        public StringBuilder ShelfInformation()
        {
            StringBuilder sb = new StringBuilder();
            if (count > 0)
            {
                Book g = head;
                for (int i = 0; i < count; i++)
                {
                    sb.AppendLine(g.ToString());
                    g = g.Next;
                }
                return sb;
            }
            else
            {
                return null;
            }
        }

    }
}