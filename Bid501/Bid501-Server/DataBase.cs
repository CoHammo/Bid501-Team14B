using Bid501_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bid501_Library;

namespace Bid501_Server
{
    public class DataBase : IDataBase
    {
        /// <summary>
        /// A list of the bidding items
        /// </summary>
        public List<IProduct> Items { get; }

        /// <summary>
        /// Gets the item from the index
        /// </summary>
        /// <param name="index">The index of the item in the database list</param>
        /// <returns>The product</returns>
        public IProduct GetItem(int index);

        /// <summary>
        /// Adds an item to the database
        /// </summary>
        /// <param name="item">The item being added</param>
        public void AddItem(IProduct item);

        /// <summary>
        /// Removes an item from the database
        /// </summary>
        /// <param name="item">The item being removed</param>
        public void RemoveItem(IProduct item);
    }
}
