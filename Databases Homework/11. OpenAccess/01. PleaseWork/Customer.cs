#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using _01.PleaseWork;

namespace _01.PleaseWork	
{
	public partial class Customer
	{
		private int _customerID;
		public virtual int CustomerID
		{
			get
			{
				return this._customerID;
			}
			set
			{
				this._customerID = value;
			}
		}
		
		private string _drvLicNumber;
		public virtual string DrvLicNumber
		{
			get
			{
				return this._drvLicNumber;
			}
			set
			{
				this._drvLicNumber = value;
			}
		}
		
		private string _fullName;
		public virtual string FullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				this._fullName = value;
			}
		}
		
		private string _address;
		public virtual string Address
		{
			get
			{
				return this._address;
			}
			set
			{
				this._address = value;
			}
		}
		
		private string _country;
		public virtual string Country
		{
			get
			{
				return this._country;
			}
			set
			{
				this._country = value;
			}
		}
		
		private string _city;
		public virtual string City
		{
			get
			{
				return this._city;
			}
			set
			{
				this._city = value;
			}
		}
		
		private string _state;
		public virtual string State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		
		private string _zIPCode;
		public virtual string ZIPCode
		{
			get
			{
				return this._zIPCode;
			}
			set
			{
				this._zIPCode = value;
			}
		}
		
		private IList<RentalOrder> _rentalOrders = new List<RentalOrder>();
		public virtual IList<RentalOrder> RentalOrders
		{
			get
			{
				return this._rentalOrders;
			}
		}
		
	}
}
#pragma warning restore 1591
