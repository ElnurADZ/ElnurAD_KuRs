using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClientService _clientService;
        public ClientController(IClientService userService)
        {
            _clientService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _clientService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(int id)
        {
            return Ok(await _clientService.GetOne(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Client user)
        {
            await _clientService.Create(user);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Client user)
        {
            await _clientService.Update(user);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _clientService.Delete(id);
            return Ok();
        }
    }
}