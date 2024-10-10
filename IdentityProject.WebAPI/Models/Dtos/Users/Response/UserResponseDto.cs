namespace IdentityProject.WebAPI.Models.Dtos.Users.Response;

public class UserResponseDto
{
    public int Id { get; set; }
    public string Username { get; set; }
	public string Password { get; set; }
	public string Email { get; set; }
	public string Phone { get; set; }
    public int RoleId { get; set; }

	public static implicit operator UserResponseDto(User user)
	{
		return (user != null) ? new UserResponseDto
		{
			Id = user.Id,
			Username = user.Username,
			Password = user.Password,
			Email = user.Email,
			Phone = user.Phone,
			RoleId = user.RoleId,
		} : null;
	}
}
