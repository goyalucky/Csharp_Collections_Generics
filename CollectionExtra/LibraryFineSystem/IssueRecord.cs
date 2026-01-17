using System;

namespace LibraryFineSystem
{
    // Stores issue & return details of a book
    public class IssueRecord
    {
        public int BookId;
        public DateTime DueDate;
        public DateTime ReturnDate;

        public IssueRecord(int bookId, DateTime due, DateTime ret)
        {
            BookId = bookId;
            DueDate = due;
            ReturnDate = ret;
        }
    }
}
