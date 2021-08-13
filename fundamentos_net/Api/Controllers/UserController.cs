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
            return Ok(_repository.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult GetUser(int id){
            var user = _repository.GetOne(id);
            return Ok(user);
        }
        
        //CREATE
        [HttpPost]
        public IActionResult CreateUser(User user){
            _repository.Create(user);
            return Ok(user);
        }
    }
}