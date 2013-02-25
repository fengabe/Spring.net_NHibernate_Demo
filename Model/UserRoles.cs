
using System;
using System.Collections;


namespace Model
{
	#region UserRole

	/// <summary>
	/// UserRole object for NHibernate mapped table 'UserRoles'.
	/// </summary>
	public class UserRole 
		{
		#region Member Variables
		
		protected int _id;
		protected string _name;
		protected IList _userRoleUserses;
		
		#endregion

		#region Constructors

		public UserRole() { }

		public UserRole( string name )
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

        public virtual IList UserRoleUserses
		{
			get
			{
				if (_userRoleUserses==null)
				{
					_userRoleUserses = new ArrayList();
				}
				return _userRoleUserses;
			}
			set { _userRoleUserses = value; }
		}

		#endregion
		
        
	}

	#endregion
}
