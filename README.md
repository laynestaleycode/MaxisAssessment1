**MaxisAssessment1 Web Application**
This project is a simple ASP.NET Core MVC web application for managing and displaying contact form submissions. It includes features to submit a contact form, view all submissions, and search for submissions by name.

Technologies Used: ASP.NET Core MVC, Entity Framework Core, Bootstrap (for styling), SQL Server (via Entity Framework for database interactions)

**File Structure**

Controllers

ContactController.cs:
Handles the contact form submission and displays the submissions list.

HomeController.cs:
Serves the home page.


Models

ContactSubmission.cs:
Defines the structure of a contact submission with fields for Name, Email, Message, Age, and Contact Number.


Views

Home/Index.cshtml:
Displays the welcome message for the application.

Contact/Index.cshtml:
Contains the contact form for submitting user details.

Contact/Submissions.cshtml:
Displays all contact form submissions and provides a search functionality.

Database
A database is used to store all contact form submissions. The ApplicationDbContext class manages interactions with the ContactSubmissions table and posts it onto MaxisAssessmentDb.
