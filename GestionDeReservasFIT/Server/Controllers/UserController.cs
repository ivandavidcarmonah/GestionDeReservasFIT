using AutoMapper;
using GestionDeReservasFIT.Server.Services.Interfaces;
using GestionDeReservasFIT.Shared;
using GestionDeReservasFIT.Shared.DTO;
using Microsoft.AspNetCore.Mvc;

namespace GestionDeReservasFIT.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService service;
        private readonly IMapper _mapper;

        public UserController(IUserService service, IMapper mapper)
        {
            this.service = service;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<List<User>> getUsers()
        {
            return await Task.FromResult(service.getUsers());
        }

        [HttpGet("{id}")]
        public IActionResult getUser(int Id)
        {
            UserDetailDTO user = _mapper.Map<UserDetailDTO>(service.getUser(Id));
            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public void saveUser(UserDetailDTO dto)
        {
            User user = _mapper.Map<User>(dto);
            service.newUser(user);
        }



        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            service.deleteUser(id);
            return Ok();
        }

    }
}
