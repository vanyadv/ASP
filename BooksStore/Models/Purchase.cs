using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksStore.Models
{
    public class Purchase
    {
        public int purchaseID { get; set; }

        public int clientName { get; set; }
        public int clientAddress { get; set; }
        public int bookId { get; set; }
        public DateTime Date
        {
            get; set;
        }
    }
}