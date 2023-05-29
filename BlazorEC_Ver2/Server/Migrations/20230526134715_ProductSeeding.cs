using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEC_Ver2.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc /> 
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "I saw my boyfriend kissing my best friend. if that wasn’t enough, I was with a guy whose guts I hate from my class, Go Eun-Hyuk. I was already shaken up… But apparently there’s a given amount of love that a person receives in their lifetime? And the amount of love I’m able to receive is ‘0’??? Soo-Ae, who’s trying to change her pathetic fate, and Eun-Hyuk, who got involved with Soo-Ae, and their headwind operation! She was only going to ‘act’ like she’s cheating on her boyfriend, but she starts to develop feelings for Eun-Hyuk?! This plan… will it truly work?", "https://cdn.pixabay.com/photo/2017/03/29/15/18/tianjin-2185510_1280.jpg", 9.99m, "Pure Love Operation 11" },
                    { 2, "It's very wholeosme, It gives, It ate, I honestly loved our mssochist in this story, she was cute, Also can i marry the elf teacher? She's too cute! Anyways I would give the plot a 9.8/10 it has every straight manhwa plot but it's yuri and it ate, The character's are a 10/10 amazing, Splendid, Spectacular, Majestic, Pleasing women. Anything else? A 10/10 overall? 10000000 out of ten.", "https://cdn.pixabay.com/photo/2016/11/29/09/16/architecture-1868667_1280.jpg", 7.99m, "Please Bully Me, Miss Villainess!" },
                    { 3, "Renia is the princess of the Fontiano Empire. Her happy days were now shattered, after she married Duke Clovis Zenov.", "https://cdn.pixabay.com/photo/2017/07/19/01/41/clouds-2517653_640.jpg", 8.99m, "Crazy Princess Renia" }
                });
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
        }
    }
}
