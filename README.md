# Product Inventory System
#Due to technical problems including version errors the project link is different from initial submition.
#Enabling use of Cors function in APS .NET COre 5 API StartUp could not allow communication between our API and Angualr scripts as a results we had to change and could not finish certain things in time


#Working Use cases
1. Add new Product
2. Sell Product
# Frameworks - Libraries

1. ASP.NET CORE API (version 5)
2. Repository Pattern
4. Automapper
6.Angualar 12 (Front End)

# Running Project

- Open the project with Visual Studio 2019
- in `appsettings.json`file change the connection string according to your system.
  ```
    "ConnectionStrings": {
    "CotConnection": "Server=(localdb)\\mssqllocaldb;Database=InvetoryData;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  ```
- In package manager console run the following commands 
    ```
	-Add-Migration InitialCreate or use any name you like
	-Update-database 
   ```
- Run the project start adding cot reports

#  Due to time constraint Front end of this project is not completed fully,however everyday I try to add up new work
