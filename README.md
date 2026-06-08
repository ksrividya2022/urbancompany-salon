# UrbanCompany Salon E-Commerce Application

## Overview
This project is an e-commerce application for a salon, inspired by UrbanCompany. It allows users to browse salon services, book appointments, and manage their shopping cart.

## Project Structure
The project is organized into several key directories and files:

- **Pages**: Contains Razor Pages for the application, including:
  - `_Layout.cshtml`: Defines the layout for the application.
  - `Index.cshtml`: Main landing page displaying services.
  - `Services.cshtml`: Lists available salon services.
  - `Booking.cshtml`: Interface for scheduling appointments.
  - `Cart.cshtml`: Displays the user's shopping cart.
  - `Privacy.cshtml`: Provides privacy policy information.

- **Models**: Contains data models for the application:
  - `SalonService.cs`: Defines the salon service model.
  - `Booking.cs`: Defines the booking model.
  - `CartItem.cs`: Defines the cart item model.

- **Data**: Contains database-related files:
  - `ApplicationDbContext.cs`: Manages database connection and entity sets.
  - `SeedData.cs`: Seeds initial data into the database.

- **Services**: Contains business logic related to salon services.

- **wwwroot**: Contains static files such as CSS and JavaScript:
  - `css/site.css`: Styles for the application.
  - `js/site.js`: Client-side functionality.

- **Properties**: Contains launch settings for the application.

- **Configuration Files**: Includes `appsettings.json` for configuration settings and `urbancompany-salon.csproj` for project dependencies.

## Setup Instructions
1. Clone the repository to your local machine.
2. Navigate to the project directory.
3. Restore the project dependencies using the command:
   ```
   dotnet restore
   ```
4. Run the application using the command:
   ```
   dotnet run
   ```
5. Open your web browser and navigate to `http://localhost:5000` to view the application.

## Usage
- Browse available salon services on the Services page.
- Schedule appointments through the Booking page.
- Manage your selected services in the Cart.
- Review the Privacy policy for information on data handling.

## Contributing
Contributions are welcome! Please submit a pull request or open an issue for any suggestions or improvements.