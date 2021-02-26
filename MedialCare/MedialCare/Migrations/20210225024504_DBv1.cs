using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedialCare.Migrations
{
    public partial class DBv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "041.jpg"),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "1"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "1"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RequestPolicies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    PolicyID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "1"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestPolicies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false, defaultValue: 2),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JoinDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "1"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Policys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    Emi = table.Column<decimal>(type: "money", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "1"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policys", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Policys_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PolicyOnEmployees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PolicyId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    EndDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    UpdatedAt = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "Admin"),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "1"),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyOnEmployees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PolicyOnEmployees_Policys_PolicyId",
                        column: x => x.PolicyId,
                        principalTable: "Policys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PolicyOnEmployees_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companys",
                columns: new[] { "ID", "Address", "Image", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Tu Liem, Ha Noi, Viet Name", "pexels-jonathan-meyer-668300.jpg", "SIMAX", "www.simax.com" },
                    { 2, "Dong Anh, Ha Noi, Viet Name", "pexels-photo-5327865.jpeg", "MAXOSI", "www.maxosi.com" },
                    { 3, "California, UK", "pexels-tom-fisk-1692693.jpg", "Facebook", "www.facebook.com" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Address", "Designation", "Email", "FirstName", "Gender", "Image", "JoinDate", "LastName", "Level", "Password", "Phone", "Salary", "Username" },
                values: new object[,]
                {
                    { 1, "Thuy Bieu, Hue", "Emplopyee", "truongthanhtu.it.1998@gmail.com", "Thanh Tu", 0, "133690010_890302931723740_4897017713202137858_o.jpg", new DateTime(1998, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Truong", 1, "123456", "0359077335", 230m, "Thanhtu" },
                    { 2, "Dien Ban, Quang nam", "Emplopyee", "nguyenvana@gmail.com", " Van A", 0, "", new DateTime(1998, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tran", 2, "123456", "0367376544", 254m, "nguyenvana" },
                    { 3, "Linh Dam, Ha Noi", "Developer", "vuquanghuy@gmail.com", "Quang Huy", 0, "120276334_1294841180852265_978321052909351337_o.jpg", new DateTime(2001, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vu", 1, "123456", "98372837362", 265m, "vuquanghuy" },
                    { 4, "My Dinh, Ha Noi", "Developer", "phamtuan@gmail.com", "Tuan", 0, "120812760_1010459009465475_90927199314198547_o.jpg", new DateTime(2001, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pham", 1, "123456", "98372837362", 265m, "phamtuan" },
                    { 5, "So Tay, Ha Noi", "Tester", "dothichanhoa@gmail.com", "Thi Chan Hoa", 1, "46224173_533702767097372_931079331302604800_n.jpg", new DateTime(2000, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Do", 1, "123456", "98372837362", 265m, "chanhoa" },
                    { 6, "Xuan Loc, Nghe An", "Developer", "nguyendinhhieu@gmail.com", "Dinh Hieu", 0, "133650886_3739659902806749_1154799049283951510_o.jpg", new DateTime(1996, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen ", 1, "123456", "98372837362", 265m, "nguyendinhhieu" },
                    { 7, "Long Thanh, Vinh Long", "Employee", "chaubui@gmail.com", "Chau", 1, null, new DateTime(2002, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bui ", 2, "123456", "98372837362", 265m, "chubui" },
                    { 8, "Thuy Bieu, Hue", "Employee", "caobaolong@gmail.com", "Ba Long", 1, null, new DateTime(2002, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cao", 2, "123456", "98372837362", 265m, "caobaolong" }
                });

            migrationBuilder.InsertData(
                table: "Policys",
                columns: new[] { "ID", "Amount", "CompanyId", "Description", "Emi", "Name" },
                values: new object[,]
                {
                    { 1, 678m, 1, "Chinh sach nay danh cho nhung nhan vien moi vao cong ty, duoc ho tro tu phia cong ty len den 50%. Thoi han dang ky ke tu ngay hom nay", 67m, "Chinh sach cho nhan vien moi vao cong ty" },
                    { 2, 498m, 1, "Nhung nhan vien lam tu 10 nam tro len trong cong ty thi se duoc cong ty chi tra tien bao hiem toan phan. Gio han trong vong 20 nam", 12m, "Nhan vien lam viec tu 10 nam tro len trong cong ty" },
                    { 4, 498m, 2, "Chinh sach yeu tien chon nguoi trung tien mac cac benh ve suong khop. Khach hang co the huong duoc cac goi tri lieu hoan toan mien phi trong suoc thoi gian su dung dich vu cua chung toi", 12m, "Yeu tien cho nguoi trung tien" },
                    { 3, 498m, 3, "Bao hiem xa hoi la mot nghi vu va trach nhieu cua moi nguoi dan, Neu ban thuc hien bao hiem xa hoi trong vong 20 nam thi ban se nhan duoc mot goi troi cap sau khi ket thuc.", 12m, "Bao hiem xa hoi" }
                });

            migrationBuilder.InsertData(
                table: "PolicyOnEmployees",
                columns: new[] { "ID", "EndDate", "PolicyId", "StartDate", "UserId" },
                values: new object[] { 1, new DateTime(2022, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 2, 25, 9, 45, 3, 404, DateTimeKind.Local).AddTicks(7049), 7 });

            migrationBuilder.InsertData(
                table: "PolicyOnEmployees",
                columns: new[] { "ID", "EndDate", "PolicyId", "StartDate", "UserId" },
                values: new object[] { 2, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 2, 25, 9, 45, 3, 405, DateTimeKind.Local).AddTicks(5726), 8 });

            migrationBuilder.InsertData(
                table: "PolicyOnEmployees",
                columns: new[] { "ID", "EndDate", "PolicyId", "StartDate", "UserId" },
                values: new object[] { 3, new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 2, 25, 9, 45, 3, 405, DateTimeKind.Local).AddTicks(5772), 2 });

            migrationBuilder.CreateIndex(
                name: "IX_PolicyOnEmployees_PolicyId",
                table: "PolicyOnEmployees",
                column: "PolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyOnEmployees_UserId",
                table: "PolicyOnEmployees",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Policys_CompanyId",
                table: "Policys",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedBacks");

            migrationBuilder.DropTable(
                name: "PolicyOnEmployees");

            migrationBuilder.DropTable(
                name: "RequestPolicies");

            migrationBuilder.DropTable(
                name: "Policys");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Companys");
        }
    }
}
