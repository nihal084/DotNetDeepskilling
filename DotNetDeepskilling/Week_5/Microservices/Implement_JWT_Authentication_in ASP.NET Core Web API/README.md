# Lab: Implementing JWT Authentication in ASP.NET Core Web API

## Objective:
Implement JSON Web Token (JWT) authentication in an ASP.NET Core Web API project to protect routes and validate user identity.

## Technologies Used:
- ASP.NET Core Web API (.NET 6+)
- Microsoft.AspNetCore.Authentication.JwtBearer
- Swagger (Swashbuckle)
- Visual Studio Code or Visual Studio
- Postman or Swagger UI for testing

## Steps to Run the Project:
1. Open terminal or PowerShell.
2. Navigate to your project folder:
   cd DotNetFSE/week5/JwtAuthDemo
3. Open the project in VS Code:
   code .
4. Clean and build the project:
   dotnet clean
   dotnet build
5. Run the application:
   dotnet run
6. Open Swagger in browser (default):
   http://localhost:5276/swagger  Swagger UI (runs only when application is started locally)

## JWT Authentication Flow:
1. Use POST /auth/login endpoint to get a token.
   Request Body:
   {
     "username": "admin",
     "password": "admin"
   }

2. Copy the token from the response.
   Example token:
   eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...

3. In Swagger UI, click "Authorize" and paste token like:
   Bearer eyJhbGciOiJIUzI1NiIs...

4. Call a protected endpoint (e.g., GET /weatherforecast).
   If the token is valid, the API returns data.

## Configuration (appsettings.json):
"Jwt": {
  "Key": "ThisIsMySuperSecureKey12345",
  "Issuer": "JwtAuthDemo",
  "Audience": "JwtAuthDemoUser"
}

## Output
<img width="1280" height="719" alt="image" src="https://github.com/user-attachments/assets/f87b107b-11ae-4bf7-a2aa-0fee2593f7ce" />
<img width="1280" height="719" alt="image" src="https://github.com/user-attachments/assets/877b01b8-f7a6-421f-8dda-952f23924b20" />
<img width="1280" height="719" alt="image" src="https://github.com/user-attachments/assets/d18f4e66-f5a7-42a9-9044-42bc06dcc63e" />

## Conclusion

This lab demonstrated the complete setup and use of JWT authentication in an ASP.NET Core Web API. 

