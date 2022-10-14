﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ConstructionMaterialOrderingApi.Migrations
{
    public partial class ModifiedSaleReportColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "SaleReportDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "SaleReportDetails");
        }
    }
}
