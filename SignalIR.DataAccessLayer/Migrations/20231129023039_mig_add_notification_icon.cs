﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SignaIR.DataAccessLayer.Migrations
{
    public partial class mig_add_notification_icon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Notifications");
        }
    }
}
