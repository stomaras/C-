using Microsoft.AspNetCore.StaticFiles;
using FluentValidation.AspNetCore;
using System.Reflection;
using Serilog;
using CitiesInfo.API.Services;
using CitiesInfo.API;
using CitiesInfo.API.DbContexts;
using Microsoft.EntityFrameworkCore;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/cityinfo.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);
//builder.Logging.ClearProviders();
//builder.Logging.AddConsole();

builder.Host.UseSerilog();

// Add services to the container.
// is sufficient for build an api
// if consumer of an api asks for an xml representation 
// and we donn't support must return an appropriate message
// improves reliability of the system
// you can change the default formatter 
builder.Services.AddControllers().AddFluentValidation(options =>{
                    // Validate child properties and root collection elements
                    options.ImplicitlyValidateChildProperties = true;
                    options.ImplicitlyValidateRootCollectionElements = true;
                    // Automatic registration of validators in assembly
                    options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
                });

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson().AddXmlSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<FileExtensionContentTypeProvider>();
builder.Services.AddDbContext<CityInfoContext>
    (dbContextOptions => dbContextOptions.UseSqlite(
        builder.Configuration["ConnectionStrings:CityInfoDBConnectionString"]));
        
#if DEBUG
builder.Services.AddTransient<IMailService, LocalMailService>();
#else
builder.Services.AddTransient<IMailService, CloudMailService>();
#endif

builder.Services.AddSingleton<CitiesDataStore>();
builder.Services.AddDbContext<CityInfoContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.MapControllers();

app.Run();

/*
 * Review 
 * 
 * ---------------------------------------------------------------------------------
 * ---------------------------------------------------------------------------------
 * ------------------ Section 5 Working With Services And DI -----------------------
 * ---------------------------------------------------------------------------------
 * ---------------------------------------------------------------------------------
 * 
 * API's require a certain amount of logging ASP.NET Core has built-in services 
 * but we must injected into the class we need it.
 * Creating and using custom service
 * Creating and using Custom services
 * A logging provider is a service that stores or display logs 
 * Stores logs in a file or logs in a database.
 * In appsettings.json default level is information
 * 
 * Constructor Injection is the prefer way of requesting dependencies.
 * You can also request a service from the container directly 
 * 
 * For Logging Exceptions , logger methods provide an overload that take an exception
 * parameter, as it is an exception we are going to use the LogCritical method.
 * LogCritical passing through a message and an exception.
 * Unhandled exceptions will return 500 Internal Server Error.
 * In production environment we want to log in a peristant store 
 * like event log or a database or a file.
 * The built-in logger is fine but some people prefer third-party tools
 * 
 * Third-Party logging providers:
 * 
 * Serilog 
 * 
 * How we can differentitate the LocalMailService with CloudMailService 
 * one way of doing this is by using compiler directives , A compiler Directive 
 * tells a compiler to omit or include pieces of code on compile
 * if we are in debug build we are going to use LocalMailService on our container,
 * otherwise we are going to ass CloudMailService
 * 
 * We have LocalMailService propably used during development 
 * CloudMailServie that is something we wan tto use in environment 
 * which required a release build .
 * 
 * Static Instance of CityDataStore is nothing more than a singleton
 * Almost all applications needed reading configuration values .
 * ASP.NET Core work with a variety of application configuration data sources,
 * from JSON, XML, and In any files over in memory settings to command line arguments
 * or environment variables
 * The most common place to store settings is in json file 
 * appsettings.json
 * What we want to do is store the to and from addresses used by our mail services in this 
 * file
 * 
 * Different Environments might require different configuation files.
 * The to address in a production environment likely won;t be the same 
 * as the to address when developing 
 * 
 * Configuration Files can be scoped to a specific environment by providing 
 * different configuration sources for which part of the name is the name of the 
 * environment
 * 
 * We want to use different configuration values for a production environemtn 
 * 
 * first thing we must to do is to add an appsettings file for production environment
 * 
 * By working with environment-scoped configuration files and compiler directives 
 * for registration at container level , we get a really granular approach to all of 
 * this 
 * 
 * Custom Services are registered on the built-in container
 * - Transient lifetime services are created each time they are requested 
 *             this lifetime works best for lightweight, stateless services.
 * - Scoped lifetime services are created once per request 
 * - Singleton lifetime services are created the first time they are requested.
 * - Aftering injecting the services we can use Dependency Injection to Inject them 
 *   i nto the class 
 *   We also work with configuration files and IConfiguration Interface 
 *   we work with DDO Classes 
 *   
 *   ---------------------------------------------------------------------------------
 *   ---------------------------------------------------------------------------------
 *   ---------------Section 6 Getting Acquainted with Entity Framework Core-----------
 *   ---------------------------------------------------------------------------------
 *   ---------------------------------------------------------------------------------
 *   
 *   - Introducing Entity Framework Core 
 *   - Working with migrations 
 *   - Seeding the database
 *   - Safely storing sensitive data
 *   
 *   Entity Framework Core is an object relational mapping (ORM) is a technique that lets
 *   you query and manipulate data from a database using an object-oriented paradigm
 *   Relational Model and Object models does not work very good together.
 *   Entity Framework core supports a variety of databases, even non-relational ones
 *   DTOs the outer facing model are different from the entities
 *   Not all fields like computed fields are stored in database
 *   The data we want to offer throught an API is often shaped differently in how 
 *   it is stored in the underlying data store.
 *   
 *   On city we already defined a collection of point of interest, but we want to be 
 *   able to navigate through out object graph from a pointofInterest to the parent city
 *   as well
 *   
 *   In DTO's we can add annotation as Required for Name and MaxLength
 *   CityDto is only used to get data . not to store it.
 *   Navigation Properties are used only on entities
 *   
 *   A DbContext represents a session with the database that can be used to query 
 *   and save instances of your entities.
 *   
 *   dotnet add package microsoft.entityframeworkcore --version 6.0.0
 *   
 *   New Folder--> DBcONTEXTS
 *   
 *   Big Applications uses multiple contexts
 *   Multiple contexts can work in the same database.
 *   
 *   We use the null forgiving operator in DbContext null! , which is created for this 
 *   scenarion in mind 
 *   
 *   We add DbContext in program class
 *   
 *   with package microsoft.entityframewor.core.Tools
 *   
 *   In migration DOWN means from this version to the previous version
 *   
 *   As long as you are working on your local machine in a development environment 
 *   but when you are deploying to production , you are provided a connection string 
 *   to a database. Sometimes connection string contains username and pasword combinations 
 *   or the actual server name. Storing sensitive data in configuration files is a bad idea 
 *   We don't want to expose that kind of information.
 *   So we are going to get rid of hardcoded connection string 
 *   For production environment we use an production environemtn to store the data 
 *   
 *   An environment variable is a variable whose value is set outside of the program,
 *   
 *   if someone has access to our machine we have problems 
 *   A key vault as an Azure Key Vaulr is an better option.
 *   
 *   Object Relational Mapper is a technique that lets you query 
 *   and manipulate data from a database using an object-oriented paradigm
 *   
 *   Entity Framework Core is an object relational mapper
 *   
 *   Seperate entity model from the outer facing models (DTOS)
 *   Not all fields like computed fileds are stored in the database
 *   The data we want to offer through an API is often shaped differently 
 *   than how it's stored in the underlying data store.
 *   Use conventions or annotations for keys, required fields.
 *   
 *   The DbContext represents a session with the database and can be used 
 *   to query and save instance of entities.
 *   
 *   Migrations allow you to provide code to chnage the database from one version 
 *   to another.
 *   
 *   Seeding the database provide with data to start with.
 *   - HasData() method when configuring the model.
 *   - Use environment variables for safer storage of sensitive data.
 *   
 */
