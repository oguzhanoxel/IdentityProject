using IdentityProject.WebAPI.Models.Dtos.Users.Request;

namespace IdentityProject.WebAPI.Models;

public sealed class User : Entity<int>
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int RoleId { get; set; }
    public Role Role { get; set; }

    public static explicit operator User(CreateUserRequestDto dto)
    {
        return new User
        {
            Username = dto.Username,
            Password = dto.Password,
            Email = dto.Email,
            Phone = dto.Phone,
			RoleId = dto.RoleId,
        };
    }

	public static explicit operator User(UpdateUserRequestDto dto)
	{
		return new User
		{
			Id = dto.Id,
			Username = dto.Username,
			Password = dto.Password,
			Email = dto.Email,
			Phone = dto.Phone,
			RoleId = dto.RoleId,
		};
	}

	public static explicit operator User(DeleteUserRequestDto dto)
	{
		return new User
		{
			Id = dto.Id,
		};
	}
}

