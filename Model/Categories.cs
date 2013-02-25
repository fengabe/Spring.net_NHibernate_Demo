
using System;
using System.Collections;


namespace Model
{
	#region Category

	/// <summary>
	/// Category object for NHibernate mapped table 'Categories'.
	/// </summary>
	public class Category 
		{
		#region Member Variables
		
		protected int _id;
		protected string _name;
		protected int _parentId;
		protected IList _categoryBookses;
		
		#endregion

		#region Constructors

		public Category() { }

		public Category( string name, int parentId )
		{
			this._name = name;
			this._parentId = parentId;
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

        public virtual int ParentId
		{
			get { return _parentId; }
			set { _parentId = value; }
		}

        public virtual IList CategoryBookses
		{
			get
			{
				if (_categoryBookses==null)
				{
					_categoryBookses = new ArrayList();
				}
				return _categoryBookses;
			}
			set { _categoryBookses = value; }
		}

      
		#endregion
		
        
	}

	#endregion
}
