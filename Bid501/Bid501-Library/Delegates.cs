using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bid501_Library
{
    public class Delegates
    {
        public delegate void PlaceBid(int index, decimal Price);
        public delegate void UpdateView(State state);
        public delegate void Login(string userName, string password);
        public delegate void AddItem(IProduct item);
    }
}
