using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int AlbumID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public Album Album { get; set; }
        public Order Order { get; set; }
    }
}
