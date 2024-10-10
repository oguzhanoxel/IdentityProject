using IdentityProject.WebAPI.Contexts;
using IdentityProject.WebAPI.Models;
using IdentityProject.WebAPI.Repositories.Abstracts;

namespace IdentityProject.WebAPI.Repositories.Concretes;

public class EfUserRepository : EfRepositoryBase<MsSqlContext, User>, IUserRepository
{
	public EfUserRepository(MsSqlContext context) : base(context)
	{

	}
}
