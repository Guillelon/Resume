using Resume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Resume.Controllers
{
    public class ResumeController : ApiController
    {
        // GET api/resume/5
        public MyResume Get(int id)
        {
            var resume = new MyResume
            {
                Info = new Information
                {
                    Name = "Daniel Alejandro Quijada Cáceres",
                    Address = "94th ST #11-29, apt 601",
                    Country = "Colombia",
                    City = "Bogota",
                    PhoneNumber = "+573044587050",
                    Email = "dquijadaus@gmail.com"
                },
                Education = new List<Education> 
                { 
                    new Education 
                    {
                        Where = "Andres Bello Catholic University",
                        Country = "Venezuela",
                        City = "Caracas",
                        Title = "Computer Engineer",
                        Since = new DateTime(2007,04,15),
                        Until = new DateTime(2012,06,10)
                    }
                },
                Experience = new List<Job> 
                { 
                    new Job 
                    {
                        Name = "Mobile Developer, Viitru S.A.S",
                        Country = "Colombia",
                        City = "Bogota",
                        Since = new DateTime(2012,10,19),
                        Until = DateTime.Now,
                        Responsabilities = new List<string>
                        {
                            "Develop iOS application named WODpal, focused on Crossfit athletes who want to keep tracking of their daily routines (Application already in the App store)",
                            "Conceptualize WODpal functionalities and features",
                            "Research for numerous tools which allow code reutilization for different mobile platforms",
                            "Develop the same application (WODpal) for Android (Coming soon to Google Play)",
                            "Conceptualize Runity functionalities and features. Runity is an application with the goal of helping people improve their health condition through nutrition plans and pre-established workouts"
                        }
                    },
                    new Job
                    {
                        Name = "Web Developer (Back-end), Summumnet",
                        Country = "Venezuela",
                        City = "Caracas",
                        Since = new DateTime(2011,09,17),
                        Until = new DateTime(2012,10,15),
                        Responsabilities = new List<string>
                        {
                            "In charge of designing, developing and maintaining the company’s Web API",
                            "Implementation of OAuth 2.0 protocol as a security layer for the Web API",
                            "Implementation of HTTP Basic protocol as an additional security layer for the Web API",
                            "Design, develop and maintain web solutions offered by the company to its users"
                        }
                    }
                },
                Objective = "Obtain simple solutions starting from complex problems",
                Abilities = new List<string> 
                {
                    "Deep analysis for decision making",
                    "Working under pressure",
                    "Research for the latest technical tools in order to ease job tasks",
                    "Fast learning"
                },
                Knowledge = new List<string> 
                { 
                    "Windows Azure Mobile Services",
                    "Xamarin",
                    "ASP.NET MVC 4",
                    "Javascript and libraries based on this language such as: Knockout JS, Jquery, Breeze",
                    "ASP.NET Web API  ",
                    "Object oriented programming. Encapsulation principle, design patterns",
                    "MVC (Model View Controller), MVVM (Model View ViewModel)",
                    "Advanced C# language",
                    "Basic knowledge of: Java, SQL, Transact-SQL, PL-SQL, SQL-Server, MySQL, Oracle, CSS, CSS3, HTML5",
                }
            };

            return resume;
        }
    }
}
