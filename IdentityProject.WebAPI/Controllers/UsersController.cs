using IdentityProject.WebAPI.Models.Dtos.Users.Request;
using IdentityProject.WebAPI.Models.Dtos.Users.Response;
using IdentityProject.WebAPI.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
	private IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("add")]
    public IActionResult Add(CreateUserRequestDto dto)
    {
        UserResponseDto response = _userService.Create(dto);
        return Ok(response);
    }

    [HttpPut("update")]
    public IActionResult Update(UpdateUserRequestDto dto)
    {
        UserResponseDto response = _userService.Update(dto);
        return Ok(response);
    }

	[HttpDelete("delete")]
	public IActionResult Delete(DeleteUserRequestDto dto)
    {
        UserResponseDto response = _userService.Delete(dto);
        return Ok(response);
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        List<UserResponseDto> response = _userService.GetAll();
        return Ok(response);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(int id)
    {
		UserResponseDto response = _userService.Get(u => u.Id == id);
        if (response == null) return NotFound();
        return Ok(response);
    }
}
