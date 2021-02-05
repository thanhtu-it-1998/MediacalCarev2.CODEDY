using Microsoft.EntityFrameworkCore;
using MedialCare.Models.Data.Entities;
using MedialCare.Models.Enum;
using System;
using MedialCare.Models.Entities;

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
                    Salary = 230,
                    Image= "133690010_890302931723740_4897017713202137858_o.jpg"
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
                    Salary = 254,
                    Image= ""

                },
                 new User()
                 {
                     ID = 3,
                     FirstName = "Quang Huy",
                     LastName = "Vu",
                     Address = "Linh Dam, Ha Noi",
                     Username = "vuquanghuy",
                     Password = "123456",
                     Designation = "Developer",
                     Email = "vuquanghuy@gmail.com",
                     Gender = Gender.Male,
                     JoinDate = DateTime.Parse("03-02-2001"),
                     Level = Level.Admin,
                     Phone = "98372837362",
                     Salary = 265,
                     Image= "120276334_1294841180852265_978321052909351337_o.jpg"

                 },
                 new User()
                 {
                     ID = 4,
                     FirstName = "Tuan",
                     LastName = "Pham",
                     Address = "My Dinh, Ha Noi",
                     Username = "phamtuan",
                     Password = "123456",
                     Designation = "Developer",
                     Email = "phamtuan@gmail.com",
                     Gender = Gender.Male,
                     JoinDate = DateTime.Parse("09-12-2001"),
                     Level = Level.Admin,
                     Phone = "98372837362",
                     Salary = 265,
                     Image= "120812760_1010459009465475_90927199314198547_o.jpg"

                 },new User {
                     ID = 5,
                     FirstName = "Thi Chan Hoa",
                     LastName = "Do",
                     Address = "So Tay, Ha Noi",
                     Username = "chanhoa",
                     Password = "123456",
                     Designation = "Tester",
                     Email = "dothichanhoa@gmail.com",
                     Gender = Gender.Female,
                     JoinDate = DateTime.Parse("05-04-2000"),
                     Level = Level.Admin,
                     Phone = "98372837362",
                     Salary = 265,
                     Image= "46224173_533702767097372_931079331302604800_n.jpg"
                 },new User {
                     ID = 6,
                     FirstName = "Dinh Hieu",
                     LastName = "Nguyen ",
                     Address = "Xuan Loc, Nghe An",
                     Username = "nguyendinhhieu",
                     Password = "123456",
                     Designation = "Developer",
                     Email = "nguyendinhhieu@gmail.com",
                     Gender = Gender.Male,
                     JoinDate = DateTime.Parse("01-03-1996"),
                     Level = Level.Admin,
                     Phone = "98372837362",
                     Salary = 265,
                     Image= "133650886_3739659902806749_1154799049283951510_o.jpg"
                 },
                 new User {
                     ID = 7,
                     FirstName = "Chau",
                     LastName = "Bui ",
                     Address = "Long Thanh, Vinh Long",
                     Username = "chubui",
                     Password = "123456",
                     Designation = "Employee",
                     Email = "chaubui@gmail.com",
                     Gender = Gender.Female,
                     JoinDate = DateTime.Parse("01-03-2002"),
                     Level = Level.Employee,
                     Phone = "98372837362",
                     Salary = 265
                 },
                 new User {
                     ID = 8,
                     FirstName = "Ba Long",
                     LastName = "Cao",
                     Address = "Thuy Bieu, Hue",
                     Username = "caobaolong",
                     Password = "123456",
                     Designation = "Employee",
                     Email = "caobaolong@gmail.com",
                     Gender = Gender.Female,
                     JoinDate = DateTime.Parse("01-03-2002"),
                     Level = Level.Employee,
                     Phone = "98372837362",
                     Salary = 265,
                 }
                );
            modelBuilder.Entity<Company>().HasData(

                new Company()
                {
                    ID = 1,
                    Address = "Tu Liem, Ha Noi, Viet Name",
                    Name = "SIMAX",
                    Url = "www.simax.com",
                    Image = "pexels-jonathan-meyer-668300.jpg"

                },
                new Company()
                {
                    ID = 2,
                    Address = "Dong Anh, Ha Noi, Viet Name",
                    Name = "MAXOSI",
                    Url = "www.maxosi.com",
                    Image = "pexels-photo-5327865.jpeg"
                },
                new Company()
                {
                    ID = 3,
                    Address = "California, UK",
                    Name = "Facebook",
                    Url = "www.facebook.com",
                    Image = "pexels-tom-fisk-1692693.jpg"

                });
            modelBuilder.Entity<PolicyOnEmployee>().HasData(
                new PolicyOnEmployee()
                {
                    ID=1,
                    PolicyId=1,
                    UserId=7,
                    StartDate= DateTime.Now,
                    EndDate = DateTime.Parse("07-06-2022"),
                    Status = Status.Request,
                }, new PolicyOnEmployee()
                {
                    ID=2,
                    PolicyId=1,
                    UserId=8,
                    StartDate= DateTime.Now,
                    EndDate = DateTime.Parse("02-01-2024"),
                    Status = Status.Request,
                }, new PolicyOnEmployee()
                {
                    ID=3,
                    PolicyId=1,
                    UserId=2,
                    StartDate= DateTime.Now,
                    EndDate = DateTime.Parse("09-05-2021"),
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
                },new Policy()
                {
                    ID=2,
                    CompanyId=1,
                    Name="Nhan vien lam viec tu 10 nam tro len trong cong ty",
                    Description="Nhung nhan vien lam tu 10 nam tro len trong cong ty thi se duoc cong ty chi tra tien bao hiem toan phan. Gio han trong vong 20 nam",
                    Amount=498,
                    Emi=12,
                },new Policy()
                {
                    ID=3,
                    CompanyId=3,
                    Name="Bao hiem xa hoi",
                    Description="Bao hiem xa hoi la mot nghi vu va trach nhieu cua moi nguoi dan, Neu ban thuc hien bao hiem xa hoi trong vong 20 nam thi ban se nhan duoc mot goi troi cap sau khi ket thuc.",
                    Amount=498,
                    Emi=12,
                },new Policy()
                {
                    ID=4,
                    CompanyId=2,
                    Name="Yeu tien cho nguoi trung tien",
                    Description="Chinh sach yeu tien chon nguoi trung tien mac cac benh ve suong khop. Khach hang co the huong duoc cac goi tri lieu hoan toan mien phi trong suoc thoi gian su dung dich vu cua chung toi",
                    Amount=498,
                    Emi=12,
                });


        }
    }
}
