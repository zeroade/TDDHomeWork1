using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDHomeWork1
{
    public class PagingGroup
    {
        public IEnumerable<int> GroupingFieldValues<T>(IEnumerable<T> data, string fieldName, int pagingCount)
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
