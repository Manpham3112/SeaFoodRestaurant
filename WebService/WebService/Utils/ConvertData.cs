using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.model;
using WebService.ViewModel;

namespace WebService.Utils
{
    public static class ConvertData
    {
        public static CT_PhieuDatHangVM ConvertCT_PhieuDatHang(CT_PHIEUDATHANG CT_PDH)
        {
            CT_PhieuDatHangVM ct = new CT_PhieuDatHangVM();
            ct.MaPDH = CT_PDH.MAPDH;
            ct.MaSP = CT_PDH.MASP;
            ct.SoLuong = CT_PDH.SOLUONG;
            return ct;
        }
        public static PhieuDatHangVM ConvertPhieuDatHang(PHIEUDATHANG PDH)
        {
            PhieuDatHangVM ct = new PhieuDatHangVM();
            ct.MaPDH = PDH.MAPDH;
            ct.MaKH = PDH.MAKH;
            ct.MaNV = PDH.MANV;
            ct.MaDV = PDH.MADV;
            ct.NgayLap = PDH.NGAYLAP;
            return ct;
        }
        public static DichVuVM ConvertDichVu(DICHVU DV)
        {
            DichVuVM ct = new DichVuVM();
            ct.MaDV = DV.MADV;
            ct.TenDV = DV.TENDV;
            ct.MoTa = DV.MOTA;
            ct.GiaDV = DV.GIADV;
            ct.Anh = DV.ANH;
            ct.TrangThai = DV.TRANGTHAI;
            return ct;
        }
        public static KhachHangVM ConvertKhachHang(KHACHHANG DV)
        {
            KhachHangVM ct = new KhachHangVM();
            ct.MaKH = DV.MAKH;
            ct.TenKH = DV.TENKH;
            ct.DiaChi = DV.DIACHI;
            ct.SDT = DV.SDT;
            ct.TaiKhoan = DV.TAIKHOAN;
            ct.MatKhau = DV.MATKHAU;
            return ct;
        }
        public static SanPhamVM ConvertSanPham(SANPHAM DV)
        {
            SanPhamVM ct = new SanPhamVM();
            ct.MaSP = DV.MASP;
            ct.TenSP = DV.TENSP;
            ct.HinhAnh = DV.HINHANH;
            ct.GiaBan = DV.GIABAN;
            ct.TrangThai = DV.TRANGTHAI;
            ct.MaLSP = DV.MALSP;
            return ct;
        }

        public static LoaiSanPhamVM ConvertLoaiSP(LOAISP loaiSP)
        {
            LoaiSanPhamVM _loaiSP = new LoaiSanPhamVM();
            _loaiSP.maLoaiSP = loaiSP.MALSP;
            _loaiSP.tenLoaiSP = loaiSP.TENLSP;
            return _loaiSP;
        }
    }
}