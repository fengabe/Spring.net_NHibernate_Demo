
using System;
using System.Collections;


namespace Model
{
	#region Order

	/// <summary>
	/// Order object for NHibernate mapped table 'Orders'.
	/// </summary>
	public class Orders 
		{
		#region Member Variables
		
		protected int _id;
		protected DateTime _orderDate;
		protected decimal _totalPrice;
		protected Users _user;
		protected IList _orderOrderBooks;
		
		#endregion

		#region Constructors

		public Orders() { }

		public Orders( DateTime orderDate, decimal totalPrice, Users user )
		{
			this._orderDate = orderDate;
			this._totalPrice = totalPrice;
			this._user = user;
		}

		#endregion

		#region Public Properties

        public virtual int Id
		{
			get {return _id;}
			set {_id = value;}
		}

        public virtual DateTime OrderDate
		{
			get { return _orderDate; }
			set { _orderDate = value; }
		}

        public virtual decimal TotalPrice
		{
			get { return _totalPrice; }
			set { _totalPrice = value; }
		}

        public virtual Users User
		{
			get { return _user; }
			set { _user = value; }
		}

        public virtual IList OrderOrderBooks
		{
			get
			{
				if (_orderOrderBooks==null)
				{
					_orderOrderBooks = new ArrayList();
				}
				return _orderOrderBooks;
			}
			set { _orderOrderBooks = value; }
		}

     
		#endregion
		
      
	}

	#endregion
}
