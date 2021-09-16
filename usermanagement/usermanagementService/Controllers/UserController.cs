using Microsoft.AspNetCore.Mvc;
using usermanagementService.Service;
using usermanagementService.Models;
using usermanagementService.Data;

namespace usermanagementService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        IUserRepository userRepository;

        public UserController(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        [HttpPost("Add_Record")]
        public IActionResult AddRecord(User user)
        {
            var addDet = userRepository.AddUser(user);
            if(addDet != 0)
            {
                return Ok("Details Added");
            }
            return Forbid();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRecord(int id)
        {
            var delUser = userRepository.DeleteUser(id);
            return Ok("Record Deleted");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRecord(int id, User user)
        {
            var upUser = userRepository.UpdateUser(id, user);
            return Ok("Result Updated");
        }


        [HttpGet("{id}")]
        public IActionResult SearchRecord(int id)
        {
            var seUser = userRepository.SearchUser(id);
            return Ok(seUser);
        }

        [HttpGet("Get_Record")]
        public IActionResult GetRecord()
        {
            var getUser = userRepository.GetUsers();
            return Ok(getUser);
        }
    }
}