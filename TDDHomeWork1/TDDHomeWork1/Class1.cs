using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDHomeWork1
{
    
   public class PagingGroup
    {
        public int[] GroupingFieldValues(List<Order> data, string fieldname, int pagingcount)
        {
            throw new NotImplementedException();
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revence { get; set; }
        public int SellPrice { get; set; }
    }
}
