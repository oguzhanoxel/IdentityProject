using IdentityProject.WebAPI.Models.Dtos.Roles.Request;
using IdentityProject.WebAPI.Models.Dtos.Roles.Response;
using IdentityProject.WebAPI.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RolesController : ControllerBase
{
	private IRoleService _roleService;

    public RolesController(IRoleService roleService)
	{
        _roleService = roleService;
    }

	[HttpPost("add")]
	public IActionResult Add(CreateRoleRequestDto dto)
	{
		RoleResponseDto response = _roleService.Create(dto);
		return Ok(response);
	}

	[HttpPut("update")]
	public IActionResult Update(UpdateRoleRequestDto dto)
	{
		RoleResponseDto response = _roleService.Update(dto);
		return Ok(response);
	}

	[HttpDelete("delete")]
	public IActionResult Delete(DeleteRoleRequestDto dto)
	{
		RoleResponseDto response = _roleService.Delete(dto);
		return Ok(response);
	}

	[HttpGet("getall")]
	public IActionResult GetAll()
	{
		List<RoleResponseDto> response = _roleService.GetAll();
		return Ok(response);
	}

	[HttpGet("getbyid")]
	public IActionResult GetById(int id)
	{
		RoleResponseDto response = _roleService.Get(u => u.Id == id);
		if (response == null) return NotFound();
		return Ok(response);
	}
}
