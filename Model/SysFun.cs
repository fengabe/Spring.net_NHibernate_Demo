
using System;
using System.Collections;


namespace Model
{
	#region SysFun

	/// <summary>
	/// SysFun object for NHibernate mapped table 'SysFun'.
	/// </summary>
	public class SysFun 
		{
		#region Member Variables
		
		protected int _id;
		protected string _displayName;
		protected int _parentNodeId;
		#endregion

		#region Constructors

		public SysFun() { }

		public SysFun( string displayName, int parentNodeId )
		{
			this._displayName = displayName;
			this._parentNodeId = parentNodeId;
		}

		#endregion

		#region Public Properties

        public virtual int Id
		{
			get {return _id;}
			set {_id = value;}
		}

        public virtual string DisplayName
		{
			get { return _displayName; }
			set
			{
				if ( value != null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for DisplayName", value, value.ToString());
				_displayName = value;
			}
		}

        public virtual int ParentNodeId
		{
			get { return _parentNodeId; }
			set { _parentNodeId = value; }
		}

     
		#endregion
		
       
	}

	#endregion
}
