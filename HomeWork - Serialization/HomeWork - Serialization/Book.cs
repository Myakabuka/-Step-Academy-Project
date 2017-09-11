using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork___Serialization
{
    [Serializable]
    [CheckPrice(0.3)]
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public DateTime PubDate { get; set; }
    }
}
