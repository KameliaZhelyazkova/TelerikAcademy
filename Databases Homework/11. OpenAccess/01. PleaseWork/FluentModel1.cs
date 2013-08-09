#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ContextGenerator.ttinclude code generation file.
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
	public partial class CarRental : OpenAccessContext, ICarRentalUnitOfWork
	{
		private static string connectionStringName = @"Connection";
			
		private static BackendConfiguration backend = GetBackendConfiguration();
				
		private static MetadataSource metadataSource = new CarRentalMetadataSource();
		
		public CarRental()
			:base(connectionStringName, backend, metadataSource)
		{ }
		
		public CarRental(string connection)
			:base(connection, backend, metadataSource)
		{ }
		
		public CarRental(BackendConfiguration backendConfiguration)
			:base(connectionStringName, backendConfiguration, metadataSource)
		{ }
			
		public CarRental(string connection, MetadataSource metadataSource)
			:base(connection, backend, metadataSource)
		{ }
		
		public CarRental(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
			:base(connection, backendConfiguration, metadataSource)
		{ }
			
		public IQueryable<RentalRate> RentalRates 
		{
			get
			{
				return this.GetAll<RentalRate>();
			}
		}
		
		public IQueryable<RentalOrder> RentalOrders 
		{
			get
			{
				return this.GetAll<RentalOrder>();
			}
		}
		
		public IQueryable<Employee> Employees 
		{
			get
			{
				return this.GetAll<Employee>();
			}
		}
		
		public IQueryable<Customer> Customers 
		{
			get
			{
				return this.GetAll<Customer>();
			}
		}
		
		public IQueryable<Category> Categories 
		{
			get
			{
				return this.GetAll<Category>();
			}
		}
		
		public IQueryable<Car> Cars 
		{
			get
			{
				return this.GetAll<Car>();
			}
		}
		
		public static BackendConfiguration GetBackendConfiguration()
		{
			BackendConfiguration backend = new BackendConfiguration();
			backend.Backend = "MsSql";
			backend.ProviderName = "System.Data.SqlClient";
			return backend;
		}
	}
	
	public interface ICarRentalUnitOfWork : IUnitOfWork
	{
		IQueryable<RentalRate> RentalRates
		{
			get;
		}
		IQueryable<RentalOrder> RentalOrders
		{
			get;
		}
		IQueryable<Employee> Employees
		{
			get;
		}
		IQueryable<Customer> Customers
		{
			get;
		}
		IQueryable<Category> Categories
		{
			get;
		}
		IQueryable<Car> Cars
		{
			get;
		}
	}
}
#pragma warning restore 1591
