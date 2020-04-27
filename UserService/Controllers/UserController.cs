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
        public IUserRepository _repo;
        public UserController(IUserRepository repo)
        {
            _repo = repo;
        }
        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(UserDetails user)
        {
            try
            {
                _repo.AddUser(user);
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
                UserDetails user = _repo.Login(uname, pwd);
                if (user == null)
                    return Ok("Invalid User");
                else
                    return Ok(user);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPut]
        [Route("UpdateUser")]
        public IActionResult UpdateUser(UserDetails user)
        {
            try
            {
                _repo.UpdateUser(user);
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
                return Ok(_repo.ViewUser(userId));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}