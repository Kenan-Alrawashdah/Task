using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TasksEntitie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ActualCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalBudget = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksEntitie", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TasksEntitie_TasksEntitie_ParentId",
                        column: x => x.ParentId,
                        principalTable: "TasksEntitie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTaskEntity",
                columns: table => new
                {
                    EmployeesID = table.Column<int>(type: "int", nullable: false),
                    TasksEntityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTaskEntity", x => new { x.EmployeesID, x.TasksEntityID });
                    table.ForeignKey(
                        name: "FK_EmployeeTaskEntity_Employees_EmployeesID",
                        column: x => x.EmployeesID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTaskEntity_TasksEntitie_TasksEntityID",
                        column: x => x.TasksEntityID,
                        principalTable: "TasksEntitie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "CreateAt", "DeletedAt", "FirstName", "ImageUrl", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(8794), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kenan", "/Images/em1.png", "Rawashdah", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9274), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noor", "/Images/emp2.jpg", "Rawashdah", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9276), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaher", "/Images/emp5.png", "Rawashdah", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9278), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mohamad", null, "Rawashdah", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TasksEntitie",
                columns: new[] { "ID", "ActualCost", "CreateAt", "DeletedAt", "Description", "EndDate", "ParentId", "StartDate", "Status", "Title", "TotalBudget", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 7000m, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9344), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test test", new DateTime(2022, 11, 2, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9354), null, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9350), 1, "Task1", 10000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 4000m, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9357), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test test", new DateTime(2022, 11, 7, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9361), null, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9359), 0, "Task2", 11000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 5000m, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9362), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test test", new DateTime(2022, 11, 12, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9365), null, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9364), 1, "Task3", 8000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2000m, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9366), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test test", new DateTime(2022, 11, 17, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9370), null, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9369), 2, "Task4", 7000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTaskEntity",
                columns: new[] { "EmployeesID", "TasksEntityID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 4 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 1 },
                    { 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "TasksEntitie",
                columns: new[] { "ID", "ActualCost", "CreateAt", "DeletedAt", "Description", "EndDate", "ParentId", "StartDate", "Status", "Title", "TotalBudget", "UpdateAt" },
                values: new object[,]
                {
                    { 5, 3000m, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9371), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test test", new DateTime(2022, 11, 7, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9374), 1, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9373), 1, "Sub1", 6000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2500m, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9375), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test test", new DateTime(2022, 11, 2, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9378), 1, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9377), 2, "Sub2", 4000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 500m, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9384), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test test", new DateTime(2022, 10, 31, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9387), 1, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9386), 0, "Sub3", 1000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 4000m, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9411), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test test", new DateTime(2022, 11, 3, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9415), 2, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9413), 0, "Sub1", 7000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2000m, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9416), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test test", new DateTime(2022, 10, 31, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9419), 2, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9418), 1, "Sub2", 4000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 3000m, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9421), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test test", new DateTime(2022, 10, 29, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9424), 4, new DateTime(2022, 10, 28, 22, 18, 43, 691, DateTimeKind.Local).AddTicks(9423), 2, "Sub1", 7000m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTaskEntity",
                columns: new[] { "EmployeesID", "TasksEntityID" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 1, 7 },
                    { 1, 10 },
                    { 2, 5 },
                    { 2, 9 },
                    { 3, 6 },
                    { 3, 8 },
                    { 3, 9 },
                    { 4, 6 },
                    { 4, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTaskEntity_TasksEntityID",
                table: "EmployeeTaskEntity",
                column: "TasksEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_TasksEntitie_ParentId",
                table: "TasksEntitie",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTaskEntity");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "TasksEntitie");
        }
    }
}
