using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicStore.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Artist",
            //    columns: table => new
            //    {
            //        ArtistID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Artist", x => x.ArtistID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Genre",
            //    columns: table => new
            //    {
            //        GenreID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Genre", x => x.GenreID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Order",
            //    columns: table => new
            //    {
            //        OrderID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Order", x => x.OrderID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Album",
            //    columns: table => new
            //    {
            //        AlbumID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        GenreID = table.Column<int>(type: "int", nullable: false),
            //        ArtistID = table.Column<int>(type: "int", nullable: false),
            //        Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Price = table.Column<int>(type: "int", nullable: false),
            //        AlbumArtUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Album", x => x.AlbumID);
            //        table.ForeignKey(
            //            name: "FK_Album_Artist_ArtistID",
            //            column: x => x.ArtistID,
            //            principalTable: "Artist",
            //            principalColumn: "ArtistID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Album_Genre_GenreID",
            //            column: x => x.GenreID,
            //            principalTable: "Genre",
            //            principalColumn: "GenreID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CartItem",
            //    columns: table => new
            //    {
            //        CartItemID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CartKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        AlbumID = table.Column<int>(type: "int", nullable: false),
            //        Count = table.Column<int>(type: "int", nullable: false),
            //        DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CartItem", x => x.CartItemID);
            //        table.ForeignKey(
            //            name: "FK_CartItem_Album_AlbumID",
            //            column: x => x.AlbumID,
            //            principalTable: "Album",
            //            principalColumn: "AlbumID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OrderItem",
            //    columns: table => new
            //    {
            //        OrderItemID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        OrderID = table.Column<int>(type: "int", nullable: false),
            //        AlbumID = table.Column<int>(type: "int", nullable: false),
            //        Quantity = table.Column<int>(type: "int", nullable: false),
            //        UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OrderItem", x => x.OrderItemID);
            //        table.ForeignKey(
            //            name: "FK_OrderItem_Album_AlbumID",
            //            column: x => x.AlbumID,
            //            principalTable: "Album",
            //            principalColumn: "AlbumID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_OrderItem_Order_OrderID",
            //            column: x => x.OrderID,
            //            principalTable: "Order",
            //            principalColumn: "OrderID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Album_ArtistID",
            //    table: "Album",
            //    column: "ArtistID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Album_GenreID",
            //    table: "Album",
            //    column: "GenreID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CartItem_AlbumID",
            //    table: "CartItem",
            //    column: "AlbumID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItem_AlbumID",
            //    table: "OrderItem",
            //    column: "AlbumID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItem_OrderID",
            //    table: "OrderItem",
            //    column: "OrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
