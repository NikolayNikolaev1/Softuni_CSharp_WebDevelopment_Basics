﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentSystem.Migrations
{
    public partial class HomeworkNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkSubmissions_Courses_CourseId",
                table: "HomeworkSubmissions");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkSubmissions_Students_StudentId",
                table: "HomeworkSubmissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HomeworkSubmissions",
                table: "HomeworkSubmissions");

            migrationBuilder.RenameTable(
                name: "HomeworkSubmissions",
                newName: "Homeworks");

            migrationBuilder.RenameIndex(
                name: "IX_HomeworkSubmissions_StudentId",
                table: "Homeworks",
                newName: "IX_Homeworks_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_HomeworkSubmissions_CourseId",
                table: "Homeworks",
                newName: "IX_Homeworks_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Homeworks",
                table: "Homeworks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_Courses_CourseId",
                table: "Homeworks",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_Students_StudentId",
                table: "Homeworks",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_Courses_CourseId",
                table: "Homeworks");

            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_Students_StudentId",
                table: "Homeworks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Homeworks",
                table: "Homeworks");

            migrationBuilder.RenameTable(
                name: "Homeworks",
                newName: "HomeworkSubmissions");

            migrationBuilder.RenameIndex(
                name: "IX_Homeworks_StudentId",
                table: "HomeworkSubmissions",
                newName: "IX_HomeworkSubmissions_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Homeworks_CourseId",
                table: "HomeworkSubmissions",
                newName: "IX_HomeworkSubmissions_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomeworkSubmissions",
                table: "HomeworkSubmissions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkSubmissions_Courses_CourseId",
                table: "HomeworkSubmissions",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkSubmissions_Students_StudentId",
                table: "HomeworkSubmissions",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
