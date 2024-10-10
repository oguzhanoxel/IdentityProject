using IdentityProject.WebAPI.Contexts;
using IdentityProject.WebAPI.Models;
using IdentityProject.WebAPI.Repositories.Abstracts;

namespace IdentityProject.WebAPI.Repositories.Concretes;

public class EfRoleRepository : EfRepositoryBase<MsSqlContext, Role>, IRoleRepository
{
	public EfRoleRepository(MsSqlContext context) : base(context)
	{
	}
}
