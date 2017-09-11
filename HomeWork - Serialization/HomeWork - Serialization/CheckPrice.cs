using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork___Serialization
{
    public class CheckPrice:System.Attribute
    {
        public double Price { get; set; }
        public CheckPrice(double price)
        {
            if(price>1 || price<0)
            {
                Console.WriteLine("Цена вышла за рамки стандарта, она будет установлена автоматический на 0.");
                price = 0;
                Console.ReadLine();
            }
            else
            {
                Price = price;
            }
        }

        //Прошу прощения за эту галиматью, это последнее ДЗ и "лишь бы сдать", в голову ничего толкового не пришло.
    }
}
