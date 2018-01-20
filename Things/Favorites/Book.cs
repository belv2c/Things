using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Things.Favorites
{
    class Book
    {
        protected string _title;
        protected string _author;
        protected bool _isFiction;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }

        public bool IsFiction
        {
            get
            {
                return _isFiction;
            }
            set
            {
                if (value)
                {
                    _isFiction = true;
                }
                if (!value)
                {
                    _isFiction = false;
                }
            }
        }

        public string FictionOrNot(bool IsFiction)
        {
            if (IsFiction)
            {
                return $"{Title} is a book written by {Author} and I like it but I'm a bigger fan of non-fiction books.";
               
            }
               return $"{Title} is a book written by {Author} and it's a cool non-fiction book.";
        }
    }
}
