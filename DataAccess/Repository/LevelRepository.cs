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
    public interface ILevelRepository : IRepositoryAsync<Level>
    {
        bool NameExist(LevelModel level);
    }
    public class LevelRepository : Repository<Level>, ILevelRepository
    {
        public LevelRepository(IDataContextAsync context, IUnitOfWorkAsync unitOfWork)
            : base(context, unitOfWork)
        {

        }

        public bool NameExist(LevelModel freezer)
        {
            return Table.Any(x => x.Name.Equals(freezer.Name));
        }
    }
}
