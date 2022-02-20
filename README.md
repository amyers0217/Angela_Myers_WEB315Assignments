# Angela_Myers_WEB315Assignments

//Historical Figures in Assassin's Creed Games
//Assignment 1
//2022-02-20

Razor WebApp: Historical Figures in Assassin's Creed Games

Steps Taken to Setup the Razor Page Web App
- First opened a new window in Visual Studio Code and opened a new terminal
- The following command was ran in the terminal: dotnet new webapp -o RazorPagesHistoricalFiguresAC
- The following command was ran in the terminal: code -r RazorPagesHistoricalFiguresAC
- These commands created the new Web App
- The following command was then ran in the terminal to trust the HTTPS development certificate: dontnet dev-certs https --trust (I selected yes in the dialog box to install the certificate
- The Web App created the pages and wwwroot folders as well as the appsettings.json, Program.cs and Startup.cs

- In the Index.cshtml file, I changed the Welcome title to Historical Figures in Assassin's Creed Games as well as added my name, student number and the current date and time.

Adding Data to the Model
- In the main RazorPages folder, I created another folder called Models
- In the Models folder, I created a class/file called HsitoricalFiguresAC.cs
- The following properties were added to the class:
    using System;
    using System.ComponentModel.DataAnnotations;

      namespace RazorPagesHistoricalFiguresAC.Models
      {
        public class HistoricalFiguresAC
        {
          public int ID { get; set; }
          public string Name { get; set; }

          [DataType(DataType.Date)]
          public DateTime DateOfBirth { get; set; }
          [DataType(DataType.Date)]
          public DateTime DateOfDeath { get; set; }
          public string Occupation { get; set; }
          public sting SeenIn { get; set; }
          public string Affiliation { get; set; }
        }
    }
    - This class created will allow me to put information into a database

- The following NuGet packages and EF tools were added in the terminal:
    dotnet tool install --global dotnet-ef --version 5.*
    dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
    dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
    dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
    dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*

Scaffolding the HistoricalFiguresAC Model
- I opened the Progam.cs file and ran the following comman in the terminal: dotnet-aspnet-codegenerator razorpage -m HistoricalFiguresAC -dc RazorPagesHistoricalFiguresACContext -udl -outDir Pages/HistoricalFiguresAC --referenceScriptLibraries -sqlite 
- The following was added in the command terminal: dotnet-aspnet-codegenerator razorpage -h
- In the Startup.cs file, a few changes were made to the code:
    public class Startup
    {
      public Startup(IConfiguration configuration, IWebHostEnvironment env)
      {
          Environment = env;
          Configuration = configuration;
      }

      public IConfiguration Configuration { get; }
      public IWebHostEnvironment Environment { get; }

      public void ConfigureServices(IServiceCollection services)
      {
          if (Environment.IsDevelopment())
          {
              services.AddDbContext<RazorPagesHistoricalFiguresACContext>(options =>
              options.UseSqlite(
                  Configuration.GetConnectionString("RazorPagesHistoricalFiguresACContext")));
          }
          else
          {
              services.AddDbContext<RazorPagesHistoricalFiguresACContext>(options =>
              options.UseSqlServer(
                  Configuration.GetConnectionString("HistoricalFiguresACContext")));
          }

          services.AddRazorPages();
      }
      
- The scaffolding process created the following files:
    - Pages/HistoricalFiguresAC: Create, Delete, Details, Edit, and Index
    - Data/RazorPagesHistoricalFiguresACContext.ca 

Creating the InitialDatabase Schema
- The following commands were ran in the terminal: dotnet ef migrations add InitialCreate / dontnet ef database update
    - The migrations command generated code to create the initial databse

- The following command was ran in the terminal to build and start up the Web App: dotnet watch run (once built, the Web App was opened in Google Chrome)
- https://localhost:5001/HistoricalFiguresAC/Create opened up to the create page in the Web App. This will show all of the fields that were created in the HistoricalFiguresAC.cs class
- Information was added and the Edit, Details and Delete functions were tested

- In the Pages/Shared/_Layout.cshtml file, I changed the title to HistoricalFiguresAC
- I changed the following code (<a class="navbar-brand" asp-area="" asp-page="/Index">RazorPagesHistoricalFiguresAC</a>) to <a class="navbar-brand" asp-page="/Movies/Index">RpHistoricalFiguresAC</a>

Working with the Database
- I created a class called SeedData_HistoricalFiguresAC in the Models folder
- The following code was added:
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Linq;

namespace RazorPagesHistoricalFiguresAC.Models
{
    public static class SeedData_HistoricalFiguesAC
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesHistoricalFiguresACContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesHistoricalFiguresACContext>>()))
            {
                if (context.HistoricalFiguresAC.Any())
                {
                    return;   // DB has been seeded
                }

                context.HistoricalFiguresAC.AddRange(
                    new HistoricalFiguresAC
                    {
                        Name = "Leonardo da Vinci",
                        DateOfBirth = DateTime.Parse("1452-04-15"),
                        DateOfDeath = DateTime.Parse("1519-05-02"),
                        Occupation = "Polymath",
                        SeenIn = "Assassin's Creed 2, Assassin's Creed: Brotherhood",
                        Affiliation = "Assassins: Italian Brotherhood, Templars: Italian Rite (forcibly), Hermeticists (forcibly)"
                    },

                      // This was repeated for the rest of the information
                    
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
- This populated information into the Index database
  
Updating the Generated Code
- In the Models/HistoricalFiguresAC.cs file, the following code was added to change the names of the columns in the Index database: using System.ComponentModel.DataAnnotations.Schema; / [Display(Name = "Date of Birth")] / [Display(Name = "Date of Death")] / [Display(Name = "Seen In")]
  
- The final step was to add/link the Index page to the main home page of the Web App
  - The following was added to the Shared/_Layout.cshtml file: <a class="nav-link text-dark" asp-area="" asp-page="/HistoricalFiguresAC/Index">Index</a>
