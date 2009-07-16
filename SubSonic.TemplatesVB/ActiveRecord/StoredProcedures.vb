


  
Imports System
Imports SubSonic
Imports SubSonic.Schema
Imports SubSonic.DataProviders
Imports System.Data

NameSpace WestWind

	Partial Public Class NorthwindDB

        Public Function CustOrderHist(CustomerID As String) As StoredProcedure
            Dim sp As New StoredProcedure("CustOrderHist",Me.Provider)
            sp.Command.AddParameter("CustomerID",CustomerID,DbType.String)
            Return sp
        End Function
        Public Function CustOrdersDetail(OrderID As Integer) As StoredProcedure
            Dim sp As New StoredProcedure("CustOrdersDetail",Me.Provider)
            sp.Command.AddParameter("OrderID",OrderID,DbType.Int32)
            Return sp
        End Function
        Public Function CustOrdersOrders(CustomerID As String) As StoredProcedure
            Dim sp As New StoredProcedure("CustOrdersOrders",Me.Provider)
            sp.Command.AddParameter("CustomerID",CustomerID,DbType.String)
            Return sp
        End Function
        Public Function EmployeeSalesbyCountry(Beginning_Date As Date,Ending_Date As Date) As StoredProcedure
            Dim sp As New StoredProcedure("Employee Sales by Country",Me.Provider)
            sp.Command.AddParameter("Beginning_Date",Beginning_Date,DbType.DateTime)
            sp.Command.AddParameter("Ending_Date",Ending_Date,DbType.DateTime)
            Return sp
        End Function
        Public Function SalesbyYear(Beginning_Date As Date,Ending_Date As Date) As StoredProcedure
            Dim sp As New StoredProcedure("Sales by Year",Me.Provider)
            sp.Command.AddParameter("Beginning_Date",Beginning_Date,DbType.DateTime)
            sp.Command.AddParameter("Ending_Date",Ending_Date,DbType.DateTime)
            Return sp
        End Function
        Public Function SalesByCategory(CategoryName As String,OrdYear As String) As StoredProcedure
            Dim sp As New StoredProcedure("SalesByCategory",Me.Provider)
            sp.Command.AddParameter("CategoryName",CategoryName,DbType.String)
            sp.Command.AddParameter("OrdYear",OrdYear,DbType.String)
            Return sp
        End Function
        Public Function TenMostExpensiveProducts() As StoredProcedure
            Dim sp As New StoredProcedure("Ten Most Expensive Products",Me.Provider)
            Return sp
        End Function
	
	End Class
	
End NameSpace
 