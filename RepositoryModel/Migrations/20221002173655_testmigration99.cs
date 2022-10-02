using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryModel.Migrations
{
    public partial class testmigration99 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTable",
                table: "UserTable");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "UserTable");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "UserTable");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserTable");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "UserTable");

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "UserTable",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "EmailID",
                table: "UserTable",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "UserTable",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTable",
                table: "UserTable",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTable",
                table: "UserTable");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserTable");

            migrationBuilder.DropColumn(
                name: "EmailID",
                table: "UserTable");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "UserTable");

            migrationBuilder.AddColumn<long>(
                name: "EmployeeId",
                table: "UserTable",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "UserTable",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "UserTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTable",
                table: "UserTable",
                column: "EmployeeId");
        }
    }
}
