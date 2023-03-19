using Application.Contracts;
using DbContextL;
using Domian;

namespace InfraStructure
{
    public class ImageRepository : Repository<Image, int>, IImageRepository
    {
        public ImageRepository(Context context) : base(context)
        {

        }

        //public Task<IEnumerable<Image>> GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
