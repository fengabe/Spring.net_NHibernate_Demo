
using System;
using System.Collections;

namespace Model
{
	#region UserState

	/// <summary>
	/// UserState object for NHibernate mapped table 'UserStates'.
	/// </summary>
	public class UserState 
		{
		#region Member Variables
		
		protected int _id;
		protected string _name;
		protected IList _userStateUserses;
		
		#endregion

		#region Constructors

		public UserState() { }

		public UserState( string name )
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
				if ( value != null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for Name", value, value.ToString());
				_name = value;
			}
		}

        public virtual IList UserStateUserses
		{
			get
			{
				if (_userStateUserses==null)
				{
					_userStateUserses = new ArrayList();
				}
				return _userStateUserses;
			}
			set { _userStateUserses = value; }
		}

      
		#endregion
		
        
	}

	#endregion
}
