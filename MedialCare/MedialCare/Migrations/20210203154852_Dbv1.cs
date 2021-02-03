using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedialCare.Migrations
{
    public partial class Dbv1 : Migration
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
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false, defaultValue: 2),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JoinDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Salary = table.Column<decimal>(type: "Decimal(8,2)", nullable: false),
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
                columns: new[] { "ID", "Address", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Tu Liem, Ha Noi, Viet Name", "SIMAX", "www.simax.com" },
                    { 2, "Dong Anh, Ha Noi, Viet Name", "MAXOSI", "www.maxosi.com" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Address", "Designation", "Email", "FirstName", "Gender", "JoinDate", "LastName", "Level", "Password", "Phone", "Salary", "Username" },
                values: new object[,]
                {
                    { 1, "Thuy Bieu, Hue", "Emplopyee", "truongthanhtu.it.1998@gmail.com", "Thanh Tu", 0, new DateTime(1998, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Truong", 1, "123456", "0359077335", 230m, "Thanhtu" },
                    { 2, "Dien Ban, Quang nam", "Emplopyee", "nguyenvana@gmail.com", " Van A", 0, new DateTime(1998, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tran", 2, "123456", "0367376544", 254m, "nguyenvana" }
                });

            migrationBuilder.InsertData(
                table: "Policys",
                columns: new[] { "ID", "Amount", "CompanyId", "Description", "Emi", "Name" },
                values: new object[] { 1, 678m, 1, "Chinh sach nay danh cho nhung nhan vien moi vao cong ty, duoc ho tro tu phia cong ty len den 50%. Thoi han dang ky ke tu ngay hom nay", 67m, "Chinh sach cho nhan vien moi vao cong ty" });

            migrationBuilder.InsertData(
                table: "PolicyOnEmployees",
                columns: new[] { "ID", "EndDate", "PolicyId", "StartDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 2, 3, 22, 48, 51, 305, DateTimeKind.Local).AddTicks(9683), 1 });

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
                name: "PolicyOnEmployees");

            migrationBuilder.DropTable(
                name: "Policys");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Companys");
        }
    }
}
