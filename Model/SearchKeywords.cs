
using System;
using System.Collections;


namespace Model
{
	#region SearchKeyword

	/// <summary>
	/// SearchKeyword object for NHibernate mapped table 'SearchKeywords'.
	/// </summary>
	public class SearchKeyword 
		{
		#region Member Variables
		
		protected int _id;
		protected string _keyword;
		protected int _searchCount;
		
		#endregion

		#region Constructors

		public SearchKeyword() { }

		public SearchKeyword( string keyword, int searchCount )
		{
			this._keyword = keyword;
			this._searchCount = searchCount;
		}

		#endregion

		#region Public Properties

        public virtual int Id
		{
			get {return _id;}
			set {_id = value;}
		}

        public virtual string Keyword
		{
			get { return _keyword; }
			set
			{
				if ( value != null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for Keyword", value, value.ToString());
				_keyword = value;
			}
		}

        public virtual int SearchCount
		{
			get { return _searchCount; }
			set { _searchCount = value; }
		}

       
		#endregion
		
        
	}

	#endregion
}
