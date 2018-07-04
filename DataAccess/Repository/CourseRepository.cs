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
    public interface ICourseRepository : IRepositoryAsync<Course>
    {
        bool NameExist(CourseModel level);
    }
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(IDataContextAsync context, IUnitOfWorkAsync unitOfWork)
            : base(context, unitOfWork)
        {

        }

        public bool NameExist(CourseModel model)
        {
            return Table.Any(x => x.Code.Equals(model.Code));
        }
    }
}
