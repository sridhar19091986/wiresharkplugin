﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FollowSccpStream
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


    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = "sz04a_mc_all")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();

        //#region 可扩展性方法定义
        //partial void OnCreated();
        
        //partial void OnCreated()
        //{
        //    //Put your desired timeout here.
        //    this.CommandTimeout = 0;

        //    //If you do not want to hard code it, then take it 
        //    //from Application Settings / AppSettings
        //    //this.CommandTimeout = Settings.Default.CommandTimeout;
        //}
            
        //#endregion

        #region 可扩展性方法定义
        partial void OnCreated();
        #endregion
		
		public DataClasses1DataContext() : 
				base(global::FollowSccpStream.Properties.Settings.Default.mc_sz04aConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<LA_update> LA_update
		{
			get
			{
				return this.GetTable<LA_update>();
			}
		}
		
		public System.Data.Linq.Table<LA_update1> LA_update1
		{
			get
			{
				return this.GetTable<LA_update1>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LA_update")]
	public partial class LA_update
	{
		
		private System.Nullable<int> _FileNum;
		
		private System.Nullable<int> _PacketNum;
		
		private System.Nullable<int> _BeginFrameNum;
		
		private System.Nullable<System.DateTime> _PacketTime;
		
		private System.Nullable<int> _PacketTime_ms_;
		
		private string _DumpFor;
		
		private System.Nullable<int> _ip_version;
		
		private string _ip_version_MsgType;
		
		private string _sccp_slr;
		
		private string _sccp_dlr;
		
		private string _ip_src;
		
		private string _ip_dst;
		
		private string _imsi;
		
		private string _tmsi;
		
		private string _m3ua_opc;
		
		private string _m3ua_dpc;
		
		public LA_update()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileNum", DbType="Int")]
		public System.Nullable<int> FileNum
		{
			get
			{
				return this._FileNum;
			}
			set
			{
				if ((this._FileNum != value))
				{
					this._FileNum = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PacketNum", DbType="Int")]
		public System.Nullable<int> PacketNum
		{
			get
			{
				return this._PacketNum;
			}
			set
			{
				if ((this._PacketNum != value))
				{
					this._PacketNum = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BeginFrameNum", DbType="Int")]
		public System.Nullable<int> BeginFrameNum
		{
			get
			{
				return this._BeginFrameNum;
			}
			set
			{
				if ((this._BeginFrameNum != value))
				{
					this._BeginFrameNum = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PacketTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> PacketTime
		{
			get
			{
				return this._PacketTime;
			}
			set
			{
				if ((this._PacketTime != value))
				{
					this._PacketTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[PacketTime(ms)]", Storage="_PacketTime_ms_", DbType="Int")]
		public System.Nullable<int> PacketTime_ms_
		{
			get
			{
				return this._PacketTime_ms_;
			}
			set
			{
				if ((this._PacketTime_ms_ != value))
				{
					this._PacketTime_ms_ = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DumpFor", DbType="NVarChar(30)")]
		public string DumpFor
		{
			get
			{
				return this._DumpFor;
			}
			set
			{
				if ((this._DumpFor != value))
				{
					this._DumpFor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ip_version", DbType="Int")]
		public System.Nullable<int> ip_version
		{
			get
			{
				return this._ip_version;
			}
			set
			{
				if ((this._ip_version != value))
				{
					this._ip_version = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ip_version_MsgType", DbType="NVarChar(200)")]
		public string ip_version_MsgType
		{
			get
			{
				return this._ip_version_MsgType;
			}
			set
			{
				if ((this._ip_version_MsgType != value))
				{
					this._ip_version_MsgType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sccp_slr", DbType="NVarChar(200)")]
		public string sccp_slr
		{
			get
			{
				return this._sccp_slr;
			}
			set
			{
				if ((this._sccp_slr != value))
				{
					this._sccp_slr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sccp_dlr", DbType="NVarChar(200)")]
		public string sccp_dlr
		{
			get
			{
				return this._sccp_dlr;
			}
			set
			{
				if ((this._sccp_dlr != value))
				{
					this._sccp_dlr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ip_src", DbType="NVarChar(200)")]
		public string ip_src
		{
			get
			{
				return this._ip_src;
			}
			set
			{
				if ((this._ip_src != value))
				{
					this._ip_src = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ip_dst", DbType="NVarChar(200)")]
		public string ip_dst
		{
			get
			{
				return this._ip_dst;
			}
			set
			{
				if ((this._ip_dst != value))
				{
					this._ip_dst = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imsi", DbType="NVarChar(200)")]
		public string imsi
		{
			get
			{
				return this._imsi;
			}
			set
			{
				if ((this._imsi != value))
				{
					this._imsi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tmsi", DbType="NVarChar(200)")]
		public string tmsi
		{
			get
			{
				return this._tmsi;
			}
			set
			{
				if ((this._tmsi != value))
				{
					this._tmsi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_m3ua_opc", DbType="NVarChar(200)")]
		public string m3ua_opc
		{
			get
			{
				return this._m3ua_opc;
			}
			set
			{
				if ((this._m3ua_opc != value))
				{
					this._m3ua_opc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_m3ua_dpc", DbType="NVarChar(200)")]
		public string m3ua_dpc
		{
			get
			{
				return this._m3ua_dpc;
			}
			set
			{
				if ((this._m3ua_dpc != value))
				{
					this._m3ua_dpc = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LA_update1")]
	public partial class LA_update1
	{
		
		private System.Nullable<int> _FileNum;
		
		private System.Nullable<int> _PacketNum;
		
		private System.Nullable<int> _BeginFrameNum;
		
		private System.Nullable<System.DateTime> _PacketTime;
		
		private System.Nullable<int> _PacketTime_ms_;
		
		private string _DumpFor;
		
		private System.Nullable<int> _ip_version;
		
		private string _ip_version_MsgType;
		
		private string _sccp_slr;
		
		private string _sccp_dlr;
		
		private string _ip_src;
		
		private string _ip_dst;
		
		private string _imsi;
		
		private string _tmsi;
		
		private string _m3ua_opc;
		
		private string _m3ua_dpc;
		
		private string _opcdpcsccp;
		
		public LA_update1()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileNum", DbType="Int")]
		public System.Nullable<int> FileNum
		{
			get
			{
				return this._FileNum;
			}
			set
			{
				if ((this._FileNum != value))
				{
					this._FileNum = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PacketNum", DbType="Int")]
		public System.Nullable<int> PacketNum
		{
			get
			{
				return this._PacketNum;
			}
			set
			{
				if ((this._PacketNum != value))
				{
					this._PacketNum = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BeginFrameNum", DbType="Int")]
		public System.Nullable<int> BeginFrameNum
		{
			get
			{
				return this._BeginFrameNum;
			}
			set
			{
				if ((this._BeginFrameNum != value))
				{
					this._BeginFrameNum = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PacketTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> PacketTime
		{
			get
			{
				return this._PacketTime;
			}
			set
			{
				if ((this._PacketTime != value))
				{
					this._PacketTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[PacketTime(ms)]", Storage="_PacketTime_ms_", DbType="Int")]
		public System.Nullable<int> PacketTime_ms_
		{
			get
			{
				return this._PacketTime_ms_;
			}
			set
			{
				if ((this._PacketTime_ms_ != value))
				{
					this._PacketTime_ms_ = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DumpFor", DbType="NVarChar(30)")]
		public string DumpFor
		{
			get
			{
				return this._DumpFor;
			}
			set
			{
				if ((this._DumpFor != value))
				{
					this._DumpFor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ip_version", DbType="Int")]
		public System.Nullable<int> ip_version
		{
			get
			{
				return this._ip_version;
			}
			set
			{
				if ((this._ip_version != value))
				{
					this._ip_version = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ip_version_MsgType", DbType="NVarChar(200)")]
		public string ip_version_MsgType
		{
			get
			{
				return this._ip_version_MsgType;
			}
			set
			{
				if ((this._ip_version_MsgType != value))
				{
					this._ip_version_MsgType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sccp_slr", DbType="NVarChar(200)")]
		public string sccp_slr
		{
			get
			{
				return this._sccp_slr;
			}
			set
			{
				if ((this._sccp_slr != value))
				{
					this._sccp_slr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sccp_dlr", DbType="NVarChar(200)")]
		public string sccp_dlr
		{
			get
			{
				return this._sccp_dlr;
			}
			set
			{
				if ((this._sccp_dlr != value))
				{
					this._sccp_dlr = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ip_src", DbType="NVarChar(200)")]
		public string ip_src
		{
			get
			{
				return this._ip_src;
			}
			set
			{
				if ((this._ip_src != value))
				{
					this._ip_src = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ip_dst", DbType="NVarChar(200)")]
		public string ip_dst
		{
			get
			{
				return this._ip_dst;
			}
			set
			{
				if ((this._ip_dst != value))
				{
					this._ip_dst = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_imsi", DbType="NVarChar(200)")]
		public string imsi
		{
			get
			{
				return this._imsi;
			}
			set
			{
				if ((this._imsi != value))
				{
					this._imsi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tmsi", DbType="NVarChar(200)")]
		public string tmsi
		{
			get
			{
				return this._tmsi;
			}
			set
			{
				if ((this._tmsi != value))
				{
					this._tmsi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_m3ua_opc", DbType="NVarChar(200)")]
		public string m3ua_opc
		{
			get
			{
				return this._m3ua_opc;
			}
			set
			{
				if ((this._m3ua_opc != value))
				{
					this._m3ua_opc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_m3ua_dpc", DbType="NVarChar(200)")]
		public string m3ua_dpc
		{
			get
			{
				return this._m3ua_dpc;
			}
			set
			{
				if ((this._m3ua_dpc != value))
				{
					this._m3ua_dpc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_opcdpcsccp", CanBeNull=false)]
		public string opcdpcsccp
		{
			get
			{
				return this._opcdpcsccp;
			}
			set
			{
				if ((this._opcdpcsccp != value))
				{
					this._opcdpcsccp = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
