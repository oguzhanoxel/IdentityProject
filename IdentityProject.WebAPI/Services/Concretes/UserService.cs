using IdentityProject.WebAPI.Models;
using IdentityProject.WebAPI.Models.Dtos.Users.Request;
using IdentityProject.WebAPI.Models.Dtos.Users.Response;
using IdentityProject.WebAPI.Repositories.Abstracts;
using IdentityProject.WebAPI.Services.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace IdentityProject.WebAPI.Services.Concretes;

public class UserService : IUserService
{
	private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public UserResponseDto Create(CreateUserRequestDto dto)
	{
		User user = (User)dto;
		return _repository.Create(user);
	}

	public UserResponseDto Update(UpdateUserRequestDto dto)
	{
		User user = (User)dto;
		return _repository.Update(user);
	}

	public UserResponseDto Delete(DeleteUserRequestDto dto)
	{
		User user = (User)dto;
		return _repository.Delete(user);
	}

	public UserResponseDto Get(Expression<Func<User, bool>> predicate)
	{
		return _repository.Get(predicate, include: q => q.Include(u => u.Role));
	}

	public List<UserResponseDto> GetAll(Expression<Func<User, bool>> predicate = null)
	{
		return _repository
			.GetAll(predicate, include: q => q.Include(u => u.Role))
			.Select(x => (UserResponseDto)x).ToList();
	}
}
