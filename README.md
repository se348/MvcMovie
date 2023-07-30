# MVC Movie App with Repository Pattern and Unit of Work Pattern

The MVC Movie App is a web application built with .NET and Razor Views, designed to help you learn the basics of .NET development with the Repository Pattern and Unit of Work Pattern. The app allows users to view a list of movies and their details.

## Getting Started

To run the MVC Movie App locally on your machine, follow these steps:

1. **Prerequisites:**
   - [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

2. **Clone the repository:**
   - git clone https://github.com/se348/MvcMovie.git
3.  **Navigate to the project directory:**
   - cd MvcMovie/
4. **Run the app:**
   - dotnet run

5. **Open the app in your browser:**
Visit `https://localhost:5001` or `http://localhost:5000` in your web browser.

## Features

- View a list of movies with their titles, release dates, and genres.
- Click on a movie to view its details, including the title, release date, genre, and price.
- Filter movies by genre.
- Search for movies by title.

## Technologies Used

- .NET 6
- C#
- Razor View
- Entity Framework Core (EF Core)
- Microsoft Server SQL

## Project Structure

The project structure follows the standard .NET conventions for Razor Pages applications:

- `views/`: Contains Razor Pages, including the main page, details page, and error page.
- `Models/`: Defines the models used in the application, such as the `Movie` model.
- `DAL/`- contains the data access layer, unit of work, and repositories.
- `wwwroot/`: Stores static files such as CSS, JavaScript, and images.
- `Controllers/`: this is where the controllers are stored.

## Design Patterns

### Repository Pattern

The Repository Pattern is used to separate the data access logic from the application's business logic. It encapsulates the logic for interacting with the data source (e.g., database) in separate repository classes, making it easier to manage and test data-related operations.

### Unit of Work Pattern

The Unit of Work Pattern is used to manage multiple repositories as a single transaction. It allows you to perform multiple database operations as a single unit, ensuring consistency and integrity in the database.

## Contributing

Contributions to the MVC Movie App are welcome! If you find any bugs, have suggestions, or want to add new features, feel free to open an issue or submit a pull request.

## Acknowledgments

The MVC Movie App was inspired by the official .NET tutorials and various community-driven learning resources. Special thanks to all the contributors who have helped make this project better.

Feel free to use this README template for your MVC Movie App project and customize it with your own app details. Enjoy learning .NET development with the Repository Pattern and Unit of Work Pattern! Happy coding!
