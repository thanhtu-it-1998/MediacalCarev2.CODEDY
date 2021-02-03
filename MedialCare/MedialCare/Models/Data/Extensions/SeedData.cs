using Microsoft.EntityFrameworkCore;
using MedialCare.Models.Entities;
using MedialCare.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Models.Extensions
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    ID = 1,
                    FirstName = "Thanh Tu",
                    LastName = "Truong",
                    Address = "Thuy Bieu, Hue",
                    Username = "Thanhtu",
                    Password = "123456",
                    Designation = "Emplopyee",
                    Email = "truongthanhtu.it.1998@gmail.com",
                    Gender = Gender.Male,
                    JoinDate = DateTime.Parse("03-09-1998"),
                    Level = Level.Admin,
                    Phone = "0359077335",
                    Salary = 230
                },  new User()
                {
                    ID = 2,
                    FirstName = " Van A",
                    LastName = "Tran",
                    Address = "Dien Ban, Quang nam",
                    Username = "nguyenvana",
                    Password = "123456",
                    Designation = "Emplopyee",
                    Email = "nguyenvana@gmail.com",
                    Gender = Gender.Male,
                    JoinDate = DateTime.Parse("03-09-1998"),
                    Level = Level.Employee,
                    Phone = "0367376544",
                    Salary = 254
                }
                );
            modelBuilder.Entity<Company>().HasData(

                new Company()
                {
                    ID = 1,
                    Address = "Tu Liem, Ha Noi, Viet Name",
                    Name = "SIMAX",
                    Url = "www.simax.com"
                },
                new Company()
                {
                    ID = 2,
                    Address = "Dong Anh, Ha Noi, Viet Name",
                    Name = "MAXOSI",
                    Url = "www.maxosi.com"
                });
            modelBuilder.Entity<PolicyOnEmployee>().HasData(
                new PolicyOnEmployee()
                {
                    ID=1,
                    PolicyId=1,
                    UserId=1,
                    StartDate= DateTime.Now,
                    EndDate = DateTime.Parse("03-05-2021"),
                    Status = Status.Request,
                });
            modelBuilder.Entity<Policy>().HasData(
                new Policy()
                {
                    ID=1,
                    CompanyId=1,
                    Name="Chinh sach cho nhan vien moi vao cong ty",
                    Description="Chinh sach nay danh cho nhung nhan vien moi vao cong ty, duoc ho tro tu phia cong ty len den 50%. Thoi han dang ky ke tu ngay hom nay",
                    Amount=678,
                    Emi=67,
                });


        }
    }
}
