using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore
{
    public class ShoppingCart
    {
        public List<ShoppingCartItem> Items { get; set; }

        public ShoppingCart ()
    	{
            Items = new List<ShoppingCartItem>();
	    }

        public void Add(ShoppingCartItem item)
        {
            Items.Add(item);
        }

        public double Sum()
        {
            return 0;
        }
    }
}
