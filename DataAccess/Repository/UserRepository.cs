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
    public interface IUserRepository : IRepositoryAsync<User>
    {
        bool NameExist(UserModel level);
    }
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(IDataContextAsync context, IUnitOfWorkAsync unitOfWork)
            : base(context, unitOfWork)
        {

        }

        public bool NameExist(UserModel user)
        {
            return Table.Any(x => x.UserName.Equals(user.Username));
        }
    }
}
