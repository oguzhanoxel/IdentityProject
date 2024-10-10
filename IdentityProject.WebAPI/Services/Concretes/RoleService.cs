using IdentityProject.WebAPI.Models;
using IdentityProject.WebAPI.Models.Dtos.Roles.Request;
using IdentityProject.WebAPI.Models.Dtos.Roles.Response;
using IdentityProject.WebAPI.Repositories.Abstracts;
using IdentityProject.WebAPI.Services.Abstracts;
using System.Linq.Expressions;

namespace IdentityProject.WebAPI.Services.Concretes;

public class RoleService : IRoleService
{
	private readonly IRoleRepository _repository;

	public RoleService(IRoleRepository repository)
	{
		_repository = repository;
	}

	public RoleResponseDto Create(CreateRoleRequestDto dto)
	{
		Role role = (Role)dto;
		return _repository.Create(role); ;
	}

	public RoleResponseDto Update(UpdateRoleRequestDto dto)
	{
		Role role = (Role)dto;
		return _repository.Update(role);
	}

	public RoleResponseDto Delete(DeleteRoleRequestDto dto)
	{
		Role role = (Role)dto;
		return _repository.Delete(role);
	}

	public RoleResponseDto Get(Expression<Func<Role, bool>> predicate)
	{
		return _repository.Get(predicate);
	}

	public List<RoleResponseDto> GetAll(Expression<Func<Role, bool>> predicate = null)
	{
		return _repository.GetAll(predicate).Select(x => (RoleResponseDto) x).ToList();
	}
}
