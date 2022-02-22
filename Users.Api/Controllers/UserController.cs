using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Users.Domain.Entities;
using Users.Logic.DTO;

namespace UserService.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Map()
        {
            var user = _mapper.Map<User>(new UserDto()
            {
                Email = null,
                MiddleName = null,
                Name = null,
            });
            return Ok();
        }
    }
}