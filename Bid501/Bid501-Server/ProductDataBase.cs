﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bid501_Library;

namespace Bid501_Server
{
    public class ProductDataBase : IDataBase
    {
        /// <summary>
        /// The product list
        /// </summary>
        public List<IProduct> Items { get; }

        /// <summary>
        /// Updates the proxies
        /// </summary>
        public void UpdateProxies()
        {
            // ********** FINISH ********** //
        }

        /// <summary>
        /// Gets an item from the database
        /// </summary>
        /// <param name="index">The index of the item</param>
        /// <returns>The product</returns>
        public IProduct GetItem(int index)
        {
            // ********** FINISH ********** //
            return Items[index];
        }

        /// <summary>
        /// Adds an item to the database
        /// </summary>
        /// <param name="item">The item being added</param>
        public void AddItem(IProduct item)
        {
            // ********** FINISH ********** //
            Items.Add(item);
        }

        /// <summary>
        /// Removes an item from the database
        /// </summary>
        /// <param name="item">The item being removed</param>
        public void RemoveItem(IProduct item)
        {
            // ********** FINISH ********** //
            Items.Remove(item);
        }
    }
}
