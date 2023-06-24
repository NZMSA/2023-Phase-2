# 2023-Phase-2-Backend
<h3>Getting Started Tips</h2>
https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-7.0&tabs=visual-studio 

<h3>Creating POCO classes</h2>
  <i>POCO's (Plain Old CLR Object) are simply C# classes that represent data structures/</i>
  <p>
    Create a new folder called Models. This folder will represent all the POCO's. 
    
    TodoItem.cs will represent one Todo item/Task
    TodoList.cs will represent a collection of items/tasks
    Notice these classes are just plain C# classes.
  </p>


<h3>Connecting it to a DB</h3>
The connection strings to the database is stored in appsettings.json

<h4>Using an inmemory database</h4>
  For testing using an inmemory database can be used. An example of this can be seen in the main branch in Program.cs
  Remember to install the Nuget packages: `Microsoft.EntityFrameworkCore.InMemory`
  
<h4>Using SQL Database with Docker</h4>
  For an example on how to connect to an SQL database have a look in the feature/mysql branch in Program.cs. 
  Notice it is very similar to using an inmemory database. 
  Remember to install the Nuget packages: `Microsoft.EntityFrameworkCore.SqlServer`

  To setup SQL server Docker container. 
  https://hevodata.com/learn/sql-server-docker/ 

  Incase you get an EULA error https://stackoverflow.com/questions/64319491/sql-server-2019-in-docker-you-can-accept-the-eula-by-specifying-the-accept-eu

  Incase you get certificate error in the .NET application with the connection string. https://learn.microsoft.com/en-us/troubleshoot/sql/database-engine/connect/certificate-chain-not-trusted?tabs=ole-db-driver-19
