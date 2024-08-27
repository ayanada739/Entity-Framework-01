using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Framework_01.Migrations
{
    public partial class Migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "departments",
                newName: "DeptId");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentDeptId",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCreation",
                table: "departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_employees_DepartmentDeptId",
                table: "employees",
                column: "DepartmentDeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_DepartmentDeptId",
                table: "employees",
                column: "DepartmentDeptId",
                principalTable: "departments",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_DepartmentDeptId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_DepartmentDeptId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "DepartmentDeptId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "DateOfCreation",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "departments");

            migrationBuilder.RenameColumn(
                name: "DeptId",
                table: "departments",
                newName: "DepartmentId");
        }
    }
}
