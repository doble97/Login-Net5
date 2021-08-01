using Microsoft.AspNetCore.Mvc;
using CoreApi.Models;
using CoreApi.Interfaces;


namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public UserController(IUserRepository repository){
            _repository = repository;
        }
        //CRUD 
        [HttpGet]
        public IActionResult GetUsers(){
            return Ok("HOla mundo");
        }
        [HttpGet("{id}")]
        public IActionResult GetUser(int id){
            var user = new User(){
                Id = id,
                Name= "Jorge Gonzalez",
                Username="doblej",
                Password="123456",
            };
            return Ok(user);
        }
        
        //CREATE
        [HttpPost]
        public IActionResult CreateUser(User user){
            /*if(ModelState.IsValid){
                System.Console.WriteLine("MODELO VALIDO");
            }
            var userDto = new UserDto(){
                Id=18,
                Name="Jorge",
                Username="doblej97"
            };*/
            
            // return Ok(userDto);
            return Ok("nothing");
        }
    }
}