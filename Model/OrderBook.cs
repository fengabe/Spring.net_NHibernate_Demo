
using System;
using System.Collections;


namespace Model
{
	#region OrderBook

	/// <summary>
	/// OrderBook object for NHibernate mapped table 'OrderBook'.
	/// </summary>
	public class OrderBook 
		{
		#region Member Variables
		
		protected int _id;
		protected int _quantity;
		protected decimal _unitPrice;
		protected Book _book;
		protected Orders _order;
		
		#endregion

		#region Constructors

		public OrderBook() { }

		public OrderBook( int quantity, decimal unitPrice, Book book, Orders order )
		{
			this._quantity = quantity;
			this._unitPrice = unitPrice;
			this._book = book;
			this._order = order;
		}

		#endregion

		#region Public Properties

        public virtual int Id
		{
			get {return _id;}
			set {_id = value;}
		}

        public virtual int Quantity
		{
			get { return _quantity; }
			set { _quantity = value; }
		}

        public virtual decimal UnitPrice
		{
			get { return _unitPrice; }
			set { _unitPrice = value; }
		}

        public virtual Book Book
		{
			get { return _book; }
			set { _book = value; }
		}

        public virtual Orders Order
		{
			get { return _order; }
			set { _order = value; }
		}

      
		#endregion
		
	}

	#endregion
}
