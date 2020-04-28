using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Repositories;
using UserService.Models;
namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        public IUserRepository iUserRepository;
        public UserController(IUserRepository iUserRepository)
        {
            this.iUserRepository = iUserRepository;
        }
        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(UserDetails userDetails)
        {
            try
            {
                iUserRepository.AddUser(userDetails);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPost]
        [Route("Login/{uname}/{pwd}")]
        public IActionResult Login(string uname, string pwd)
        {
            try
            {
                UserDetails userDetails = iUserRepository.Login(uname, pwd);
                if (userDetails == null)
                    return Ok("Invalid User");
                else
                    return Ok(userDetails);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPut]
        [Route("UpdateUser")]
        public IActionResult UpdateUser(UserDetails userDetails)
        {
            try
            {
                iUserRepository.UpdateUser(userDetails);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpGet]
        [Route("ViewUser/{userId}")]
        public IActionResult ViewUser(int userId)
        {
            try
            {
                return Ok(iUserRepository.ViewUser(userId));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}