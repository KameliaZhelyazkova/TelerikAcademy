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
using _02.PleaseNorhtwindWork;

namespace _02.PleaseNorhtwindWork	
{
	public partial class Region
	{
		private int _regionID;
		public virtual int RegionID
		{
			get
			{
				return this._regionID;
			}
			set
			{
				this._regionID = value;
			}
		}
		
		private string _regionDescription;
		public virtual string RegionDescription
		{
			get
			{
				return this._regionDescription;
			}
			set
			{
				this._regionDescription = value;
			}
		}
		
		private IList<Territory> _territories = new List<Territory>();
		public virtual IList<Territory> Territories
		{
			get
			{
				return this._territories;
			}
		}
		
	}
}
#pragma warning restore 1591
