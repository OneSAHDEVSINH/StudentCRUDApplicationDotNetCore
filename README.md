# Student CRUD Application – ASP.NET Core

![License](https://img.shields.io/badge/license-MIT-green)  
![Languages](https://img.shields.io/github/languages/top/OneSAHDEVSINH/StudentCRUDApplicationDotNetCore)
![image](https://github.com/user-attachments/assets/bf121b65-1054-447c-ba9e-ac1d57ad23da)
![image](https://github.com/user-attachments/assets/36661dd9-7624-4a9d-af32-441d4ea887fe)
![image](https://github.com/user-attachments/assets/8d0bb864-5ffa-4fb5-91ed-8c3ad964642e)

A **Student CRUD Application** built with **ASP.NET Core**, designed to handle basic operations like **Create**, **Read**, **Update**, and **Delete** for managing student data. This application showcases the use of **C#** as the backend language with a responsive front-end powered by **HTML**, **CSS**, and **JavaScript**.

## Table of Contents

- [Features](#features)
- [Technologies Used](#technologies-used)
- [Setup and Installation](#setup-and-installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Create**: Add new student records into the database.
- **Read**: View a list of students, with detailed information for each record.
- **Update**: Edit existing student information.
- **Delete**: Remove student records from the database.
- **Responsive Design**: Optimized for desktop and mobile devices.
- **Validation**: Includes server-side and client-side validation.

## Technologies Used

- **Backend**: ASP.NET Core (C#)
- **Frontend**: HTML, CSS, JavaScript
- **Database**: (Specify here, e.g., SQL Server or MySQL)
- **Frameworks**: 
  - Entity Framework Core (for database operations)
  - Razor Pages or MVC (specify which one is used)
- **Version Control**: Git

## Setup and Installation

Follow these steps to set up the project:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/OneSAHDEVSINH/StudentCRUDApplicationDotNetCore.git
   cd StudentCRUDApplicationDotNetCore
   ```

2. **Install dependencies**:
   Ensure you have the following installed:
   - [.NET SDK](https://dotnet.microsoft.com/download)
   - A supported IDE (e.g., Visual Studio, Visual Studio Code)

3. **Restore NuGet packages**:
   ```bash
   dotnet restore
   ```

4. **Configure the database**:
   - Update the `appsettings.json` file with your database connection string.
   - Run migrations to set up the database schema:
     ```bash
     dotnet ef database update
     ```

5. **Run the application**:
   ```bash
   dotnet run
   ```

6. Open your browser and navigate to `http://localhost:5000` (or the URL specified in your launch settings).

## Usage

- Navigate to the **Students** section to manage records.
- Use the **Add Student** button to create a new record.
- Use the **Edit** button to modify existing records.
- Use the **Delete** button to remove unwanted records.
- Search or filter students based on criteria (if implemented).

## Project Structure

```plaintext
StudentCRUDApplicationDotNetCore/
├── Controllers/        # Backend logic (if MVC is used)
├── Models/             # Data models
├── Views/              # Frontend views (if MVC is used)
├── wwwroot/            # Static files (CSS, JS, images)
├── appsettings.json    # Configuration settings
├── Startup.cs          # Application startup logic
└── Program.cs          # Main entry point
```

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new feature branch:
   ```bash
   git checkout -b feature-name
   ```
3. Commit your changes:
   ```bash
   git commit -m "Add feature description"
   ```
4. Push to the branch:
   ```bash
   git push origin feature-name
   ```
5. Open a pull request.

## License

This project is licensed under the [MIT License](LICENSE).  
