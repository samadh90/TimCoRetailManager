using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDataManager.Library.Models
{
    public class ProductModel
    {
        /// <summary>
        /// The unique identifier for a given product.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The product name for a given product.
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// The description for a given product.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The retail price for a given product.
        /// </summary>
        public decimal RetailPrice { get; set; }

        /// <summary>
        /// The quantity in stock for a given product.
        /// </summary>
        public int QuantityInStock { get; set; }

        /// <summary>
        /// Is taxable for a given product.
        /// </summary>
        public bool IsTaxable { get; set; }
    }
}
