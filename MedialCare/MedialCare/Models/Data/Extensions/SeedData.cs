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
                    Name= "Policy for new employees to enter the company",
                    Description= "This policy is for the new employees to enter the company, which are included in the company up to 50%. Time to register from today",
                    Amount=678,
                    Emi=67,
                },new Policy()
                {
                    ID=2,
                    CompanyId=1,
                    Name= "Employees working for 10 years in the company",
                    Description= "Employees who are 10 years old in the company will be paid full compensation by the company. Time limit for 20 years",
                    Amount=498,
                    Emi=12,
                },new Policy()
                {
                    ID=3,
                    CompanyId=3,
                    Name= "How far away",
                    Description= "As long as it is a service and a lot of people, if you realize the distance of 20 years, you will receive a call after finishing..",
                    Amount=498,
                    Emi=12,
                },new Policy()
                {
                    ID=4,
                    CompanyId=2,
                    Name= "Money for the middle man",
                    Description= "Money love policy for middle-aged people with health problems. Customers can receive free legal calls within the duration of our service.",
                    Amount=498,
                    Emi=12,
                });


        }
    }
}
