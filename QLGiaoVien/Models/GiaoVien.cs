namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaoVien")]
    public partial class GiaoVien
    {
        public long Id { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name="Họ và tên")]
        public string HovaTen { get; set; }
        [Display(Name = "Giới tính")]

        public bool GioiTinh { get; set; }

        [StringLength(200)]
        [Display(Name = "Email")]
        public string Email { get; set; }
       

        [StringLength(20)]
        [Display(Name = "Số Điện Thoại")]
        public string SoDienThoai { get; set; }


        [StringLength(200)]
        [Display(Name = "Số Căn Cước")]
        public string SoCanCuoc { get; set; }

        [StringLength(200)]
        [Display(Name = "Tên Đăng Nhập")]
        public string TenDangNhap { get; set; }

        [StringLength(200)]
        [Display(Name = "Mật Khẩu")]
        public string MatKhau { get; set; }
        [Display(Name = "Chức Vụ")]
        public long? IdChucVu { get; set; }
        [Display(Name = "Là Quản Trị Viên")]
        public bool LaQuanTri { get; set; }
        [Display(Name = "Là Chuyên Viên")]
        public bool LaChuyenVien { get; set; }
        [Display(Name = "Là Giáo Viên")]
        public bool LaGiaoVien { get; set; }

        public virtual ChucVu ChucVu { get; set; }
    }
}
