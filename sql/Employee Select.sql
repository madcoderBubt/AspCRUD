/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [EmployeeID]
      ,[Name]
      ,[Position]
      ,[Office]
      ,[Age]
      ,[Salary]
  FROM [OfficeDB].[dbo].[Employee]