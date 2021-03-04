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
                    Image = "133690010_890302931723740_4897017713202137858_o.jpg"
                },
                new User()
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
                    Image = ""

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
                     Image = "120276334_1294841180852265_978321052909351337_o.jpg"

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
                     Image = "120812760_1010459009465475_90927199314198547_o.jpg"

                 },
                 new User
                 {
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
                     Image = "46224173_533702767097372_931079331302604800_n.jpg"
                 },
                 new User
                 {
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
                     Image = "133650886_3739659902806749_1154799049283951510_o.jpg"
                 },
                 new User
                 {
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
                 new User
                 {
                     ID = 9,
                     FirstName = "Tuan",
                     LastName = "Pham ",
                     Address = "Thai Nguyen",
                     Username = "tuanpham20",
                     Password = "123456",
                     Designation = "Employee",
                     Email = "phamtuancules20@gmail.com",
                     Gender = Gender.Male,
                     JoinDate = DateTime.Parse("01-03-2002"),
                     Level = Level.Employee,
                     Phone = "98372837362",
                     Salary = 20
                 },
                 new User
                 {
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
            modelBuilder.Entity<EmailFormModel>().HasData(
                new EmailFormModel()
                {
                    ID = 1,
                    UserID = 9,
                    PolicyID = 1,
                    Status = Status.Request
                },
                new EmailFormModel()
                {
                ID = 2,
                    UserID = 1,
                    PolicyID = 2,
                    Status = Status.Request
                },
                new EmailFormModel()
                {
                ID = 3,
                    UserID = 3,
                    PolicyID = 3,
                    Status = Status.Request
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

                },

            new Company()
            {
                ID = 4,
                Address = "Tokyo,Japan",
                Name = "ASIP",
                Url = "www.ASIP.com",
                Image = "Company1.jpg"

            },
             new Company()
             {
                 ID = 5,
                 Address = "Ha Noi, VietNam",
                 Name = "DAICHI",
                 Url = "www.DAICHI.com",
                 Image = "Company2.jpg"

             },
              new Company()
              {
                  ID = 6,
                  Address = "Kyoto, Japan",
                  Name = "AIICHI",
                  Url = "www.AIICHI.com",
                  Image = "Company3.jpg"

              },
               new Company()
               {
                   ID = 7,
                   Address = "Osaka, Japan",
                   Name = "COPAN",
                   Url = "www.copan.com",
                   Image = "Company4.jpg"

               },
                new Company()
                {
                    ID = 8,
                    Address = "Da NANG, VIET NAM",
                    Name = "ACOCO",
                    Url = "www.acoco.com",
                    Image = "Company5.jpg"

                },
                 new Company()
                 {
                     ID = 9,
                     Address = "OSAKA, JAPAN",
                     Name = "YAMA",
                     Url = "www.yama.com",
                     Image = "Company6.jpg"

                 },
                  new Company()
                  {
                      ID = 10,
                      Address = "YAMAGUCHI",
                      Name = "SAKURA",
                      Url = "www.sakura.com",
                      Image = "Company7.jpg"

                  },
                   new Company()
                   {
                       ID = 11,
                       Address = "DA LAT, VIET NAM",
                       Name = "MARDRI",
                       Url = "www.mardri.com",
                       Image = "Company8.jpg"

                   },
                    new Company()
                    {
                        ID = 12,
                        Address = "SEOUL,KOREA",
                        Name = "HOLDING",
                        Url = "www.holding.com",
                        Image = "Company9.jpg"

                    });
            modelBuilder.Entity<PolicyOnEmployee>().HasData(
                new PolicyOnEmployee()
                {
                    ID = 1,
                    PolicyId = 1,
                    UserId = 7,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Parse("07-06-2022"),
                    Status = Status.Request,
                }, new PolicyOnEmployee()
                {
                    ID = 2,
                    PolicyId = 1,
                    UserId = 8,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Parse("02-01-2024"),
                    Status = Status.Request,
                }, new PolicyOnEmployee()
                {
                    ID = 3,
                    PolicyId = 1,
                    UserId = 2,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Parse("09-05-2021"),
                    Status = Status.Request,
                });
            modelBuilder.Entity<Policy>().HasData(
                new Policy()
                {
                    ID = 1,
                    CompanyId = 1,
                    Name = "Policy for new employees to enter the company",
                    Description = "This policy is for the new employees to enter the company, which are included in the company up to 50%. Time to register from today",
                    Amount = 678,
                    Emi = 67,
                },
                new Policy()
                {
                    ID = 2,
                    CompanyId = 1,
                    Name = "Employees working for 10 years in the company",
                    Description = "Employees who are 10 years old in the company will be paid full compensation by the company. Time limit for 20 years",
                    Amount = 498,
                    Emi = 12,
                },
                new Policy()
                {
                    ID = 3,
                    CompanyId = 1,
                    Name = "Employees working for 10 years in the company",
                    Description = "Employees who are 10 years old in the company will be paid full compensation by the company. Time limit for 20 years",
                    Amount = 498,
                    Emi = 12,
                },
                new Policy()
                {
                    ID = 4,
                    CompanyId = 2,
                    Name = "Finibus Bonorum et Malorum",
                    Description = "Our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided. But in certain circumstances and owing to the claims of duty or the obligations of business it will frequently occur",
                    Amount = 675,
                    Emi = 124,
                },
                new Policy()
                {
                    ID = 5,
                    CompanyId = 2,
                    Name = "Contrary to popular belief",
                    Description = "It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old",
                    Amount = 560,
                    Emi = 50,
                },
                 new Policy()
                 {
                     ID = 6,
                     CompanyId = 2,
                     Name = "Richard McClintock, a Latin professor ",
                     Description = "Looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage",
                     Amount = 660,
                     Emi = 50,
                 },
                  new Policy()
                  {
                      ID = 7,
                      CompanyId = 2,
                      Name = " At Hampden-Sydney College in Virginia",
                      Description = "Going through the cites of the word in classical literature, discovered the undoubtable source",
                      Amount = 700,
                      Emi = 50,
                  },
                   new Policy()
                   {
                       ID = 8,
                       CompanyId = 2,
                       Name = "This book is a treatise on the theory of ethics,",
                       Description = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33",
                       Amount = 330,
                       Emi = 40,
                   },
                   new Policy()
                   {
                       ID = 9,
                       CompanyId = 3,
                       Name = "It is a long established fact that a reader will be distracted",
                       Description = "By the readable content of a page when looking at its layout. The point of using",
                       Amount = 220,
                       Emi = 35,
                   },
                   new Policy()
                   {
                       ID = 10,
                       CompanyId = 3,
                       Name = "This book is a treatise on the theory of ethics,",
                       Description = "The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33",
                       Amount = 330,
                       Emi = 40,
                   },
                   new Policy()
                   {
                       ID = 11,
                       CompanyId = 3,
                       Name = "That it has a more-or-less normal distribution of letters,",
                       Description = "As opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages",
                       Amount = 330,
                       Emi = 40,
                   },
                    new Policy()
                    {
                        ID = 12,
                        CompanyId = 3,
                        Name = "Web page editors now use Lorem Ipsum as their default model text",
                        Description = "And a search for 'lorem ipsum' will uncover many web sites still in their infancy.",
                        Amount = 220,
                        Emi = 20,
                    },
                     new Policy()
                     {
                         ID = 13,
                         CompanyId = 3,
                         Name = "Various versions have evolved over the years, sometimes by accident",
                         Description = "Various versions have evolved over the years, sometimes by accident, sometimes on purpose",
                         Amount = 444,
                         Emi = 33,
                     },
                     new Policy()
                     {
                         ID = 14,
                         CompanyId = 4,
                         Name = "Contrary to popular belief",
                         Description = " Simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.",
                         Amount = 434,
                         Emi = 34,
                     },
                      new Policy()
                      {
                          ID = 15,
                          CompanyId = 4,
                          Name = "Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia",
                          Description = "looked up one of the more obscure Latin words, consectetur, from a",
                          Amount = 446,
                          Emi = 35,
                      },
                       new Policy()
                       {
                           ID = 16,
                           CompanyId = 4,
                           Name = "And going through the cites of the word in classical literature",
                           Description = "Discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC",
                           Amount = 447,
                           Emi = 37,
                       },
                        new Policy()
                        {
                            ID = 17,
                            CompanyId = 4,
                            Name = "Very popular during the Renaissance.",
                            Description = "Various versions have evolved over the years, sometimes by accident, sometimes on purpose",
                            Amount = 500,
                            Emi = 34,
                        },
                         new Policy()
                         {
                             ID = 18,
                             CompanyId = 4,
                             Name = "Reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                             Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                             Amount = 550,
                             Emi = 55,
                         },
                          new Policy()
                          {
                              ID = 19,
                              CompanyId = 5,
                              Name = "Dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ",
                              Description = "  Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                              Amount = 557,
                              Emi = 56,
                          },
                           new Policy()
                           {
                               ID = 20,
                               CompanyId = 5,
                               Name = "Duis aute irure dolor in reprehenderit in voluptate velit esse ",
                               Description = " Irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident.",
                               Amount = 558,
                               Emi = 59,
                           },
                            new Policy()
                            {
                                ID = 21,
                                CompanyId = 5,
                                Name = "Sunt in culpa qui officia deserunt mollit anim id est laborum.",
                                Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                                Amount = 600,
                                Emi = 58,
                            },
                             new Policy()
                             {
                                 ID = 22,
                                 CompanyId = 5,
                                 Name = "Section 1.10.32 of \"de Finibus Bonorum et Malorum\", written by Cicero in 45 BC",
                                 Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo.",
                                 Amount = 564,
                                 Emi = 45,
                             },

                               new Policy()
                               {
                                   ID = 23,
                                   CompanyId = 6,
                                   Name = "Sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem.",
                                   Description = "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur.",
                                   Amount = 578,
                                   Emi = 54,
                               },
                                new Policy()
                                {
                                    ID = 24,
                                    CompanyId = 6,
                                    Name = "Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil.",
                                    Description = "autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur.",
                                    Amount = 544,
                                    Emi = 51,
                                },
                                 new Policy()
                                 {
                                     ID = 25,
                                     CompanyId = 6,
                                     Name = "1914 translation by H. Rackham.",
                                     Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system.",
                                     Amount = 589,
                                     Emi = 56,
                                 },
                                  new Policy()
                                  {
                                      ID = 26,
                                      CompanyId = 6,
                                      Name = "Expound the actual teachings of the great explorer of the truth, the master-builder of human happiness.",
                                      Description = "No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure.",
                                      Amount = 590,
                                      Emi = 58,
                                  },
                                   new Policy()
                                   {
                                       ID = 27,
                                       CompanyId = 6,
                                       Name = "Rationally encounter consequences that are extremely painful.",
                                       Description = " Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure.",
                                       Amount = 577,
                                       Emi = 56,
                                   },
                                   new Policy()
                                   {
                                       ID = 28,
                                       CompanyId = 7,
                                       Name = "To take a trivial example, which of us ever undertakes laborious physical exercise.",
                                       Description = "Except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences.",
                                       Amount = 578,
                                       Emi = 100,
                                   },
                                   new Policy()
                                   {
                                       ID = 29,
                                       CompanyId = 7,
                                       Name = "Section 1.10.33 of \"de Finibus Bonorum et Malorum\", written by Cicero in 45 BC.",
                                       Description = " At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident.",
                                       Amount = 585,
                                       Emi = 130,
                                   },
                                   new Policy()
                                   {
                                       ID = 30,
                                       CompanyId = 7,
                                       Name = "similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.",
                                       Description = "Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus.",
                                       Amount = 586,
                                       Emi = 131,
                                   },
                                    new Policy()
                                    {
                                        ID = 31,
                                        CompanyId = 7,
                                        Name = "Minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus.",
                                        Description = "Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae.",
                                        Amount = 547,
                                        Emi = 79,
                                    },
                                     new Policy()
                                     {
                                         ID = 32,
                                         CompanyId = 7,
                                         Name = "Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur.",
                                         Description = "Omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat.",
                                         Amount = 577,
                                         Emi = 56,
                                     },
                                     new Policy()
                                     {
                                         ID = 33,
                                         CompanyId = 8,
                                         Name = "Minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus.",
                                         Description = "Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae.",
                                         Amount = 547,
                                         Emi = 79,
                                     },
                                     new Policy()
                                     {
                                         ID = 34,
                                         CompanyId = 8,
                                         Name = "On the other hand, we denounce with righteous indignation and dislike men who are so beguiled .",
                                         Description = "Who are so beguiled and demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain.",
                                         Amount = 678,
                                         Emi = 88,
                                     },
                                     new Policy()
                                     {
                                         ID = 35,
                                         CompanyId = 8,
                                         Name = "Trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will.",
                                         Description = "Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae.",
                                         Amount = 522,
                                         Emi = 90,
                                     },
                                    new Policy()
                                    {
                                        ID = 36,
                                        CompanyId = 8,
                                        Name = "Their duty through weakness of will, which is the same as saying through shrinking from toil and pain.",
                                        Description = "These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents.",
                                        Amount = 522,
                                        Emi = 33,
                                    },
                                    new Policy()
                                    {
                                        ID = 37,
                                        CompanyId = 9,
                                        Name = "The wise man therefore always holds in these matters to this principle of selection.",
                                        Description = "Holds in these matters to this principle of selection: he rejects pleasures to secure other greater pleasures, or else he endures pains to avoid worse pains.",
                                        Amount = 367,
                                        Emi = 110,
                                    },
                                     new Policy()
                                     {
                                         ID = 38,
                                         CompanyId = 9,
                                         Name = "Insurance is a contract, represented by a policy, in which an individual or entity receives financial protection or reimbursement against.",
                                         Description = "Against losses from an insurance company. The company pools clients' risks to make payments more affordable for the insured.",
                                         Amount = 611,
                                         Emi = 98,
                                     },
                                      new Policy()
                                      {
                                          ID = 39,
                                          CompanyId = 9,
                                          Name = "Insurance policies are used to hedge against the risk of financial losses, both big and small, that may result from damage to the insured or her property.",
                                          Description = "There is a multitude of different types of insurance policies available, and virtually any individual or business can find an insurance company willing to insure them—for a price. The most common types of personal insurance policies are auto.",
                                          Amount = 666,
                                          Emi = 121,
                                      },
                                       new Policy()
                                       {
                                           ID = 40,
                                           CompanyId = 9,
                                           Name = "The most common types of personal insurance policies are auto, health, homeowners, and life.",
                                           Description = "Most individuals in the United States have at least one of these types of insurance, and car insurance is required by law.",
                                           Amount = 412,
                                           Emi = 63,
                                       },
                                        new Policy()
                                        {
                                            ID = 41,
                                            CompanyId = 9,
                                            Name = "Businesses require special types of insurance policies that insure against specific types of risks faced by a particular business.",
                                            Description = "For example, a fast-food restaurant needs a policy that covers damage or injury that occurs as a result of cooking with a deep fryer.",
                                            Amount = 663,
                                            Emi = 69,
                                        },
                                         new Policy()
                                         {
                                             ID = 42,
                                             CompanyId = 10,
                                             Name = "Insurance Policy Components.",
                                             Description = "When choosing a policy, it is important to understand how insurance works.A firm understanding of these concepts goes a long way in helping you choose the policy that best suits your needs.",
                                             Amount = 234,
                                             Emi = 99,
                                         },
                                          new Policy()
                                          {
                                              ID = 43,
                                              CompanyId = 10,
                                              Name = " For instance, whole life insurance may or may not be the right type of life insurance for you.",
                                              Description = " The right type of life insurance for you. There are three components of any type of insurance (premium, policy limit, and deductible) that are crucial..",
                                              Amount = 345,
                                              Emi = 140,
                                          },
                                           new Policy()
                                           {
                                               ID = 44,
                                               CompanyId = 10,
                                               Name = "A policy's premium is its price, typically expressed as a monthly cost.",
                                               Description = "The premium is determined by the insurer based on your or your business's risk profile, which may include creditworthiness..",
                                               Amount = 456,
                                               Emi = 125,
                                           },
                                            new Policy()
                                            {
                                                ID = 45,
                                                CompanyId = 10,
                                                Name = "For example, if you own several expensive automobiles and have a history of reckless driving, you will likely pay more for an auto policy than someone.",
                                                Description = "With a single mid-range sedan and a perfect driving record. However, different insurers may charge different premiums for similar policies.",
                                                Amount = 324,
                                                Emi = 118,
                                            },
                                             new Policy()
                                             {
                                                 ID = 46,
                                                 CompanyId = 10,
                                                 Name = "The policy limit is the maximum amount an insurer will pay under a policy for a covered loss.",
                                                 Description = "Maximums may be set per period (e.g., annual or policy term), per loss or injury, or over the life of the policy, also known as the lifetime maximum..",
                                                 Amount = 445,
                                                 Emi = 122,
                                             },
                                              new Policy()
                                              {
                                                  ID = 47,
                                                  CompanyId = 11,
                                                  Name = "Typically, higher limits carry higher premiums.",
                                                  Description = " For a general life insurance policy, the maximum amount the insurer will pay is referred to as the face value, which is the amount paid to a beneficiary upon the death of the insured.",
                                                  Amount = 234,
                                                  Emi = 129,
                                              },
                                               new Policy()
                                               {
                                                   ID = 48,
                                                   CompanyId = 11,
                                                   Name = "The deductible is a specific amount the policy-holder must pay out-of-pocket.",
                                                   Description = "Before the insurer pays a claim. Deductibles serve as deterrents to large volumes of small and insignificant claims.",
                                                   Amount = 567,
                                                   Emi = 59,
                                               },
                                                new Policy()
                                                {
                                                    ID = 49,
                                                    CompanyId = 11,
                                                    Name = "Deductibles can apply per-policy or per-claim depending on the insurer and the type of policy.",
                                                    Description = "Policies with very high deductibles are typically less expensive because the high out-of-pocket expense generally results in fewer small claims.",
                                                    Amount = 495,
                                                    Emi = 182,
                                                },
                                                 new Policy()
                                                 {
                                                     ID = 50,
                                                     CompanyId = 11,
                                                     Name = "Special Considerations.",
                                                     Description = "With regard to health insurance, people who have chronic health issues or need regular medical attention should look for policies with lower deductibles.",
                                                     Amount = 367,
                                                     Emi = 172,
                                                 },
                                                  new Policy()
                                                  {
                                                      ID = 51,
                                                      CompanyId = 11,
                                                      Name = "Though the annual premium is higher than a comparable policy.",
                                                      Description = "With a higher deductible, less expensive access to medical care throughout the year may be worth the trade-off.",
                                                      Amount = 290,
                                                      Emi = 142,
                                                  },
                                                   new Policy()
                                                   {
                                                       ID = 52,
                                                       CompanyId = 12,
                                                       Name = "Compete Risk Free with $100,000 in Virtual Cash.",
                                                       Description = "Put your trading skills to the test with our FREE Stock Simulator. Compete with thousands of Investopedia traders and trade your way to the top!.",
                                                       Amount = 567,
                                                       Emi = 187,
                                                   },
                                                    new Policy()
                                                    {
                                                        ID = 53,
                                                        CompanyId = 12,
                                                        Name = "Submit trades in a virtual environment before you start risking your own money.",
                                                        Description = "Practice trading strategies so that when you're ready to enter the real market, you've had the practice you need. Try our Stock Simulator today.",
                                                        Amount = 332,
                                                        Emi = 222,
                                                    },
                                                     new Policy()
                                                     {
                                                         ID = 54,
                                                         CompanyId = 12,
                                                         Name = "Water Damage Legal Liability Insurance Definition.",
                                                         Description = "Water damage legal liability insurance provides financial protection to a person or business that causes water damage to the property of another.",
                                                         Amount = 485,
                                                         Emi = 152,
                                                     },
                                                      new Policy()
                                                      {
                                                          ID = 55,
                                                          CompanyId = 12,
                                                          Name = "World insurance protects firms from being sued by an international plaintiff.",
                                                          Description = "Insurance coverage is the amount of risk or liability covered for an individual or entity by way of insurance services",
                                                          Amount = 369,
                                                          Emi = 112,
                                                      },
                                                       new Policy()
                                                       {
                                                           ID = 56,
                                                           CompanyId = 12,
                                                           Name = "Combined physical damage coverage is a type of auto insurance that covers various causes of damage in addition to collisions.",
                                                           Description = "Watercraft insurance encompasses boat, yacht, and personal watercraft insurance. It protects against damage to vessels powered by a motor..",
                                                           Amount = 464,
                                                           Emi = 234,
                                                       },
                                                        new Policy()
                                                        {
                                                            ID = 57,
                                                            CompanyId = 12,
                                                            Name = "Comprehensive physical damage coverage protects policyholders.",
                                                            Description = "The insurance company will repair or replace a vehicle damaged in a collision. The consumer may agree to pay a higher deductible in order to lower the monthly premium..",
                                                            Amount = 489,
                                                            Emi = 178,
                                                        });



        }
    }
}
