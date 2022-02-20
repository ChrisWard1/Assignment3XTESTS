mkdir [name of folder]
cd [name of folder]/
dotnet new webapp
(get out from name of folder) cd ..
dotnet new xunit -o deliverycart.Tests
dotnet sln add ./deliverycart/deliverycart.csproj
dotnet sln add ./deliverycart.Tests/deliverycart.Tests.csproj
dotnet add ./deliverycart.Tests/deliverycart.Tests.csproj reference ./deliverycart/deliverycart.csproj
//Create Models.cs under deliverycart
dotnet tool install --global dotnet-aspnet-codegenerator
cd (name of folder)deliverycart
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
(window)dotnet aspnet-codegenerator razorpage -m Order -dc deliverycart.Data.Assignment3XTestsContext -udl -outDir Pages/Orders --referenceScriptLibraries -sqlite
(mac)dotnet aspnet-codegenerator razorpage -m Order -dc deliverycart.Data.Assignment3XTestsContext -udl -outDir Pages/Orders --referenceScriptLibraries -sqlite
dotnet ef database update
dotnet run
//work on async method in dbContext and pages/Order/create
dotnet ef migrations add initial_migration
dotnet ef database update
dotnet run
cd ..