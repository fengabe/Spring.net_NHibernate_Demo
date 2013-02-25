
using System;
using System.Collections;


namespace Model
{


	
	public class Users 
		{
		
		
		protected int _id;
		protected string _name;
		protected string _address;
		protected string _phone;
		protected string _mail;
		protected int _isOnLine;
		protected string _loginId;
		protected string _loginPwd;
		protected int _gender;
		protected UserRole _userRole;
		protected UserState _userState;
		
		

	

		public Users() { }

		public Users( string name, string address, string phone, string mail, int isOnLine, string loginId, string loginPwd, int gender, UserRole userRole, UserState userState )
		{
			this._name = name;
			this._address = address;
			this._phone = phone;
			this._mail = mail;
			this._isOnLine = isOnLine;
			this._loginId = loginId;
			this._loginPwd = loginPwd;
			this._gender = gender;
			this._userRole = userRole;
			this._userState = userState;
		}




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

		public virtual string Address
		{
			get { return _address; }
			set
			{
				if ( value != null && value.Length > 200)
					throw new ArgumentOutOfRangeException("Invalid value for Address", value, value.ToString());
				_address = value;
			}
		}

		public virtual string Phone
		{
			get { return _phone; }
			set
			{
				if ( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for Phone", value, value.ToString());
				_phone = value;
			}
		}

		public virtual string Mail
		{
			get { return _mail; }
			set
			{
				if ( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for Mail", value, value.ToString());
				_mail = value;
			}
		}

		public virtual int IsOnLine
		{
			get { return _isOnLine; }
			set { _isOnLine = value; }
		}

		public virtual string LoginId
		{
			get { return _loginId; }
			set
			{
				if ( value != null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for LoginId", value, value.ToString());
				_loginId = value;
			}
		}

		public virtual string LoginPwd
		{
			get { return _loginPwd; }
			set
			{
				if ( value != null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for LoginPwd", value, value.ToString());
				_loginPwd = value;
			}
		}

		public virtual int Gender
		{
			get { return _gender; }
			set { _gender = value; }
		}

		public virtual UserRole UserRole
		{
			get { return _userRole; }
			set { _userRole = value; }
		}

		public virtual UserState UserState
		{
			get { return _userState; }
			set { _userState = value; }
		}

		
     
		
		
        
	}

	
}
