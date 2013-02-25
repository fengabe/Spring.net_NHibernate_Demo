
using System;
using System.Collections;

namespace Model
{
	#region Publisher

	/// <summary>
	/// Publisher object for NHibernate mapped table 'Publishers'.
	/// </summary>
	public class Publisher 
		{
		#region Member Variables
		
		protected int _id;
		protected string _name;
		protected IList _publisherBookses;
		
		#endregion

		#region Constructors

		public Publisher() { }

		public Publisher( string name )
		{
			this._name = name;
		}

		#endregion

		#region Public Properties

        public virtual int Id
		{
			get {return _id;}
			set {_id = value;}
		}

        public virtual string Name
		{
			get { return _name; }
			set
			{
				if ( value != null && value.Length > 200)
					throw new ArgumentOutOfRangeException("Invalid value for Name", value, value.ToString());
				_name = value;
			}
		}

        public virtual IList PublisherBookses
		{
			get
			{
				if (_publisherBookses==null)
				{
					_publisherBookses = new ArrayList();
				}
				return _publisherBookses;
			}
			set { _publisherBookses = value; }
		}

       
		#endregion
		
      
	}

	#endregion
}
