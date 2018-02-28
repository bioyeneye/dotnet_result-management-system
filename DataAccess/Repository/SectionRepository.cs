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
    public interface ISectionRepository : IRepositoryAsync<Section>
    {
        bool NameExist(SectionModel level);
    }
    public class SectionRepository : Repository<Section>, ISectionRepository
    {
        public SectionRepository(IDataContextAsync context, IUnitOfWorkAsync unitOfWork)
            : base(context, unitOfWork)
        {

        }

        public bool NameExist(SectionModel semeter)
        {
            return Table.Any(x => x.Name.Equals(semeter.Name));
        }
    }
}
