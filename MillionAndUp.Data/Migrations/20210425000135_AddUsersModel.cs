using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MillionAndUp.Data.Migrations
{
    public partial class AddUsersModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 1,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "North", new DateTime(1994, 6, 2, 2, 48, 29, 846, DateTimeKind.Unspecified).AddTicks(2571), "Salvador Leffler", "https://picsum.photos/640/480/?image=440" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 2,
                columns: new[] { "Birthday", "Name", "Photo" },
                values: new object[] { new DateTime(2014, 2, 18, 1, 57, 40, 886, DateTimeKind.Unspecified).AddTicks(8313), "Araceli Wehner", "https://picsum.photos/640/480/?image=642" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 3,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "West", new DateTime(1997, 4, 6, 15, 33, 42, 267, DateTimeKind.Unspecified).AddTicks(3), "Jennifer Jerde", "https://picsum.photos/640/480/?image=999" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 4,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "East", new DateTime(2011, 4, 3, 11, 50, 48, 416, DateTimeKind.Unspecified).AddTicks(4642), "Pamela Osinski", "https://picsum.photos/640/480/?image=191" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 5,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "Northeast", new DateTime(2016, 6, 7, 22, 41, 26, 184, DateTimeKind.Unspecified).AddTicks(625), "Braden Zemlak", "https://picsum.photos/640/480/?image=619" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 6,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "West", new DateTime(2006, 8, 9, 23, 43, 58, 832, DateTimeKind.Unspecified).AddTicks(7930), "Donnell Carroll", "https://picsum.photos/640/480/?image=256" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 7,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "North", new DateTime(1995, 8, 10, 21, 21, 33, 117, DateTimeKind.Unspecified).AddTicks(2855), "Roy Bayer", "https://picsum.photos/640/480/?image=807" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 8,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "Southeast", new DateTime(2008, 8, 11, 19, 12, 50, 942, DateTimeKind.Unspecified).AddTicks(3126), "Aurore Oberbrunner", "https://picsum.photos/640/480/?image=672" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 9,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "North", new DateTime(2000, 5, 23, 5, 0, 33, 24, DateTimeKind.Unspecified).AddTicks(4541), "Theodore Schneider", "https://picsum.photos/640/480/?image=311" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 10,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "Northeast", new DateTime(2014, 4, 27, 1, 28, 45, 408, DateTimeKind.Unspecified).AddTicks(2960), "Madyson Bechtelar", "https://picsum.photos/640/480/?image=909" });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                columns: new[] { "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "THX", "Andrew Stanton", 8, 2015m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Southwest", "SCSI", "Skylar Swaniawski", 5, 2015m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                columns: new[] { "InternalCode", "Name", "OwnerId" },
                values: new object[] { "SMS", "Tom Muller", 8 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "West", "ADP", "Augustine Miller", 7, 2020m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Northeast", "SMS", "Marcelle Skiles", 1, 2020m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 6,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "South", "PNG", "Brown Beatty", 4, 2020m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 7,
                columns: new[] { "InternalCode", "Name", "OwnerId" },
                values: new object[] { "XML", "Harley Hamill", 7 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 8,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "East", "SQL", "Rhiannon Labadie", 7, 2017m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 9,
                columns: new[] { "Address", "InternalCode", "Name", "Price" },
                values: new object[] { "West", "TCP", "Lilliana Gleason", 2019m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 10,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "East", "JBOD", "Celestino Bradtke", 9, 2018m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 11,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Northwest", "SSL", "Brook Runolfsson", 7, 2019m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 12,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Northwest", "SMTP", "Jamarcus Ernser", 8, 2016m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 13,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Southwest", "SSL", "Marjorie Funk", 5, 2015m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 14,
                columns: new[] { "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "TCP", "Efren Upton", 3, 2017m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 15,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "East", "COM", "Joany Boyer", 8, 2016m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 16,
                columns: new[] { "Address", "Name", "OwnerId", "Price" },
                values: new object[] { "North", "Cassandre Klocko", 6, 2018m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 17,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "North", "IB", "Guido Parisian", 9, 2019m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 18,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "South", "COM", "Cathryn Hoppe", 3, 2020m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 19,
                columns: new[] { "Address", "InternalCode", "Name", "Price" },
                values: new object[] { "Northeast", "PCI", "Lucio MacGyver", 2015m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 20,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "South", "CSS", "Forest Cole", 4, 2020m });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 1,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=657", 8 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 2,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=886", 15 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 3,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=560", 9 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 4,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=1071", 1 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 5,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=188", 2 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 6,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=541", 1 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 7,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=942", 3 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 8,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=889", 10 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 9,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=774", 1 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 10,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=873", 17 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 11,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=151", 4 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 12,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=564", 10 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 13,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=1063", 2 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 14,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=624", 18 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 15,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=370", 18 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 16,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=704", 2 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 17,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=848", 5 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 18,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=1052", 6 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 19,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=692", 11 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 20,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=985", 16 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 21,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=750", 2 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 22,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=709", 7 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 23,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=959", 2 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 24,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=759", 16 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 25,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=805", 5 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 26,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=717", 16 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 27,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=355", 17 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 28,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=57", 19 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 29,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=539", 15 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 30,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=646", 16 });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 1,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Devan Islands", 13, 0.4575126550428160m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 2,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Cassin Green", 3, 0.8301512663393060m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 3,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Osinski Canyon", 7, 0.2389421035716970m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 4,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Gunnar Common", 1, 0.771089599826880m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 5,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Ollie Lakes", 3, 0.7829831702555450m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 6,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Lubowitz Way", 19, 0.4594430133977170m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 7,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Kay Canyon", 6, 0.253583771294720m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 8,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Friesen Ports", 16, 0.121412397884490m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 9,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Schroeder Walk", 3, 0.432398107569850m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 10,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Dietrich Walks", 11, 0.7582780745617480m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 11,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Strosin Isle", 18, 0.07134133254705990m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 12,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Jones Run", 15, 0.9226692933229120m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 13,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Earnestine Meadows", 7, 0.7239425888862190m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 14,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Raphael Isle", 18, 0.876573886199190m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 15,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Tania Knoll", 2, 0.2184154746208410m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 16,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Alize Summit", 3, 0.3975971869181830m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 17,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Tiana Island", 9, 0.5453073845921580m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 18,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Magnolia Springs", 2, 0.03393443489164790m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 19,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "O'Kon Trail", 16, 0.8487964569818210m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 20,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Taurean Plaza", 4, 0.6319951087385390m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 21,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Cartwright Stravenue", 14, 0.7031269100043580m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 22,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Ward Brook", 10, 0.06568253229636820m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 23,
                columns: new[] { "Name", "Value" },
                values: new object[] { "Ava Dam", 0.08518070033061350m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 24,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Roob Ranch", 12, 0.861998723755590m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 25,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Willa Cape", 16, 0.9102720054380m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 26,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Clementina Meadows", 2, 0.7748858387465060m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 27,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Koch Via", 13, 0.4437518177757750m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 28,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Lehner River", 12, 0.3593702862781330m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 29,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Ole Knoll", 16, 0.9586703148478040m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 30,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Bryana Points", 5, 0.09067324227219130m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 1,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "Northwest", new DateTime(2019, 9, 3, 23, 54, 56, 931, DateTimeKind.Unspecified).AddTicks(1331), "Wilfredo Jacobi", "https://picsum.photos/640/480/?image=186" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 2,
                columns: new[] { "Birthday", "Name", "Photo" },
                values: new object[] { new DateTime(2020, 9, 2, 10, 27, 4, 311, DateTimeKind.Unspecified).AddTicks(7607), "Abdullah Kub", "https://picsum.photos/640/480/?image=632" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 3,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "North", new DateTime(2010, 9, 27, 5, 43, 14, 975, DateTimeKind.Unspecified).AddTicks(8450), "Kevin Smith", "https://picsum.photos/640/480/?image=335" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 4,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "West", new DateTime(2002, 11, 8, 4, 51, 8, 233, DateTimeKind.Unspecified).AddTicks(4424), "Alisa Fadel", "https://picsum.photos/640/480/?image=786" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 5,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "South", new DateTime(2020, 3, 17, 10, 20, 49, 374, DateTimeKind.Unspecified).AddTicks(784), "Merlin Rempel", "https://picsum.photos/640/480/?image=185" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 6,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "Southeast", new DateTime(2014, 6, 24, 22, 52, 41, 439, DateTimeKind.Unspecified).AddTicks(1686), "Okey Brakus", "https://picsum.photos/640/480/?image=86" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 7,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "West", new DateTime(1992, 10, 4, 9, 40, 20, 946, DateTimeKind.Unspecified).AddTicks(3776), "Jaime D'Amore", "https://picsum.photos/640/480/?image=536" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 8,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "East", new DateTime(2009, 7, 25, 21, 9, 16, 89, DateTimeKind.Unspecified).AddTicks(4858), "Barbara Quigley", "https://picsum.photos/640/480/?image=290" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 9,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "Southwest", new DateTime(2012, 5, 29, 6, 29, 34, 296, DateTimeKind.Unspecified).AddTicks(1332), "Vesta Doyle", "https://picsum.photos/640/480/?image=50" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 10,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "East", new DateTime(2010, 10, 10, 4, 49, 19, 106, DateTimeKind.Unspecified).AddTicks(1887), "Oliver Kling", "https://picsum.photos/640/480/?image=908" });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                columns: new[] { "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "CSS", "Anne Murazik", 1, 2016m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "East", "IB", "Julio Fritsch", 3, 2020m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                columns: new[] { "InternalCode", "Name", "OwnerId" },
                values: new object[] { "AI", "Maymie Graham", 7 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Northeast", "AI", "Orin Schuppe", 8, 2017m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "North", "AGP", "Eve Thompson", 4, 2019m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 6,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Northeast", "JBOD", "Esmeralda Wilkinson", 3, 2017m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 7,
                columns: new[] { "InternalCode", "Name", "OwnerId" },
                values: new object[] { "SQL", "Madilyn Lakin", 6 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 8,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "South", "AGP", "Adrienne Gislason", 8, 2016m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 9,
                columns: new[] { "Address", "InternalCode", "Name", "Price" },
                values: new object[] { "East", "IB", "Sebastian Kling", 2018m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 10,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Southwest", "SMS", "Garnet Hagenes", 1, 2015m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 11,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Northeast", "SCSI", "Schuyler Stamm", 1, 2020m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 12,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "West", "SSL", "Jerad Lynch", 3, 2015m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 13,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "West", "COM", "Emmalee Tromp", 8, 2016m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 14,
                columns: new[] { "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "RAM", "Neoma Wilderman", 2, 2015m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 15,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Northeast", "TCP", "Amelia Schulist", 7, 2020m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 16,
                columns: new[] { "Address", "Name", "OwnerId", "Price" },
                values: new object[] { "Southeast", "Kenyon Weber", 1, 2015m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 17,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Northeast", "FTP", "Vivianne Nader", 8, 2015m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 18,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "North", "TCP", "Maggie Reilly", 2, 2016m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 19,
                columns: new[] { "Address", "InternalCode", "Name", "Price" },
                values: new object[] { "West", "XML", "Will Howe", 2018m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 20,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "West", "SDD", "Gillian Quitzon", 9, 2015m });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 1,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=86", 6 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 2,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=1055", 16 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 3,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=903", 10 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 4,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=559", 7 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 5,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=471", 5 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 6,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=850", 8 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 7,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=845", 19 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 8,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=144", 7 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 9,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=2", 17 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 10,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=973", 12 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 11,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=31", 11 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 12,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=614", 1 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 13,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=950", 10 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 14,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=642", 3 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 15,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=622", 8 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 16,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=785", 4 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 17,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=345", 19 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 18,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=1021", 5 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 19,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=1043", 3 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 20,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=656", 9 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 21,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=127", 3 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 22,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=964", 14 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 23,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=1020", 13 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 24,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=275", 10 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 25,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=273", 13 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 26,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=523", 4 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 27,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=881", 11 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 28,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=75", 10 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 29,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=964", 17 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 30,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=260", 11 });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 1,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Camren Inlet", 8, 0.8988235825201610m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 2,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Imani Forest", 11, 0.3484679485431260m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 3,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Aufderhar Walks", 12, 0.2737654271879070m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 4,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Osinski Run", 18, 0.4251190244337170m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 5,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Vaughn Ports", 16, 0.4147829662145970m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 6,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Jennyfer Courts", 6, 0.1334006726431660m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 7,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Jaime Mountain", 8, 0.6836994293535590m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 8,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Virginia Flat", 17, 0.5829359495932870m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 9,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Cecil Circles", 16, 0.9662579898565350m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 10,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Yessenia Glens", 9, 0.498256134566970m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 11,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Susana Divide", 7, 0.2321868833304320m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 12,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Cordia Run", 16, 0.1406202228463350m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 13,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Nolan Skyway", 4, 0.9363964483777040m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 14,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Shanahan Glens", 3, 0.6597609592879940m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 15,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Crystel Summit", 7, 0.8618038626675510m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 16,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Macejkovic Ways", 1, 0.9723520139103530m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 17,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Huels Spurs", 12, 0.3514273126383440m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 18,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Ryan Drive", 14, 0.2253396605259460m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 19,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Crist Extensions", 15, 0.2383566863082150m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 20,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Shanelle Radial", 1, 0.8447819798462010m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 21,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Howell Square", 6, 0.7160553902928040m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 22,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Edna Terrace", 11, 0.662885856192040m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 23,
                columns: new[] { "Name", "Value" },
                values: new object[] { "Jerde Via", 0.03921903764792670m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 24,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Hilda Passage", 11, 0.658288118270360m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 25,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Dicki Lights", 1, 0.07049619456310580m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 26,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Gillian Mountains", 12, 0.1187358405993950m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 27,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Kadin Garden", 3, 0.5711676229588540m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 28,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Becker Highway", 19, 0.1584835244149360m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 29,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Abbott Crossing", 14, 0.5262238055124060m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 30,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Goldner Spring", 1, 0.5091924469495160m });
        }
    }
}
