using Microsoft.AspNetCore.Mvc;
using JwtAuthDemo.Models; // Assuming LoginModel is in this namespace

namespace JwtAuthDemo.Controllers
{
    [ApiController] // Essential for API behavior and Swagger discovery
    [Route("api/[controller]")] // Defines the base route for this controller (e.g., /api/Auth)
    public class AuthController : ControllerBase // Inherit from ControllerBase
    {
        [HttpPost("login")] // Defines the HTTP method and specific route for this action (e.g., /api/Auth/login)
        public IActionResult Login([FromBody] LoginModel model)
        {
            // Your authentication logic here
            // For now, let's just return a success message
            if (model.Username == "test" && model.Password == "password")
            {
                // In a real app, you'd generate a JWT token here
                return Ok(new { Message = "Login successful!", Token = "YOUR_GENERATED_JWT_TOKEN" });
            }
            return Unauthorized(new { Message = "Invalid credentials" });
        }

        
    }
}