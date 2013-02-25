
using System;
using System.Collections;


namespace Model
{
	#region BookRating

	/// <summary>
	/// BookRating object for NHibernate mapped table 'BookRatings'.
	/// </summary>
	public class BookRating 
		{
		#region Member Variables
		
		protected int _id;
		protected int _rating;
		protected string _comment;
		protected Book _book;
		protected Users _user;
		
		#endregion

		#region Constructors

		public BookRating() { }

		public BookRating( int rating, string comment, Book book, Users user )
		{
			this._rating = rating;
			this._comment = comment;
			this._book = book;
			this._user = user;
		}

		#endregion

		#region Public Properties

		public virtual int Id
		{
			get {return _id;}
			set {_id = value;}
		}

		public virtual int Rating
		{
			get { return _rating; }
			set { _rating = value; }
		}

		public virtual string Comment
		{
			get { return _comment; }
			set
			{
				if ( value != null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for Comment", value, value.ToString());
				_comment = value;
			}
		}

		public virtual Book Book
		{
			get { return _book; }
			set { _book = value; }
		}

		public virtual Users User
		{
			get { return _user; }
			set { _user = value; }
		}

       
		#endregion
		
        
	}

	#endregion
}
