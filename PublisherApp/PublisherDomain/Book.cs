using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherDomain
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public decimal BestPrice { get; set; }
        public Author? Author { get; set; }
        public int? AuthorFK { get; set; }
    }
}
