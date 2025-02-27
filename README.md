# 🔐 JWT Authentication API (ASP.NET 8 Web API)

This project is a **JWT (JSON Web Token) authentication system** implemented in an **ASP.NET 8 Web API**.  
It allows secure API authentication and authorization using JWT tokens and can be easily tested with **Swagger UI**. 🚀

## 🛠️ Technologies Used
- **.NET 8 Web API**
- **JWT (JSON Web Token) Authentication**
- **ASP.NET Identity Model**
- **Swagger UI**
- **Dependency Injection (DI)**
- **Claim-based Authorization**

---

## 📌 Getting Started

### **1️⃣ Install Dependencies**
Make sure you have **.NET 8 SDK** installed. If not, you can download it here:

🔗 **[Download .NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)**

Before running the project for the first time, install dependencies:

dotnet restore

### ** Run the Project
Start the project using:
dotnet run

**📌 If the API starts successfully, you should see an output like this:**
Now listening on: https://localhost:5000
Now listening on: https://localhost:7000
Application started. Press CTRL+C to shut down.

### **3️⃣ Test the API with Swagger UI**
Once the API is running, Swagger UI will be opened in your browser.
Here, you can visually test all **JWT authentication operations!**

## 🔑 Using JWT Authentication

### **1️⃣ Obtain a JWT Token**
**📌 Use the POST /api/auth/login endpoint to log in and get a JWT token.**
**📝 Send this JSON:**
{
  "username": "admin",
  "password": "admin"
}
These values **can be changed** in AuthController.cs

**✅ Successful Response:**
{
  "token": "eyJhbGciOiJIUzI1NiIsInR..."
}
Copy the **token** from the response.

### **2️⃣ Use the JWT Token in Swagger**
1. Click the 🔓 Authorize button in the top right corner of Swagger UI.
2. Enter the token in this format:
Bearer eyJhbGciOiJIUzI1NiIsInR...
3. Click **Authorize.**
**✅ Now you can access protected API endpoints!**

### **3️⃣ Access a Protected API Endpoint**
Once authorized, you can test the **Admin-protected endpoints.**
**📌 Example:** GET /api/secure/admin

**✅ Successful Response:**
"Only Admin can access to this page!"

**❌ Unauthorized Access (If no token is provided or it's invalid):**
{
    "status": 401,
    "error": "Unauthorized"
}

## **📂 Project Structure**

JwtAuthDemo/
│── Controllers/
│   ├── AuthController.cs      # Handles user authentication (JWT Token generation)
│   ├── SecureController.cs    # Protected endpoints (Requires JWT Authentication)
│── Services/
│   ├── ITokenService.cs       # Token service interface
│   ├── TokenService.cs        # Implements JWT Token creation
│── appsettings.json           # JWT Secret Key Configuration
│── Program.cs                 # JWT Authentication Middleware setup
│── README.md                  # Project documentation

## **🚀 Contributing**

If you'd like to contribute:
    Feel free to add new features or submit a pull request.
    Report any issues or bugs by opening an Issue.

**✅If you like this project, don't forget to star it! ⭐**
**📧 For any questions, feel free to reach out via GitHub Issues. 😊**
