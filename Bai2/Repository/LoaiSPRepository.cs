using Bai2.Models;

namespace Bai2.Repository
{
    public class LoaiSPRepository : ILoaiSPRepository
    {
        private readonly QlbanVaLiContext _context;
        public LoaiSPRepository(QlbanVaLiContext context)
        {
            _context = context;
        }

        public TLoaiSp Add(TLoaiSp loaisp)
        {
            throw new NotImplementedException();
        }

        public TLoaiSp Delete(string MaLoai)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TLoaiSp> GetAllLoaiSp()
        {
            return _context.TLoaiSps;
        }

        public TLoaiSp GetLoaiSp(string MaLoai)
        {
            throw new NotImplementedException();
        }

        public TLoaiSp Update(string MaLoai)
        {
            throw new NotImplementedException();
        }
    }
}
