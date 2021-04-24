using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MillionAndUp.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "Address", "Birthday", "Name", "Photo" },
                values: new object[] { 1, "Northwest", new DateTime(2019, 9, 3, 23, 54, 56, 931, DateTimeKind.Unspecified).AddTicks(1331), "Wilfredo Jacobi", "https://picsum.photos/640/480/?image=186" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "Address", "Birthday", "Name", "Photo" },
                values: new object[] { 2, "North", new DateTime(2020, 9, 2, 10, 27, 4, 311, DateTimeKind.Unspecified).AddTicks(7607), "Abdullah Kub", "https://picsum.photos/640/480/?image=632" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "Address", "Birthday", "Name", "Photo" },
                values: new object[] { 3, "North", new DateTime(2010, 9, 27, 5, 43, 14, 975, DateTimeKind.Unspecified).AddTicks(8450), "Kevin Smith", "https://picsum.photos/640/480/?image=335" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "Address", "Birthday", "Name", "Photo" },
                values: new object[] { 4, "West", new DateTime(2002, 11, 8, 4, 51, 8, 233, DateTimeKind.Unspecified).AddTicks(4424), "Alisa Fadel", "https://picsum.photos/640/480/?image=786" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "Address", "Birthday", "Name", "Photo" },
                values: new object[] { 5, "South", new DateTime(2020, 3, 17, 10, 20, 49, 374, DateTimeKind.Unspecified).AddTicks(784), "Merlin Rempel", "https://picsum.photos/640/480/?image=185" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "Address", "Birthday", "Name", "Photo" },
                values: new object[] { 6, "Southeast", new DateTime(2014, 6, 24, 22, 52, 41, 439, DateTimeKind.Unspecified).AddTicks(1686), "Okey Brakus", "https://picsum.photos/640/480/?image=86" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "Address", "Birthday", "Name", "Photo" },
                values: new object[] { 7, "West", new DateTime(1992, 10, 4, 9, 40, 20, 946, DateTimeKind.Unspecified).AddTicks(3776), "Jaime D'Amore", "https://picsum.photos/640/480/?image=536" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "Address", "Birthday", "Name", "Photo" },
                values: new object[] { 8, "East", new DateTime(2009, 7, 25, 21, 9, 16, 89, DateTimeKind.Unspecified).AddTicks(4858), "Barbara Quigley", "https://picsum.photos/640/480/?image=290" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "Address", "Birthday", "Name", "Photo" },
                values: new object[] { 9, "Southwest", new DateTime(2012, 5, 29, 6, 29, 34, 296, DateTimeKind.Unspecified).AddTicks(1332), "Vesta Doyle", "https://picsum.photos/640/480/?image=50" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerId", "Address", "Birthday", "Name", "Photo" },
                values: new object[] { 10, "East", new DateTime(2010, 10, 10, 4, 49, 19, 106, DateTimeKind.Unspecified).AddTicks(1887), "Oliver Kling", "https://picsum.photos/640/480/?image=908" });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 1, "Southeast", "CSS", "Anne Murazik", 1, 2016m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 13, "West", "COM", "Emmalee Tromp", 8, 2016m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 8, "South", "AGP", "Adrienne Gislason", 8, 2016m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 4, "Northeast", "AI", "Orin Schuppe", 8, 2017m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 19, "West", "XML", "Will Howe", 7, 2018m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 15, "Northeast", "TCP", "Amelia Schulist", 7, 2020m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 3, "Southwest", "AI", "Maymie Graham", 7, 2016m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 7, "Northwest", "SQL", "Madilyn Lakin", 6, 2015m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 5, "North", "AGP", "Eve Thompson", 4, 2019m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 12, "West", "SSL", "Jerad Lynch", 3, 2015m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 6, "Northeast", "JBOD", "Esmeralda Wilkinson", 3, 2017m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 2, "East", "IB", "Julio Fritsch", 3, 2020m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 18, "North", "TCP", "Maggie Reilly", 2, 2016m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 14, "North", "RAM", "Neoma Wilderman", 2, 2015m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 9, "East", "IB", "Sebastian Kling", 2, 2018m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 16, "Southeast", "ADP", "Kenyon Weber", 1, 2015m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 11, "Northeast", "SCSI", "Schuyler Stamm", 1, 2020m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 10, "Southwest", "SMS", "Garnet Hagenes", 1, 2015m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 17, "Northeast", "FTP", "Vivianne Nader", 8, 2015m, 0 });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "PropertyId", "Address", "InternalCode", "Name", "OwnerId", "Price", "Year" },
                values: new object[] { 20, "West", "SDD", "Gillian Quitzon", 9, 2015m, 0 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "FilePath", "PropertyId" },
                values: new object[] { 12, "https://picsum.photos/640/480/?image=614", 1 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 29, true, "https://picsum.photos/640/480/?image=964", 17 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 5, true, "https://picsum.photos/640/480/?image=471", 5 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 18, true, "https://picsum.photos/640/480/?image=1021", 5 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "FilePath", "PropertyId" },
                values: new object[] { 4, "https://picsum.photos/640/480/?image=559", 7 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "FilePath", "PropertyId" },
                values: new object[] { 8, "https://picsum.photos/640/480/?image=144", 7 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 14, true, "https://picsum.photos/640/480/?image=642", 3 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "FilePath", "PropertyId" },
                values: new object[] { 19, "https://picsum.photos/640/480/?image=1043", 3 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "FilePath", "PropertyId" },
                values: new object[] { 21, "https://picsum.photos/640/480/?image=127", 3 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "FilePath", "PropertyId" },
                values: new object[] { 7, "https://picsum.photos/640/480/?image=845", 19 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 17, true, "https://picsum.photos/640/480/?image=345", 19 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 16, true, "https://picsum.photos/640/480/?image=785", 4 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 26, true, "https://picsum.photos/640/480/?image=523", 4 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "FilePath", "PropertyId" },
                values: new object[] { 6, "https://picsum.photos/640/480/?image=850", 8 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "FilePath", "PropertyId" },
                values: new object[] { 15, "https://picsum.photos/640/480/?image=622", 8 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 23, true, "https://picsum.photos/640/480/?image=1020", 13 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 25, true, "https://picsum.photos/640/480/?image=273", 13 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 9, true, "https://picsum.photos/640/480/?image=2", 17 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 1, true, "https://picsum.photos/640/480/?image=86", 6 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "FilePath", "PropertyId" },
                values: new object[] { 22, "https://picsum.photos/640/480/?image=964", 14 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "FilePath", "PropertyId" },
                values: new object[] { 10, "https://picsum.photos/640/480/?image=973", 12 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 30, true, "https://picsum.photos/640/480/?image=260", 11 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 11, true, "https://picsum.photos/640/480/?image=31", 11 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "FilePath", "PropertyId" },
                values: new object[] { 28, "https://picsum.photos/640/480/?image=75", 10 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 2, true, "https://picsum.photos/640/480/?image=1055", 16 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 24, true, "https://picsum.photos/640/480/?image=275", 10 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 13, true, "https://picsum.photos/640/480/?image=950", 10 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "FilePath", "PropertyId" },
                values: new object[] { 3, "https://picsum.photos/640/480/?image=903", 10 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "FilePath", "PropertyId" },
                values: new object[] { 27, "https://picsum.photos/640/480/?image=881", 11 });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "PropertyImageId", "Enabled", "FilePath", "PropertyId" },
                values: new object[] { 20, true, "https://picsum.photos/640/480/?image=656", 9 });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 1, "Camren Inlet", 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.8988235825201610m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 14, "Shanahan Glens", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.6597609592879940m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 7, "Jaime Mountain", 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.6836994293535590m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 25, "Dicki Lights", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.07049619456310580m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 28, "Becker Highway", 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.1584835244149360m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 20, "Shanelle Radial", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.8447819798462010m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 16, "Macejkovic Ways", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.9723520139103530m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 19, "Crist Extensions", 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.2383566863082150m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 27, "Kadin Garden", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.5711676229588540m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 30, "Goldner Spring", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.5091924469495160m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 13, "Nolan Skyway", 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.9363964483777040m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 23, "Jerde Via", 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.03921903764792670m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 2, "Imani Forest", 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.3484679485431260m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 18, "Ryan Drive", 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.2253396605259460m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 29, "Abbott Crossing", 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.5262238055124060m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 4, "Osinski Run", 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.4251190244337170m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 12, "Cordia Run", 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.1406202228463350m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 6, "Jennyfer Courts", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.1334006726431660m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 21, "Howell Square", 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.7160553902928040m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 9, "Cecil Circles", 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.9662579898565350m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 3, "Aufderhar Walks", 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.2737654271879070m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 17, "Huels Spurs", 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.3514273126383440m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 26, "Gillian Mountains", 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.1187358405993950m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 5, "Vaughn Ports", 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.4147829662145970m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 24, "Hilda Passage", 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.658288118270360m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 22, "Edna Terrace", 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.662885856192040m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 11, "Susana Divide", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.2321868833304320m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 15, "Crystel Summit", 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.8618038626675510m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 10, "Yessenia Glens", 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.498256134566970m });

            migrationBuilder.InsertData(
                table: "PropertyTraces",
                columns: new[] { "PropertyTraceId", "Name", "PropertyId", "SaleDate", "Tax", "Value" },
                values: new object[] { 8, "Virginia Flat", 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, 0.5829359495932870m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 8);
        }
    }
}
