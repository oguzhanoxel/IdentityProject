namespace IdentityProject.WebAPI.Models.Dtos.Roles.Response;

public class RoleResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; }

	public static implicit operator RoleResponseDto(Role role)
	{
		return (role != null) ? new RoleResponseDto
		{
			Id = role.Id,
			Name = role.Name,
		} : null;
	}
}