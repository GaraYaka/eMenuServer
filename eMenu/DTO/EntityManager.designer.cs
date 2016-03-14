﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eMenu.DTO
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="emenu")]
	public partial class EntityManagerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTB_Test(TB_Test instance);
    partial void UpdateTB_Test(TB_Test instance);
    partial void DeleteTB_Test(TB_Test instance);
    partial void Inserttb_foodItem(tb_foodItem instance);
    partial void Updatetb_foodItem(tb_foodItem instance);
    partial void Deletetb_foodItem(tb_foodItem instance);
    partial void Inserttb_menu(tb_menu instance);
    partial void Updatetb_menu(tb_menu instance);
    partial void Deletetb_menu(tb_menu instance);
    partial void Inserttb_hotdishe(tb_hotdishe instance);
    partial void Updatetb_hotdishe(tb_hotdishe instance);
    partial void Deletetb_hotdishe(tb_hotdishe instance);
    partial void Inserttb_user(tb_user instance);
    partial void Updatetb_user(tb_user instance);
    partial void Deletetb_user(tb_user instance);
    #endregion
		
		public EntityManagerDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["emenuConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EntityManagerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntityManagerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntityManagerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EntityManagerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tb_customer> tb_customers
		{
			get
			{
				return this.GetTable<tb_customer>();
			}
		}
		
		public System.Data.Linq.Table<TB_Test> TB_Tests
		{
			get
			{
				return this.GetTable<TB_Test>();
			}
		}
		
		public System.Data.Linq.Table<tb_foodItem> tb_foodItems
		{
			get
			{
				return this.GetTable<tb_foodItem>();
			}
		}
		
		public System.Data.Linq.Table<tb_menu> tb_menus
		{
			get
			{
				return this.GetTable<tb_menu>();
			}
		}
		
		public System.Data.Linq.Table<tb_hotdishe> tb_hotdishes
		{
			get
			{
				return this.GetTable<tb_hotdishe>();
			}
		}
		
		public System.Data.Linq.Table<tb_user> tb_users
		{
			get
			{
				return this.GetTable<tb_user>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_customer")]
	public partial class tb_customer
	{
		
		private int _ID;
		
		private string _name;
		
		private int _number;
		
		private string _lname;
		
		private System.Nullable<bool> _gender;
		
		private string _email;
		
		private string _location;
		
		private System.Nullable<int> _points;
		
		public tb_customer()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this._name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_number", DbType="Int NOT NULL")]
		public int number
		{
			get
			{
				return this._number;
			}
			set
			{
				if ((this._number != value))
				{
					this._number = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lname", DbType="VarChar(50)")]
		public string lname
		{
			get
			{
				return this._lname;
			}
			set
			{
				if ((this._lname != value))
				{
					this._lname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="Bit")]
		public System.Nullable<bool> gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this._gender = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this._email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_location", DbType="VarChar(50)")]
		public string location
		{
			get
			{
				return this._location;
			}
			set
			{
				if ((this._location != value))
				{
					this._location = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_points", DbType="Int")]
		public System.Nullable<int> points
		{
			get
			{
				return this._points;
			}
			set
			{
				if ((this._points != value))
				{
					this._points = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TB_Test")]
	public partial class TB_Test : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _test;
		
		private string _d;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntestChanging(string value);
    partial void OntestChanged();
    partial void OndChanging(string value);
    partial void OndChanged();
    #endregion
		
		public TB_Test()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_test", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string test
		{
			get
			{
				return this._test;
			}
			set
			{
				if ((this._test != value))
				{
					this.OntestChanging(value);
					this.SendPropertyChanging();
					this._test = value;
					this.SendPropertyChanged("test");
					this.OntestChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_d", DbType="NChar(10)")]
		public string d
		{
			get
			{
				return this._d;
			}
			set
			{
				if ((this._d != value))
				{
					this.OndChanging(value);
					this.SendPropertyChanging();
					this._d = value;
					this.SendPropertyChanged("d");
					this.OndChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_foodItems")]
	public partial class tb_foodItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _name;
		
		private string _img;
		
		private System.Nullable<decimal> _price;
		
		private int _CatID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnimgChanging(string value);
    partial void OnimgChanged();
    partial void OnpriceChanging(System.Nullable<decimal> value);
    partial void OnpriceChanged();
    partial void OnCatIDChanging(int value);
    partial void OnCatIDChanged();
    #endregion
		
		public tb_foodItem()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_img", DbType="VarChar(MAX)")]
		public string img
		{
			get
			{
				return this._img;
			}
			set
			{
				if ((this._img != value))
				{
					this.OnimgChanging(value);
					this.SendPropertyChanging();
					this._img = value;
					this.SendPropertyChanged("img");
					this.OnimgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(16,2)")]
		public System.Nullable<decimal> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CatID", DbType="Int NOT NULL")]
		public int CatID
		{
			get
			{
				return this._CatID;
			}
			set
			{
				if ((this._CatID != value))
				{
					this.OnCatIDChanging(value);
					this.SendPropertyChanging();
					this._CatID = value;
					this.SendPropertyChanged("CatID");
					this.OnCatIDChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_menu")]
	public partial class tb_menu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _catID;
		
		private string _itemName;
		
		private string _catImg;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncatIDChanging(int value);
    partial void OncatIDChanged();
    partial void OnitemNameChanging(string value);
    partial void OnitemNameChanged();
    partial void OncatImgChanging(string value);
    partial void OncatImgChanged();
    #endregion
		
		public tb_menu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_catID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int catID
		{
			get
			{
				return this._catID;
			}
			set
			{
				if ((this._catID != value))
				{
					this.OncatIDChanging(value);
					this.SendPropertyChanging();
					this._catID = value;
					this.SendPropertyChanged("catID");
					this.OncatIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_itemName", DbType="VarChar(50)")]
		public string itemName
		{
			get
			{
				return this._itemName;
			}
			set
			{
				if ((this._itemName != value))
				{
					this.OnitemNameChanging(value);
					this.SendPropertyChanging();
					this._itemName = value;
					this.SendPropertyChanged("itemName");
					this.OnitemNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_catImg", DbType="VarChar(100)")]
		public string catImg
		{
			get
			{
				return this._catImg;
			}
			set
			{
				if ((this._catImg != value))
				{
					this.OncatImgChanging(value);
					this.SendPropertyChanging();
					this._catImg = value;
					this.SendPropertyChanged("catImg");
					this.OncatImgChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_hotdishes")]
	public partial class tb_hotdishe : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _name;
		
		private string _img;
		
		private decimal _price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnimgChanging(string value);
    partial void OnimgChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    #endregion
		
		public tb_hotdishe()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_img", DbType="VarChar(MAX)")]
		public string img
		{
			get
			{
				return this._img;
			}
			set
			{
				if ((this._img != value))
				{
					this.OnimgChanging(value);
					this.SendPropertyChanging();
					this._img = value;
					this.SendPropertyChanged("img");
					this.OnimgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(16,2) NOT NULL")]
		public decimal price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_users")]
	public partial class tb_user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _uid;
		
		private string _uname;
		
		private string _umobile;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuidChanging(int value);
    partial void OnuidChanged();
    partial void OnunameChanging(string value);
    partial void OnunameChanged();
    partial void OnumobileChanging(string value);
    partial void OnumobileChanged();
    #endregion
		
		public tb_user()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				if ((this._uid != value))
				{
					this.OnuidChanging(value);
					this.SendPropertyChanging();
					this._uid = value;
					this.SendPropertyChanged("uid");
					this.OnuidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string uname
		{
			get
			{
				return this._uname;
			}
			set
			{
				if ((this._uname != value))
				{
					this.OnunameChanging(value);
					this.SendPropertyChanging();
					this._uname = value;
					this.SendPropertyChanged("uname");
					this.OnunameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_umobile", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string umobile
		{
			get
			{
				return this._umobile;
			}
			set
			{
				if ((this._umobile != value))
				{
					this.OnumobileChanging(value);
					this.SendPropertyChanging();
					this._umobile = value;
					this.SendPropertyChanged("umobile");
					this.OnumobileChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
