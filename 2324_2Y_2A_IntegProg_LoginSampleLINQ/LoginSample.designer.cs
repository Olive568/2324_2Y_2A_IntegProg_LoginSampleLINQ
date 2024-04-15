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

namespace _2324_2Y_2A_IntegProg_LoginSampleLINQ
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="2324_1A_LoginSample")]
	public partial class LoginSampleDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLoginUser(LoginUser instance);
    partial void UpdateLoginUser(LoginUser instance);
    partial void DeleteLoginUser(LoginUser instance);
    partial void InsertLog(Log instance);
    partial void UpdateLog(Log instance);
    partial void DeleteLog(Log instance);
    #endregion
		
		public LoginSampleDataContext() : 
				base(global::_2324_2Y_2A_IntegProg_LoginSampleLINQ.Properties.Settings.Default._2324_1A_LoginSampleConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public LoginSampleDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoginSampleDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoginSampleDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LoginSampleDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<LoginUser> LoginUsers
		{
			get
			{
				return this.GetTable<LoginUser>();
			}
		}
		
		public System.Data.Linq.Table<Log> Logs
		{
			get
			{
				return this.GetTable<Log>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoginUsers")]
	public partial class LoginUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _LoginID;
		
		private string _Password;
		
		private string _Name;
		
		private System.Nullable<System.DateTime> _LastLoginDate;
		
		private EntitySet<Log> _Logs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLoginIDChanging(string value);
    partial void OnLoginIDChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnLastLoginDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLastLoginDateChanged();
    #endregion
		
		public LoginUser()
		{
			this._Logs = new EntitySet<Log>(new Action<Log>(this.attach_Logs), new Action<Log>(this.detach_Logs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginID", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string LoginID
		{
			get
			{
				return this._LoginID;
			}
			set
			{
				if ((this._LoginID != value))
				{
					this.OnLoginIDChanging(value);
					this.SendPropertyChanging();
					this._LoginID = value;
					this.SendPropertyChanged("LoginID");
					this.OnLoginIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastLoginDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastLoginDate
		{
			get
			{
				return this._LastLoginDate;
			}
			set
			{
				if ((this._LastLoginDate != value))
				{
					this.OnLastLoginDateChanging(value);
					this.SendPropertyChanging();
					this._LastLoginDate = value;
					this.SendPropertyChanged("LastLoginDate");
					this.OnLastLoginDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginUser_Log", Storage="_Logs", ThisKey="LoginID", OtherKey="LoginID")]
		public EntitySet<Log> Logs
		{
			get
			{
				return this._Logs;
			}
			set
			{
				this._Logs.Assign(value);
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
		
		private void attach_Logs(Log entity)
		{
			this.SendPropertyChanging();
			entity.LoginUser = this;
		}
		
		private void detach_Logs(Log entity)
		{
			this.SendPropertyChanging();
			entity.LoginUser = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Logs")]
	public partial class Log : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LogID;
		
		private string _LoginID;
		
		private System.DateTime _TimeStamp;
		
		private EntityRef<LoginUser> _LoginUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLogIDChanging(int value);
    partial void OnLogIDChanged();
    partial void OnLoginIDChanging(string value);
    partial void OnLoginIDChanged();
    partial void OnTimeStampChanging(System.DateTime value);
    partial void OnTimeStampChanged();
    #endregion
		
		public Log()
		{
			this._LoginUser = default(EntityRef<LoginUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LogID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int LogID
		{
			get
			{
				return this._LogID;
			}
			set
			{
				if ((this._LogID != value))
				{
					this.OnLogIDChanging(value);
					this.SendPropertyChanging();
					this._LogID = value;
					this.SendPropertyChanged("LogID");
					this.OnLogIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginID", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string LoginID
		{
			get
			{
				return this._LoginID;
			}
			set
			{
				if ((this._LoginID != value))
				{
					if (this._LoginUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLoginIDChanging(value);
					this.SendPropertyChanging();
					this._LoginID = value;
					this.SendPropertyChanged("LoginID");
					this.OnLoginIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeStamp", DbType="DateTime NOT NULL")]
		public System.DateTime TimeStamp
		{
			get
			{
				return this._TimeStamp;
			}
			set
			{
				if ((this._TimeStamp != value))
				{
					this.OnTimeStampChanging(value);
					this.SendPropertyChanging();
					this._TimeStamp = value;
					this.SendPropertyChanged("TimeStamp");
					this.OnTimeStampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoginUser_Log", Storage="_LoginUser", ThisKey="LoginID", OtherKey="LoginID", IsForeignKey=true)]
		public LoginUser LoginUser
		{
			get
			{
				return this._LoginUser.Entity;
			}
			set
			{
				LoginUser previousValue = this._LoginUser.Entity;
				if (((previousValue != value) 
							|| (this._LoginUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoginUser.Entity = null;
						previousValue.Logs.Remove(this);
					}
					this._LoginUser.Entity = value;
					if ((value != null))
					{
						value.Logs.Add(this);
						this._LoginID = value.LoginID;
					}
					else
					{
						this._LoginID = default(string);
					}
					this.SendPropertyChanged("LoginUser");
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
