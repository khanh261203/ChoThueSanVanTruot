﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChoThueSanVanTruot.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ChoThueSanVanTruot")]
	public partial class ChoThueSanVanTruotDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSanVanTruot(SanVanTruot instance);
    partial void UpdateSanVanTruot(SanVanTruot instance);
    partial void DeleteSanVanTruot(SanVanTruot instance);
    partial void InsertBooking(Booking instance);
    partial void UpdateBooking(Booking instance);
    partial void DeleteBooking(Booking instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public ChoThueSanVanTruotDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ChoThueSanVanTruotConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ChoThueSanVanTruotDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ChoThueSanVanTruotDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ChoThueSanVanTruotDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ChoThueSanVanTruotDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SanVanTruot> SanVanTruots
		{
			get
			{
				return this.GetTable<SanVanTruot>();
			}
		}
		
		public System.Data.Linq.Table<Booking> Bookings
		{
			get
			{
				return this.GetTable<Booking>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanVanTruot")]
	public partial class SanVanTruot : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idsan;
		
		private string _tensan;
		
		private string _loaisan;
		
		private string _diachisan;
		
		private System.Nullable<int> _soluongtoida;
		
		private System.Nullable<double> _gia;
		
		private System.Nullable<System.DateTime> _ngaytao;
		
		private string _hinh;
		
		private string _trangthai;
		
		private EntitySet<Booking> _Bookings;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidsanChanging(int value);
    partial void OnidsanChanged();
    partial void OntensanChanging(string value);
    partial void OntensanChanged();
    partial void OnloaisanChanging(string value);
    partial void OnloaisanChanged();
    partial void OndiachisanChanging(string value);
    partial void OndiachisanChanged();
    partial void OnsoluongtoidaChanging(System.Nullable<int> value);
    partial void OnsoluongtoidaChanged();
    partial void OngiaChanging(System.Nullable<double> value);
    partial void OngiaChanged();
    partial void OnngaytaoChanging(System.Nullable<System.DateTime> value);
    partial void OnngaytaoChanged();
    partial void OnhinhChanging(string value);
    partial void OnhinhChanged();
    partial void OntrangthaiChanging(string value);
    partial void OntrangthaiChanged();
    #endregion
		
		public SanVanTruot()
		{
			this._Bookings = new EntitySet<Booking>(new Action<Booking>(this.attach_Bookings), new Action<Booking>(this.detach_Bookings));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idsan", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idsan
		{
			get
			{
				return this._idsan;
			}
			set
			{
				if ((this._idsan != value))
				{
					this.OnidsanChanging(value);
					this.SendPropertyChanging();
					this._idsan = value;
					this.SendPropertyChanged("idsan");
					this.OnidsanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tensan", DbType="NVarChar(50)")]
		public string tensan
		{
			get
			{
				return this._tensan;
			}
			set
			{
				if ((this._tensan != value))
				{
					this.OntensanChanging(value);
					this.SendPropertyChanging();
					this._tensan = value;
					this.SendPropertyChanged("tensan");
					this.OntensanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_loaisan", DbType="NVarChar(50)")]
		public string loaisan
		{
			get
			{
				return this._loaisan;
			}
			set
			{
				if ((this._loaisan != value))
				{
					this.OnloaisanChanging(value);
					this.SendPropertyChanging();
					this._loaisan = value;
					this.SendPropertyChanged("loaisan");
					this.OnloaisanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diachisan", DbType="NVarChar(50)")]
		public string diachisan
		{
			get
			{
				return this._diachisan;
			}
			set
			{
				if ((this._diachisan != value))
				{
					this.OndiachisanChanging(value);
					this.SendPropertyChanging();
					this._diachisan = value;
					this.SendPropertyChanged("diachisan");
					this.OndiachisanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soluongtoida", DbType="Int")]
		public System.Nullable<int> soluongtoida
		{
			get
			{
				return this._soluongtoida;
			}
			set
			{
				if ((this._soluongtoida != value))
				{
					this.OnsoluongtoidaChanging(value);
					this.SendPropertyChanging();
					this._soluongtoida = value;
					this.SendPropertyChanged("soluongtoida");
					this.OnsoluongtoidaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gia", DbType="Float")]
		public System.Nullable<double> gia
		{
			get
			{
				return this._gia;
			}
			set
			{
				if ((this._gia != value))
				{
					this.OngiaChanging(value);
					this.SendPropertyChanging();
					this._gia = value;
					this.SendPropertyChanged("gia");
					this.OngiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaytao", DbType="Date")]
		public System.Nullable<System.DateTime> ngaytao
		{
			get
			{
				return this._ngaytao;
			}
			set
			{
				if ((this._ngaytao != value))
				{
					this.OnngaytaoChanging(value);
					this.SendPropertyChanging();
					this._ngaytao = value;
					this.SendPropertyChanged("ngaytao");
					this.OnngaytaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hinh", DbType="NVarChar(50)")]
		public string hinh
		{
			get
			{
				return this._hinh;
			}
			set
			{
				if ((this._hinh != value))
				{
					this.OnhinhChanging(value);
					this.SendPropertyChanging();
					this._hinh = value;
					this.SendPropertyChanged("hinh");
					this.OnhinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_trangthai", DbType="NVarChar(50)")]
		public string trangthai
		{
			get
			{
				return this._trangthai;
			}
			set
			{
				if ((this._trangthai != value))
				{
					this.OntrangthaiChanging(value);
					this.SendPropertyChanging();
					this._trangthai = value;
					this.SendPropertyChanged("trangthai");
					this.OntrangthaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanVanTruot_Booking", Storage="_Bookings", ThisKey="idsan", OtherKey="idsan")]
		public EntitySet<Booking> Bookings
		{
			get
			{
				return this._Bookings;
			}
			set
			{
				this._Bookings.Assign(value);
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
		
		private void attach_Bookings(Booking entity)
		{
			this.SendPropertyChanging();
			entity.SanVanTruot = this;
		}
		
		private void detach_Bookings(Booking entity)
		{
			this.SendPropertyChanging();
			entity.SanVanTruot = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Booking")]
	public partial class Booking : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idbooking;
		
		private System.Nullable<int> _idsan;
		
		private System.Nullable<System.DateTime> _ngaybook;
		
		private System.Nullable<System.DateTime> _ngaychoi;
		
		private System.Nullable<int> _soluong;
		
		private System.Nullable<double> _thanhtien;
		
		private EntityRef<SanVanTruot> _SanVanTruot;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidbookingChanging(int value);
    partial void OnidbookingChanged();
    partial void OnidsanChanging(System.Nullable<int> value);
    partial void OnidsanChanged();
    partial void OnngaybookChanging(System.Nullable<System.DateTime> value);
    partial void OnngaybookChanged();
    partial void OnngaychoiChanging(System.Nullable<System.DateTime> value);
    partial void OnngaychoiChanged();
    partial void OnsoluongChanging(System.Nullable<int> value);
    partial void OnsoluongChanged();
    partial void OnthanhtienChanging(System.Nullable<double> value);
    partial void OnthanhtienChanged();
    #endregion
		
		public Booking()
		{
			this._SanVanTruot = default(EntityRef<SanVanTruot>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idbooking", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int idbooking
		{
			get
			{
				return this._idbooking;
			}
			set
			{
				if ((this._idbooking != value))
				{
					this.OnidbookingChanging(value);
					this.SendPropertyChanging();
					this._idbooking = value;
					this.SendPropertyChanged("idbooking");
					this.OnidbookingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idsan", DbType="Int")]
		public System.Nullable<int> idsan
		{
			get
			{
				return this._idsan;
			}
			set
			{
				if ((this._idsan != value))
				{
					if (this._SanVanTruot.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidsanChanging(value);
					this.SendPropertyChanging();
					this._idsan = value;
					this.SendPropertyChanged("idsan");
					this.OnidsanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaybook", DbType="Date")]
		public System.Nullable<System.DateTime> ngaybook
		{
			get
			{
				return this._ngaybook;
			}
			set
			{
				if ((this._ngaybook != value))
				{
					this.OnngaybookChanging(value);
					this.SendPropertyChanging();
					this._ngaybook = value;
					this.SendPropertyChanged("ngaybook");
					this.OnngaybookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ngaychoi", DbType="Date")]
		public System.Nullable<System.DateTime> ngaychoi
		{
			get
			{
				return this._ngaychoi;
			}
			set
			{
				if ((this._ngaychoi != value))
				{
					this.OnngaychoiChanging(value);
					this.SendPropertyChanging();
					this._ngaychoi = value;
					this.SendPropertyChanged("ngaychoi");
					this.OnngaychoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_soluong", DbType="Int")]
		public System.Nullable<int> soluong
		{
			get
			{
				return this._soluong;
			}
			set
			{
				if ((this._soluong != value))
				{
					this.OnsoluongChanging(value);
					this.SendPropertyChanging();
					this._soluong = value;
					this.SendPropertyChanged("soluong");
					this.OnsoluongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_thanhtien", DbType="Float")]
		public System.Nullable<double> thanhtien
		{
			get
			{
				return this._thanhtien;
			}
			set
			{
				if ((this._thanhtien != value))
				{
					this.OnthanhtienChanging(value);
					this.SendPropertyChanging();
					this._thanhtien = value;
					this.SendPropertyChanged("thanhtien");
					this.OnthanhtienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanVanTruot_Booking", Storage="_SanVanTruot", ThisKey="idsan", OtherKey="idsan", IsForeignKey=true)]
		public SanVanTruot SanVanTruot
		{
			get
			{
				return this._SanVanTruot.Entity;
			}
			set
			{
				SanVanTruot previousValue = this._SanVanTruot.Entity;
				if (((previousValue != value) 
							|| (this._SanVanTruot.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SanVanTruot.Entity = null;
						previousValue.Bookings.Remove(this);
					}
					this._SanVanTruot.Entity = value;
					if ((value != null))
					{
						value.Bookings.Add(this);
						this._idsan = value.idsan;
					}
					else
					{
						this._idsan = default(Nullable<int>);
					}
					this.SendPropertyChanged("SanVanTruot");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _iduser;
		
		private string _email;
		
		private string _diachi;
		
		private System.Nullable<int> _sdt;
		
		private string _matkhau;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OniduserChanging(int value);
    partial void OniduserChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OndiachiChanging(string value);
    partial void OndiachiChanged();
    partial void OnsdtChanging(System.Nullable<int> value);
    partial void OnsdtChanged();
    partial void OnmatkhauChanging(string value);
    partial void OnmatkhauChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_iduser", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int iduser
		{
			get
			{
				return this._iduser;
			}
			set
			{
				if ((this._iduser != value))
				{
					this.OniduserChanging(value);
					this.SendPropertyChanging();
					this._iduser = value;
					this.SendPropertyChanged("iduser");
					this.OniduserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(50)")]
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
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_diachi", DbType="NVarChar(50)")]
		public string diachi
		{
			get
			{
				return this._diachi;
			}
			set
			{
				if ((this._diachi != value))
				{
					this.OndiachiChanging(value);
					this.SendPropertyChanging();
					this._diachi = value;
					this.SendPropertyChanged("diachi");
					this.OndiachiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdt", DbType="Int")]
		public System.Nullable<int> sdt
		{
			get
			{
				return this._sdt;
			}
			set
			{
				if ((this._sdt != value))
				{
					this.OnsdtChanging(value);
					this.SendPropertyChanging();
					this._sdt = value;
					this.SendPropertyChanged("sdt");
					this.OnsdtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matkhau", DbType="NVarChar(50)")]
		public string matkhau
		{
			get
			{
				return this._matkhau;
			}
			set
			{
				if ((this._matkhau != value))
				{
					this.OnmatkhauChanging(value);
					this.SendPropertyChanging();
					this._matkhau = value;
					this.SendPropertyChanged("matkhau");
					this.OnmatkhauChanged();
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
