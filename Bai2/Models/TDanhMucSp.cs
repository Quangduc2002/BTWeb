using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bai2.Models;

public partial class TDanhMucSp
{
    public string MaSp { get; set; } = null!;
    [Display(Name = "Tên sản phẩm: ")]
    [RegularExpression(@"^[a-zA-Z]([._-]?[a-zA-Z0-9]+)*$" ,ErrorMessage = "Tên sản phẩm bắt đầu bằng chữ cái")]
    public string? TenSp { get; set; }

    public string? MaChatLieu { get; set; }

    public string? NganLapTop { get; set; }

    public string? Model { get; set; }

    public double? CanNang { get; set; }

    public double? DoNoi { get; set; }

    public string? MaHangSx { get; set; }

    public string? MaNuocSx { get; set; }

    public string? MaDacTinh { get; set; }

    public string? Website { get; set; }

    public double? ThoiGianBaoHanh { get; set; }

    public string? GioiThieuSp { get; set; }

    public double? ChietKhau { get; set; }

    public string? MaLoai { get; set; }

    public string? MaDt { get; set; }
    [FileExtensions(Extensions = "jpg,png,jpeg", ErrorMessage = "Nhập sai định dạng file")]

    public string? AnhDaiDien { get; set; }

    public decimal? GiaNhoNhat { get; set; }

    public decimal? GiaLonNhat { get; set; }

    public virtual TChatLieu? MaChatLieuNavigation { get; set; }

    public virtual TLoaiDt? MaDtNavigation { get; set; }

    public virtual THangSx? MaHangSxNavigation { get; set; }

    public virtual TLoaiSp? MaLoaiNavigation { get; set; }

    public virtual TQuocGia? MaNuocSxNavigation { get; set; }

    public virtual ICollection<TAnhSp> TAnhSps { get; } = new List<TAnhSp>();

    public virtual ICollection<TChiTietSanPham> TChiTietSanPhams { get; } = new List<TChiTietSanPham>();
}
