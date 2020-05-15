using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        #region Private Fields

        private BindingList<string> _products;
		private BindingList<string> _cart;
		private int _itemQuantity;

		#endregion

		#region Public Properties

		/// <summary>
		/// Products
		/// </summary>
		public BindingList<string> Products
		{
			get { return _products; }
			set 
			{ 
				_products = value;
				NotifyOfPropertyChange(() => Products);
			}
		}

		/// <summary>
		/// Cart
		/// </summary>
		public BindingList<string> Cart
		{
			get { return _cart; }
			set
			{
				_cart = value;
				NotifyOfPropertyChange(() => Cart);
			}
		}

		/// <summary>
		/// ItemQuantity
		/// </summary>
		public int ItemQuantity
		{
			get { return _itemQuantity; }
			set
			{ 
				_itemQuantity = value;
				NotifyOfPropertyChange(() => ItemQuantity);
			}
		}


		#endregion

		/// <summary>
		/// SubTotal
		/// </summary>
		public string SubTotal
		{
			get
			{
				// TODO - Replace with calculation
				return "$0.00";
			}
		}

		/// <summary>
		/// Tax
		/// </summary>
		public string Tax
		{
			get
			{
				// TODO - Replace with calculation
				return "$0.00";
			}
		}

		/// <summary>
		/// Total
		/// </summary>
		public string Total
		{
			get
			{
				// TODO - Replace with calculation
				return "$0.00";
			}
		}

		public bool CanAddToCart
		{
			get
			{
				bool output = false;

				// Make sure something is selected
				// Make sure there is an item quantity

				return output;
			}
		}

		public void AddToCart()
		{

		}

		public bool CanRemoveFromCart
		{
			get
			{
				bool output = false;

				// Make sure something is selected

				return output;
			}
		}

		public void RemoveFromCart()
		{

		}

		public bool CanCheckOut
		{
			get
			{
				bool output = false;

				// Make sure something is in the cart

				return output;
			}
		}

		public void CheckOut()
		{

		}
	}
}
