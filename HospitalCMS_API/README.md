# Patient Web REST API

## Description

This is a project to practice how to build Web APIs using the latest release of .NET 7.0 (which is the same .NET Core but with another name).

## Technologies

- [.NET 7](https://dotnet.microsoft.com/en-us/learn/aspnet/what-is-aspnet-core) - A cross-platform framework to build Web application
- [Entity Framework Core](https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application) - is a library that takes Schemas and generate SQL Tables
- [Swagger API](https://swagger.io/tools/swagger-ui/) - is a tool that can test different API Requests. Similar to Postman 

## Architecture

### Model View Controller

- Model
	- is a list of objects that organize the information for each **entity**. 
	
	- **Entity** in C#, is a model representation of the field values it encloses inside the class name. 
	It starts with the **access modifier** (which level of visibility the class has in relation to other classes), 
	and the standard level is **public**.
	
	- **Annotation** is a data type that C# uses to check if the right value is getting stored. 
	- **Primary Key** is a special value type that C# uses by passing a **Key** annotation that allows it to auto increment.

- View
	- is a list of pages that can receive dynamic data from the controller or other web pages. It has the extension
	of **.cshtml** and it uses a **@** page directive to read variables. Similar to **{** in React library 

	- **Razor Pages** is a special kind of html pages that are compatible with C# syntax. Most of the time, it makes the view
	interactive,, by passing data information from the models, and having conditional statements (if, else if, else statements).
	
	- **Partial Views** or the layout that wraps the web pages (includes the header and footer mostly).

	Note: Scaffolding is a tech word that means generating a new Razor page.

- Controller
	- is the code that validates **input data** (information it receives from swagger ui), and the business logic to perform **CRUD** operations.
	
	- **Route** is a data annotation that tell where the request should be send to. This must be included on the **top** of the page in order to 
	avoid errors. Example: [Route("api/v1/collections/collection")]
	
	- **Actions** is a controller action that needs to be included underneath the route. Example: [ApiController] 

	Note: Once the API is running, a Swagger UI page will show with controller's endpoints






