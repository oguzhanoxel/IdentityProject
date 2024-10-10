using IdentityProject.WebAPI.Models;
using IdentityProject.WebAPI.Models.Dtos.Roles.Request;
using IdentityProject.WebAPI.Models.Dtos.Roles.Response;
using System.Linq.Expressions;

namespace IdentityProject.WebAPI.Services.Abstracts;

public interface IRoleService
{
	RoleResponseDto Create(CreateRoleRequestDto dto);
	RoleResponseDto Update(UpdateRoleRequestDto dto);
	RoleResponseDto Delete(DeleteRoleRequestDto dto);
	RoleResponseDto Get(Expression<Func<Role, bool>> predicate);
	List<RoleResponseDto> GetAll(Expression<Func<Role, bool>> predicate = null);
}