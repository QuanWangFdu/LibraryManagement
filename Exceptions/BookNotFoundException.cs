using System;

namespace LibraryManagement.Exceptions
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException(int bookId)
            : base($"The book with ID {bookId} was not found in the library system.")
        {
        }
    }
}