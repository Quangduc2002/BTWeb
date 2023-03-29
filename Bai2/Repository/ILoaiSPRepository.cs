using Bai2.Models;
namespace Bai2.Repository
{
    public interface ILoaiSPRepository
    {
        TLoaiSp Add(TLoaiSp loaisp);
        TLoaiSp Update(string MaLoai); 
        TLoaiSp Delete(string MaLoai);
        TLoaiSp GetLoaiSp(string MaLoai);
        IEnumerable<TLoaiSp> GetAllLoaiSp();
    }
}
