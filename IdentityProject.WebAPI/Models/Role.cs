using IdentityProject.WebAPI.Models.Dtos.Roles.Request;
using IdentityProject.WebAPI.Models.Dtos.Users.Request;

namespace IdentityProject.WebAPI.Models;

public sealed class Role : Entity<int>
{
    public string Name { get; set; }
    public List<User> Users { get; set; }

	public static explicit operator Role(CreateRoleRequestDto dto)
	{
		return new Role
		{
			Name = dto.Name,
		};
	}

	public static explicit operator Role(UpdateRoleRequestDto dto)
	{
		return new Role
		{
			Id = dto.Id,
			Name = dto.Name,
		};
	}

	public static explicit operator Role(DeleteRoleRequestDto dto)
	{
		return new Role
		{
			Id = dto.Id,
		};
	}
}

