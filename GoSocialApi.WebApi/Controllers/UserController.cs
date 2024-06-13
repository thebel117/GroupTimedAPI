using GoSocialApi.Data;
using GoSocialApi.Models;
using GoSocialApi.WebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GoSocialApi.WebApi.Controllers
{
    [ApiController] // indicating this class is an API controller

    [Route("api/[controller]")] // Route -- the base route for controller
    public class UsersController : ControllerBase // UsersController class inheriting from ControllerBase
    {
        private readonly IUserService _userService; // Private readonly field for the user service

        public UsersController(IUserService userService)
        {
            _userService = userService; // Assign passed user service private field
        }

        [HttpGet]
        public IActionResult GetAllUsers() => Ok(_userService.GetAllUsers()); // to get all users, return OK result with list of users

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id) => Ok(_userService.GetUserById(id)); // gets a user by ID OK result with the user data

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user) // create new user, accepting a user obj from request body
        {
            _userService.CreateUser(user); // calling up service to create a new user
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user); // Returning a CreatedAtAction result with the location of the created user
        }

        [HttpPut("{id}")] // HTTP PUT attribute for this action with an ID parameter
        public IActionResult UpdateUser(int id, [FromBody] User user) // update existing user, accepting user obj from request body
        {
            if (id != user.Id) // Gotta look if the ID in the URL matches the ID in user obj
            {
                return BadRequest(); // BadRequest if IDs do not match
            }
            _userService.UpdateUser(user); // Call that service to update the user
            return NoContent(); // NoContent result toshow the update was successful
        }

        [HttpDelete("{id}")] // delete by Id
        public IActionResult DeleteUser(int id)
        {
            _userService.DeleteUser(id); // Call service to delete the user
            return NoContent(); // NoContent result if the deletion  successful
        }
    }
}
