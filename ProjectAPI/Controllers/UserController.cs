using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config;
        public readonly Context _context;
        public UserController(IConfiguration config, Context context)
        {
            _config = config;
            _context = context;
        }

        [HttpPost("CreateUser")]
        public IActionResult Create(User user)
        {
            if (_context.Users.Where(u => u.UserName == user.UserName).FirstOrDefault() != null)
            {
                return Ok("Already Exist");
            }
            user.UserID = _context.Users.Count() + 1;
            user.UserType = UserType.Customer;
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok("Success");
        }

        [HttpPost("LoginUser")]
        public IActionResult Login(User user)
        {

            var userAvailable = _context.Users.Where(u=>u.UserName == user.UserName && u.PassWord == user.PassWord).FirstOrDefault();
            if(userAvailable != null)
            {
                //return Ok(new JwtService(_config).GenerateToken(
                //    userAvailable.UserID.ToString(),
                //    userAvailable.UserName,
                //    userAvailable.PassWord,
                //    userAvailable.Email,
                //    userAvailable.PhoneNumber,
                //    userAvailable.Gender,
                //    userAvailable.UserType.ToString()
                //));
                //user.UserID = 0;
                //user.Email = string.Empty;
                //user.PhoneNumber = string.Empty;
                //user.Gender = string.Empty;
                //user.UserType = UserType.Customer;
                return Ok("Success");
            }
            return Ok("Failure");
        }
    }
}
