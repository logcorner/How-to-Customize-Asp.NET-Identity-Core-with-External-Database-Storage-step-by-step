# How-to-Customize-Asp.NET-Identity-Core-with-External-Database-Storage-step-by-step
# ASP.NET Core Identity is designed to enable us to easily use a number of different storage providers for our ASP.NET applications. We can # use the supplied Identity providers that are included with the .NET Framework, or we can implement your own providers.

# There are two primary reasons for creating a custom Identity  provider.

# We need to store Identity information in a data source that is not supported by the Identity providers included with the .NET Framework, # such as a MysQL database, an Oracle database, or other data sources.
# We need to manage Identity information using a database schema that is different from the database schema used by the providers that ship # with the .NET Framework.

# A common example of this would be to use authentication data that already exists in a SQL Server database for a company or Web site.
# In this tutorial, we are going to implement and configure a custom Identity Provider using ASP.NET MVC Core and IndentityCore
