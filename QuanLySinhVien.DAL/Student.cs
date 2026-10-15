using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.DAL
{
    public class Student
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public int Grade { get; set; }
    }
}