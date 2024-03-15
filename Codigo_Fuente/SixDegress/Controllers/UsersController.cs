using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SixDegrees.Application.Services;
using SixDegrees.Application.Wrappers;
using SixDegrees.Entities;

namespace SixDegress.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<JsonResponse<IEnumerable<User>>>> GetAsync(CancellationToken cancellationToken)
        {
            var response = await _userService.GetAsync(cancellationToken);
            return StatusCode((int)response.HttpCode, response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<JsonResponse<User>>> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            var response = await _userService.GetByIdAsync(id, cancellationToken);
            return StatusCode((int)response.HttpCode, response);
        }

        [HttpPost]
        public async Task<ActionResult<JsonResponse<User>>> CreateAsync([FromBody] User usuario)
        {
            var response = await _userService.CreateAsync(usuario);
            return StatusCode((int)response.HttpCode, response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<JsonResponse<User>>> UpdateAsync(int id, [FromBody] User usuario)
        {
            var response = await _userService.UpdateAsync(id, usuario);
            return StatusCode((int)response.HttpCode, response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<JsonResponse<bool?>>> DeleteAsync(int id)
        {
            var response = await _userService.DeleteAsync(id);
            return StatusCode((int)response.HttpCode, response);
        }
    }
}
