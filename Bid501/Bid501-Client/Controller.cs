using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bid501_Library;

namespace Bid501_Client
{
    public class Controller
    {
        DataBaseProxy DataBase;

        private Delegates.UpdateView UpdateView();

        /// <summary>
        /// Method when the database gets updated
        /// </summary>
        public void OnDatabaseUpdate()
        {

        }

        /// <summary>
        /// Updates the view
        /// </summary>
        /// <param name="state">The current state</param>
        public void UpdateView(State state)
        {

        }

        /// <summary>
        /// Handles the PlaceBid Delegate
        /// </summary>
        /// <param name="product">The product being bidded</param>
        /// <param name="amount">The bid amount</param>
        public void PlaceBid(ProductProxy product, decimal amount)
        {

        }

        /// <summary>
        /// Logs the user into the database
        /// </summary>
        /// <param name="userName">Username</param>
        /// <param name="password">Password</param>
        public void Login(string userName, string password)
        {

        }
    }
}
