
using System;
using System.Collections;


namespace Model
{
	#region Book

	/// <summary>
	/// Book object for NHibernate mapped table 'Books'.
	/// </summary>
	public class Book 
		{
		#region Member Variables
		
		protected int _id;
		protected string _title;
		protected string _author;
        protected decimal _unitPrice;
		protected int _clicks;
		protected DateTime _publishDate;
		protected string _iSBN;
		protected int _wordsCount;
		protected string _contentDescription;
		protected string _aurhorDescription;
		protected string _editorComment;
		protected string _tOC;
		protected bool _isrecommend;
		protected Category _category;
		protected Publisher _publisher;
		protected IList _bookBookRatingses;
		protected IList _bookOrderBooks;
	
		
		#endregion

		#region Constructors

		public Book() { }

		public Book( string title, string author, decimal unitPrice, int clicks, DateTime publishDate, string iSBN, int wordsCount, string contentDescription, string aurhorDescription, string editorComment, string tOC, bool isrecommend, Category category, Publisher publisher )
		{
			this._title = title;
			this._author = author;
			this._unitPrice = unitPrice;
			this._clicks = clicks;
			this._publishDate = publishDate;
			this._iSBN = iSBN;
			this._wordsCount = wordsCount;
			this._contentDescription = contentDescription;
			this._aurhorDescription = aurhorDescription;
			this._editorComment = editorComment;
			this._tOC = tOC;
			this._isrecommend = isrecommend;
			this._category = category;
			this._publisher = publisher;
		}

		#endregion

		#region Public Properties

        public virtual int Id
		{
			get {return _id;}
			set {_id = value;}
		}

		public virtual string Title
		{
			get { return _title; }
			set
			{
				if ( value != null && value.Length > 200)
					throw new ArgumentOutOfRangeException("Invalid value for Title", value, value.ToString());
				_title = value;
			}
		}

		public virtual string Author
		{
			get { return _author; }
			set
			{
				if ( value != null && value.Length > 200)
					throw new ArgumentOutOfRangeException("Invalid value for Author", value, value.ToString());
				_author = value;
			}
		}

        public virtual decimal UnitPrice
		{
			get { return _unitPrice; }
			set { _unitPrice = value; }
		}

        public virtual int Clicks
		{
			get { return _clicks; }
			set { _clicks = value; }
		}

        public virtual DateTime PublishDate
		{
			get { return _publishDate; }
			set { _publishDate = value; }
		}

        public virtual string ISBN
		{
			get { return _iSBN; }
			set
			{
				if ( value != null && value.Length > 50)
					throw new ArgumentOutOfRangeException("Invalid value for ISBN", value, value.ToString());
				_iSBN = value;
			}
		}

		public virtual int WordsCount
		{
			get { return _wordsCount; }
			set { _wordsCount = value; }
		}

        public virtual string ContentDescription
		{
			get { return _contentDescription; }
			set
			{
				_contentDescription = value;
			}
		}

        public virtual string AurhorDescription
		{
			get { return _aurhorDescription; }
			set
			{
				_aurhorDescription = value;
			}
		}

        public virtual string EditorComment
		{
			get { return _editorComment; }
			set
			{
				_editorComment = value;
			}
		}

        public virtual string TOC
		{
			get { return _tOC; }
			set
			{
				if ( value != null && value.Length==0  )
					throw new ArgumentOutOfRangeException("Invalid value for TOC", value, value.ToString());
				_tOC = value;
			}
		}

		public virtual bool Isrecommend
		{
			get { return _isrecommend; }
			set { _isrecommend = value; }
		}

        public virtual Category Category
		{
			get { return _category; }
			set { _category = value; }
		}

		public virtual Publisher Publisher
		{
			get { return _publisher; }
			set { _publisher = value; }
		}

        public virtual IList BookBookRatingses
		{
			get
			{
				if (_bookBookRatingses==null)
				{
					_bookBookRatingses = new ArrayList();
				}
				return _bookBookRatingses;
			}
			set { _bookBookRatingses = value; }
		}

        public virtual IList BookOrderBooks
		{
			get
			{
				if (_bookOrderBooks==null)
				{
					_bookOrderBooks = new ArrayList();
				}
				return _bookOrderBooks;
			}
			set { _bookOrderBooks = value; }
		}

	
		#endregion
		
       
	}

	#endregion
}
