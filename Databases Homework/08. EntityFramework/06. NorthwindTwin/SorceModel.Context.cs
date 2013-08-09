﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _06.NorthwindTwin
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class NorthwindEntitiesClone : DbContext
    {
        public NorthwindEntitiesClone()
            : base("name=NorthwindEntitiesClone")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order_Detail> Order_Details { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Territory> Territories { get; set; }
        public DbSet<Alphabetical_list_of_product> Alphabetical_list_of_products { get; set; }
        public DbSet<Category_Sales_for_1997> Category_Sales_for_1997 { get; set; }
        public DbSet<Current_Product_List> Current_Product_Lists { get; set; }
        public DbSet<Customer_and_Suppliers_by_City> Customer_and_Suppliers_by_Cities { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Order_Details_Extended> Order_Details_Extendeds { get; set; }
        public DbSet<Order_Subtotal> Order_Subtotals { get; set; }
        public DbSet<Orders_Qry> Orders_Qries { get; set; }
        public DbSet<Product_Sales_for_1997> Product_Sales_for_1997 { get; set; }
        public DbSet<Products_Above_Average_Price> Products_Above_Average_Prices { get; set; }
        public DbSet<Products_by_Category> Products_by_Categories { get; set; }
        public DbSet<Sales_by_Category> Sales_by_Categories { get; set; }
        public DbSet<Sales_Totals_by_Amount> Sales_Totals_by_Amounts { get; set; }
        public DbSet<Summary_of_Sales_by_Quarter> Summary_of_Sales_by_Quarters { get; set; }
        public DbSet<Summary_of_Sales_by_Year> Summary_of_Sales_by_Years { get; set; }
    
        [EdmFunction("NorthwindEntitiesClone", "ProductsUnderThisUnitPrice")]
        public virtual IQueryable<ProductsUnderThisUnitPrice_Result> ProductsUnderThisUnitPrice(Nullable<decimal> price)
        {
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ProductsUnderThisUnitPrice_Result>("[NorthwindEntitiesClone].[ProductsUnderThisUnitPrice](@price)", priceParameter);
        }
    
        public virtual ObjectResult<Customers_By_City_Result> Customers_By_City(string param1)
        {
            var param1Parameter = param1 != null ?
                new ObjectParameter("param1", param1) :
                new ObjectParameter("param1", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customers_By_City_Result>("Customers_By_City", param1Parameter);
        }
    
        public virtual int Customers_Count_By_Region(string param1)
        {
            var param1Parameter = param1 != null ?
                new ObjectParameter("param1", param1) :
                new ObjectParameter("param1", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Customers_Count_By_Region", param1Parameter);
        }
    
        public virtual ObjectResult<CustOrderHist_Result> CustOrderHist(string customerID)
        {
            var customerIDParameter = customerID != null ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustOrderHist_Result>("CustOrderHist", customerIDParameter);
        }
    
        public virtual ObjectResult<CustOrdersDetail_Result> CustOrdersDetail(Nullable<int> orderID)
        {
            var orderIDParameter = orderID.HasValue ?
                new ObjectParameter("OrderID", orderID) :
                new ObjectParameter("OrderID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustOrdersDetail_Result>("CustOrdersDetail", orderIDParameter);
        }
    
        public virtual ObjectResult<CustOrdersOrders_Result> CustOrdersOrders(string customerID)
        {
            var customerIDParameter = customerID != null ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustOrdersOrders_Result>("CustOrdersOrders", customerIDParameter);
        }
    
        public virtual int CustOrderTotal(string customerID, ObjectParameter totalSales)
        {
            var customerIDParameter = customerID != null ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CustOrderTotal", customerIDParameter, totalSales);
        }
    
        public virtual ObjectResult<Employee_Sales_by_Country_Result> Employee_Sales_by_Country(Nullable<System.DateTime> beginning_Date, Nullable<System.DateTime> ending_Date)
        {
            var beginning_DateParameter = beginning_Date.HasValue ?
                new ObjectParameter("Beginning_Date", beginning_Date) :
                new ObjectParameter("Beginning_Date", typeof(System.DateTime));
    
            var ending_DateParameter = ending_Date.HasValue ?
                new ObjectParameter("Ending_Date", ending_Date) :
                new ObjectParameter("Ending_Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee_Sales_by_Country_Result>("Employee_Sales_by_Country", beginning_DateParameter, ending_DateParameter);
        }
    
        public virtual ObjectResult<Get_Customer_And_Orders_Result> Get_Customer_And_Orders(string customerID)
        {
            var customerIDParameter = customerID != null ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Customer_And_Orders_Result>("Get_Customer_And_Orders", customerIDParameter);
        }
    
        public virtual ObjectResult<Sales_by_Year_Result> Sales_by_Year(Nullable<System.DateTime> beginning_Date, Nullable<System.DateTime> ending_Date)
        {
            var beginning_DateParameter = beginning_Date.HasValue ?
                new ObjectParameter("Beginning_Date", beginning_Date) :
                new ObjectParameter("Beginning_Date", typeof(System.DateTime));
    
            var ending_DateParameter = ending_Date.HasValue ?
                new ObjectParameter("Ending_Date", ending_Date) :
                new ObjectParameter("Ending_Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sales_by_Year_Result>("Sales_by_Year", beginning_DateParameter, ending_DateParameter);
        }
    
        public virtual ObjectResult<SalesByCategory_Result> SalesByCategory(string categoryName, string ordYear)
        {
            var categoryNameParameter = categoryName != null ?
                new ObjectParameter("CategoryName", categoryName) :
                new ObjectParameter("CategoryName", typeof(string));
    
            var ordYearParameter = ordYear != null ?
                new ObjectParameter("OrdYear", ordYear) :
                new ObjectParameter("OrdYear", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SalesByCategory_Result>("SalesByCategory", categoryNameParameter, ordYearParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<Ten_Most_Expensive_Products_Result> Ten_Most_Expensive_Products()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ten_Most_Expensive_Products_Result>("Ten_Most_Expensive_Products");
        }
    
        public virtual ObjectResult<Whole_Or_Partial_Customers_Set_Result> Whole_Or_Partial_Customers_Set(Nullable<int> param1)
        {
            var param1Parameter = param1.HasValue ?
                new ObjectParameter("param1", param1) :
                new ObjectParameter("param1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Whole_Or_Partial_Customers_Set_Result>("Whole_Or_Partial_Customers_Set", param1Parameter);
        }
    }
}
