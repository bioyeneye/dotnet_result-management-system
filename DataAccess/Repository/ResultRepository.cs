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
    public interface IResultRepository : IRepositoryAsync<Result>
    {
       // bool NameExist(ResultModel level);
    }
    public class ResultRepository : Repository<Result>, IResultRepository
    {
        public ResultRepository(IDataContextAsync context, IUnitOfWorkAsync unitOfWork)
            : base(context, unitOfWork)
        {

        }


    }



}
