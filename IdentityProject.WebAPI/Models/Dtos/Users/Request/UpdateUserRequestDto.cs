namespace IdentityProject.WebAPI.Models.Dtos.Users.Request;

public class UpdateUserRequestDto
{
    public int Id { get; set; }
    public string Username { get; set; }
	public string Password { get; set; }
	public string Email { get; set; }
	public string Phone { get; set; }
	public int RoleId { get; set; }
}
