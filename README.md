# BlazorWebAppMovies

A simple ASP.NET Core and Blazor app which displays movie entries and allows you to apply CRUD operations on them (if the user has the Role "Administrator").

When downloading the project, add a EF migration and update the database so that Entity Framework creates the tables according to the data models. There's a file named "SeedData.cs" which will seed 5 entries into the "Movie" table if it detects that there are no movies present, and will do the same to the "user_account" table (this time adding 2 users: a normal user and an administrator). For more information about the seeded data, refer to the "SeedData.cs" file.
