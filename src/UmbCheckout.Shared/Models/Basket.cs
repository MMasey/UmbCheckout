﻿namespace UmbCheckout.Shared.Models
{
    /// <summary>
    /// The Basket model
    /// </summary>
    public class Basket
    {
        private decimal _total;
        public string Id { get; set; } = string.Empty;

        public string SessionId { get; set; } = string.Empty;

        public IEnumerable<LineItem> LineItems { get; set; } = Enumerable.Empty<LineItem>();

        public long ItemCount => LineItems.Count();

        public decimal Total
        {
            get
            {
                if (_total == default)
                {
                    _total = LineItems.Select(x => x.Price).Sum();
                }

                return _total;
            }

            set => _total = value;
        }
    }
}
