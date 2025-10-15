# 🎬 CinePortal - Movie Rent Management System

## Demo Video Link
https://drive.google.com/file/d/1laCWvpiR7H0f_CJ-5AWj-5K6uwX0nYbk/view?usp=sharing

## 📋 Project Overview
CinePortal is a comprehensive web-based Movie Rent Management System that provides an intuitive platform for movie enthusiasts to browse, rent, and watch movies online. The system features a dual-interface architecture catering to both regular users and administrators, with robust features for movie management, user management, and rental processing.

## ✨ Features

### 🎥 User Features
- **Browse Movies**
  - Browse available movies with details
  - View movie information including cast and crew
  - Add movies to shopping cart
- **Shopping Cart**
  - Add/remove movies from cart
  - View cart contents and total
  - Proceed to checkout
- **Order Management**
  - View order history
  - Track order status
  - Download purchased movies

### 🔧 Admin Features
- **Movie Management**
  - Full CRUD operations for movies
  - Manage movie details, images, and metadata
  - Associate actors and producers with movies
- **People Management**
  - Manage actors and their profiles
  - Manage producers and their details
  - View filmography
- **Cinema Management**
  - Manage cinema locations
  - Screen and showtime management
  - Seating arrangements

## 🚀 Tech Stack
- **Frontend**
  - HTML5, CSS3, JavaScript
  - Bootstrap 5 for responsive design
  - jQuery for DOM manipulation
  - AJAX for async operations
- **Backend**
  - .NET Core MVC
  - C#
  - Entity Framework Core for data access
- **Database**
  - SQL Server
  - Entity Framework Core Migrations
  - Relationships between Movies, Actors, Producers, and Cinemas
- **Authentication & Authorization**
  - ASP.NET Core Identity for user management
  - Role-based access control (Admin/User roles)
  - Secure authentication flows
- **Architecture**
  - MVC Pattern
  - Repository Pattern
  - Dependency Injection

## 🛠️ Setup Instructions

### Prerequisites
- .NET 8.0 SDK or later
- SQL Server 2019 or later
- Visual Studio 2022 (recommended) or VS Code

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/CinePortal.git
   cd CinePortal
   ```

2. Restore NuGet packages:
   ```bash
   dotnet restore
   ```

3. Update the connection string in `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=your_server;Database=CinePortalDB;Trusted_Connection=True;"
   }
   ```

4. Run database migrations:
   ```bash
   dotnet ef database update
   ```

5. Run the application:
   ```bash
   dotnet run
   ```

6. Open your browser and navigate to:
   ```
   https://localhost:5001
   ```

## 👥 Team Members & Contributions

### Development Team
- **Vishv Sureja** - Project Lead 
  - Implemented core movie management features
  - Designed database schema and API endpoints
  - Set up authentication and authorization

- **Jal Shah** - Frontend Developer
  - Designed and implemented user interfaces
  - Created responsive layouts and components
  - Integrated with backend APIs
