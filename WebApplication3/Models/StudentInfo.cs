using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class StudentInfo
    {
        [DisplayName("Mã sinh viên")]
        public string Id { get; set; }

        [DisplayName("Mật khẩu"), DataType(DataType.Password)]
        public string Pwd { get; set; }

        [DisplayName("Họ tên")]
        public string Name { get; set; }

        [DisplayName("Ảnh đại diện")]
        public string Avatar { get; set; }

        [DisplayName("Ngay sinh")]
        public string BirthDay { get; set; }
        
        [DisplayName("Điểm sinh viên")]
        public string Mark { get; set; }
        [DisplayName("Ghi chu"), DataType(DataType.MultilineText)]
        public string Note { get; set; }
        
    }
}