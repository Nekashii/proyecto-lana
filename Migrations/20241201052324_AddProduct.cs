using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Store.Migrations
{
    /// <inheritdoc />
    public partial class AddProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CreatedAt", "DeletedAt", "Description", "Image", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2024, 11, 30, 22, 23, 24, 226, DateTimeKind.Local).AddTicks(5406), null, "Jeje", "https://http2.mlstatic.com/D_NQ_NP_636771-MLM78569019015_082024-O.webp", "Diviltac", 49.0, null },
                    { 2, 4, new DateTime(2024, 11, 30, 22, 23, 24, 226, DateTimeKind.Local).AddTicks(5408), null, "Botas de piel", "https://prada.mx/cdn/shop/files/82001113BO4NEGTC.jpg?v=1722530022", "Botas", 400.0, null },
                    { 3, 0, new DateTime(2024, 11, 30, 22, 23, 24, 226, DateTimeKind.Local).AddTicks(5410), null, "Sandalias de Verano", "https://i.pinimg.com/564x/36/44/cb/3644cbc16a8dd7b678fb8fcf18880893.jpg", "Sandalias", 350.0, null },
                    { 4, 2, new DateTime(2024, 11, 30, 22, 23, 24, 226, DateTimeKind.Local).AddTicks(5411), null, "Zapatillas con tacon", "https://grecoshoes.mx/cdn/shop/files/FB_IMG_1709660586119.jpg?v=1718479176", "zapatillas", 500.0, null },
                    { 5, 5, new DateTime(2024, 11, 30, 22, 23, 24, 226, DateTimeKind.Local).AddTicks(5412), null, "Uso del que quieras", "https://armystorepuebla.com.mx/wp-content/uploads/2024/02/1-Pagina-1.png", "Maquina de guerra", 500.0, null },
                    { 6, 9999, new DateTime(2024, 11, 30, 22, 23, 24, 226, DateTimeKind.Local).AddTicks(5413), null, "Perfectas para patear abuelitas ", "https://m.media-amazon.com/images/I/61z7ObMv60L._AC_SY695_.jpg", "Patea Abuelitas", 99999.0, null },
                    { 7, 0, new DateTime(2024, 11, 30, 22, 23, 24, 226, DateTimeKind.Local).AddTicks(5415), null, "Rompe Huevos de Gallina y mas ", "https://img.kwcdn.com/product/Fancyalgo/VirtualModelMatting/71681cd722ec5bb372b77fd5cd8923e7.jpg?imageView2/2/w/800/q/70/format/webp", "Rompe Huevos", 999.0, null },
                    { 8, 3, new DateTime(2024, 11, 30, 22, 23, 24, 226, DateTimeKind.Local).AddTicks(5416), null, "Perfectos para Luz ", "https://m.media-amazon.com/images/I/51KcqFWBdhL._AC_SY695_.jpg", "Tacones de Puta", 750.0, null },
                    { 9, 9999, new DateTime(2024, 11, 30, 22, 23, 24, 226, DateTimeKind.Local).AddTicks(5417), null, "Zapatos para ganar sueldo minimo y trabar como burro de carga", "https://media.gotrendier.mx/media/p/2022/02/07/n_62656cf8-8848-11ec-8091-026295ecb39b.jpeg", "Zapatos de godin", 150.0, null },
                    { 10, 1, new DateTime(2024, 11, 30, 22, 23, 24, 226, DateTimeKind.Local).AddTicks(5419), null, "Zapatillas que utilizaria peso pluma si fuera trans", "https://conideade.com/blog/wp-content/uploads/2014/08/zapato-decorado-con-pluma.jpg", "Zapatillas de plumas", 999999.0, null },
                    { 11, 4, new DateTime(2024, 11, 30, 22, 23, 24, 226, DateTimeKind.Local).AddTicks(5420), null, "Botas altotas rosas", "https://m.media-amazon.com/images/I/410gwyM1sFL._AC_SY695_.jpg", "Alv que es esto", 999.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 30, 22, 23, 24, 226, DateTimeKind.Local).AddTicks(5293));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 11, 30, 21, 24, 16, 177, DateTimeKind.Local).AddTicks(6580));
        }
    }
}
