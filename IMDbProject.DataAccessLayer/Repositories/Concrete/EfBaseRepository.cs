using IMDbProject.DataAccessLayer.Context;

namespace IMDbProject.DataAccessLayer.Repositories.Concrete
{
    public class EfBaseRepository
    {
        public ProjectContext db;
        public EfBaseRepository()
        {
            db = new ProjectContext();
        }
    }
}
