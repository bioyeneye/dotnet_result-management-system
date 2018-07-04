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
    public interface ISemesterRepository : IRepositoryAsync<Semeter>
    {
        bool NameExist(SemesterModel level);
    }
    public class SemesterRepository : Repository<Semeter>, ISemesterRepository
    {
        public SemesterRepository(IDataContextAsync context, IUnitOfWorkAsync unitOfWork)
            : base(context, unitOfWork)
        {

        }

        public bool NameExist(SemesterModel semeter)
        {
            return Table.Any(x => x.Name.Equals(semeter.Name));
        }
    }
}
