# Product Manager Desktop Application

## Project Overview
This is a desktop application built using C# Windows Forms that helps manage products, users, and categories. The application follows a three-tier architecture pattern.

## Project Structure
The project consists of three main layers:

1. **MarketPresentation Layer**
   - Contains all Windows Forms and user interface components

2. **MarketBusiness Layer**
   - Contains business logic and services

3. **MarketDataAccess Layer**
   - Handles database operations and data access

## Prerequisites
- Visual Studio 2022 or later
- .NET Framework 4.7.2 or later
- SQL Server (LocalDB or Express)
- Windows OS

## Setup Instructions

### 1. Clone the Repository
```bash
git clone [repository-url]
```

### 2. Database Setup
1. Open SQL Server Management Studio
2. Create a new database named "MarketDB"
3. Run the database scripts (if provided)

### 3. Configuration
1. Open the solution in Visual Studio
2. Update the connection string in `DBContext.cs` if needed
3. Build the solution

### 4. Running the Application
1. Set MarketPresentation as the startup project
2. Press F5 or click "Start" to run the application

## Features
- User Authentication (Login/Registration)
- Product Management (Add/Update/Delete)
- Category Management
- User Profile Management
- Favorites System

## Project Structure Details

### MarketPresentation Layer
- `Home.cs` - Main application window
- `Login.cs` - User login form
- `Registration.cs` - User registration form
- `User.cs` - User profile management
- `AddProduct.cs` - Product addition form
- `UpdateProduct.cs` - Product update form
- `Category.cs` - Category management form

### MarketBusiness Layer
- `UserService.cs` - User-related business logic
- `ProductService.cs` - Product-related business logic
- `CategoriesService.cs` - Category-related business logic
- `FavoriteService.cs` - Favorites management logic

### MarketDataAccess Layer
- `DBContext.cs` - Database context and connection management

## Contributing
1. Fork the repository
2. Create a new branch
3. Make your changes
4. Submit a pull request

## 📚 Documentation
- [Project Demo Video](https://youtu.be/hTYAVH-j5t0)

## License
This project is licensed under the MIT License.

## Contact
For any questions or support, please contact the project maintainers. 
