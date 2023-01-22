using GestionDeReservasFIT.Server.Services.Interfaces;
using GestionDeReservasFIT.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionDeReservasFIT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService service;

        public RoleController(IRoleService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<List<Role>> getRoles()
        {
            return await Task.FromResult(service.getRoles());
        }

        [HttpGet("{id}")]
        public IActionResult getRole(int Id)
        {
            Role value = service.getRole(Id);
            if (value != null)
            {
                return Ok(value);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public void saveUser(Role value)
        {
            service.newRole(value);
        }

        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            service.deleteRole(id);
            return Ok();
        }
    }
}
