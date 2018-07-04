using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.BaseRepository;
using DataAccess.EF;
using Model.ViewModel;

namespace DataAccess.Repository
{
    public interface IAspNetUserRepository : IRepositoryAsync<AspNetUser>
    {
        bool NameExist(AspNetUserModel level);
    }
    public class AspNetUserRepository : Repository<AspNetUser>, IAspNetUserRepository
    {
        public AspNetUserRepository(IDataContextAsync context, IUnitOfWorkAsync unitOfWork)
            : base(context, unitOfWork)
        {

        }

        public bool NameExist(AspNetUserModel user)
        {
            return Table.Any(x => x.UserName.Equals(user.UserName) && user.Id != x.Id);
        }
    }
}
