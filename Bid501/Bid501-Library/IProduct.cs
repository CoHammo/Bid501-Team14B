namespace Bid501_Library
{
    public interface IProduct
    {
        /// <summary>
        /// The name of the product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The price of the product
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The description of the product
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The index of the item in the database
        /// </summary>
        public int DBIndex { get; set; }

        /// <summary>
        /// The time that the bidding ends
        /// </summary>
        public DateTime BidEndTime { get; set; }

        /// <summary>
        /// The amount of bids on the product
        /// </summary>
        public int NumBids { get; set; }
    }
}