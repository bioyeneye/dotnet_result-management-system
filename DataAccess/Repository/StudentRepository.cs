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
    public interface IStudentRepository : IRepositoryAsync<Student>
    {
        bool NameExist(StudentModel level);
    }
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(IDataContextAsync context, IUnitOfWorkAsync unitOfWork)
            : base(context, unitOfWork)
        {

        }

        public bool NameExist(StudentModel student)
        {
            return Table.Any(x => x.MatricNumber.Equals(student.MatricNumber));
        }
    }
}
