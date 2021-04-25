using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MillionAndUp.Data.Migrations
{
    public partial class SeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 1,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "East", new DateTime(1994, 12, 5, 18, 4, 7, 906, DateTimeKind.Unspecified).AddTicks(3813), "Afton Heathcote", "https://picsum.photos/640/480/?image=524" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 2,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "East", new DateTime(2012, 5, 16, 15, 3, 48, 524, DateTimeKind.Unspecified).AddTicks(162), "Shad Shields", "https://picsum.photos/640/480/?image=413" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 3,
                columns: new[] { "Birthday", "Name", "Photo" },
                values: new object[] { new DateTime(1995, 4, 2, 1, 31, 34, 125, DateTimeKind.Unspecified).AddTicks(8586), "Adan Lowe", "https://picsum.photos/640/480/?image=554" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 4,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "Northeast", new DateTime(2008, 5, 28, 0, 40, 10, 47, DateTimeKind.Unspecified).AddTicks(1958), "Constance Hahn", "https://picsum.photos/640/480/?image=672" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 5,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "North", new DateTime(2013, 5, 23, 20, 22, 6, 404, DateTimeKind.Unspecified).AddTicks(1992), "Alaina Rice", "https://picsum.photos/640/480/?image=614" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 6,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "Northwest", new DateTime(2002, 1, 28, 9, 30, 41, 684, DateTimeKind.Unspecified).AddTicks(3425), "Foster O'Reilly", "https://picsum.photos/640/480/?image=6" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 7,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "Southwest", new DateTime(2011, 10, 23, 8, 46, 38, 176, DateTimeKind.Unspecified).AddTicks(1323), "Lester Koepp", "https://picsum.photos/640/480/?image=311" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 8,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "West", new DateTime(1996, 6, 23, 1, 38, 43, 674, DateTimeKind.Unspecified).AddTicks(3852), "Ricardo Smith", "https://picsum.photos/640/480/?image=173" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 9,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "Southwest", new DateTime(2002, 8, 5, 9, 49, 2, 736, DateTimeKind.Unspecified).AddTicks(9594), "Richie Kunze", "https://picsum.photos/640/480/?image=511" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 10,
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "East", new DateTime(2015, 4, 24, 10, 40, 2, 292, DateTimeKind.Unspecified).AddTicks(8929), "Aubree Bashirian", "https://picsum.photos/640/480/?image=178" });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 1,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "North", "USB", "Elenora Parker", 2, 2016m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                columns: new[] { "Address", "InternalCode", "Name", "Price" },
                values: new object[] { "Southeast", "RSS", "Willis Grady", 2018m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "East", "SAS", "Willard Leannon", 9, 2018m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 4,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Northwest", "EXE", "Malika Mayer", 1, 2019m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 5,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "North", "HTTP", "Devonte Nader", 6, 2018m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 6,
                columns: new[] { "Address", "Name", "OwnerId", "Price" },
                values: new object[] { "East", "Frieda Corwin", 8, 2019m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 7,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "South", "COM", "Lawson Leffler", 4, 2020m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 8,
                columns: new[] { "Address", "InternalCode", "Name", "Price" },
                values: new object[] { "South", "XML", "Gregory D'Amore", 2018m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 9,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId" },
                values: new object[] { "South", "XSS", "Peter Larson", 8 });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 10,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Southwest", "HTTP", "Francesca Lehner", 4, 2016m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 11,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "East", "XSS", "Americo Hodkiewicz", 4, 2018m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 12,
                columns: new[] { "Address", "InternalCode", "Name" },
                values: new object[] { "Southeast", "SCSI", "Leta Adams" });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 13,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Southeast", "AI", "Elza Blick", 8, 2019m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 14,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Southeast", "GB", "Amira Dach", 7, 2016m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 15,
                columns: new[] { "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "RSS", "Joyce Hamill", 2, 2020m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 16,
                columns: new[] { "InternalCode", "Name", "Price" },
                values: new object[] { "SAS", "Aileen Durgan", 2017m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 17,
                columns: new[] { "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "GB", "Cleta Rath", 8, 2016m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 18,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "East", "USB", "Darien Rohan", 9, 2016m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 19,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Southwest", "JBOD", "Myles Blanda", 6, 2016m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 20,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "East", "HDD", "Wava Emmerich", 5, 2018m });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 1,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=750", 9 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 2,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=277", 8 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 3,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=373", 8 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 4,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=485", 4 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 5,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=744", 12 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 6,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=445", 6 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 7,
                columns: new[] { "Enabled", "FilePath" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=405" });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 8,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=17", 5 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 9,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=349", 3 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 10,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=810", 14 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 11,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=1065", 11 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 12,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=721", 12 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 13,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=968", 5 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 14,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=725", 12 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 15,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=198", 1 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 16,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=185", 11 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 17,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=165", 8 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 18,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=830", 4 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 19,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=1032", 13 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 20,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=503", 2 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 21,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=287", 17 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 22,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=500", 16 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 23,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=368", 11 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 24,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=388", 14 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 25,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=64", 19 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 26,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=726", 10 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 27,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=509", 16 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 28,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=662", 3 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 29,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=761", 18 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 30,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=467", 9 });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 1,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Janae Loaf", 19, 0.8462872979446720m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 2,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Beaulah Tunnel", 11, 0.8091080397409890m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 3,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Hettinger Turnpike", 6, 0.5888469776086730m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 4,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Kovacek Points", 17, 0.581725420701190m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 5,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Lorena Flat", 16, 0.7511175264376760m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 6,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Hills Valley", 1, 0.04110817985660780m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 7,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Keshaun Street", 5, 0.8892261525100220m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 8,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Rosenbaum Village", 13, 0.2592070448488030m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 9,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Curtis Burg", 14, 0.7963800364157090m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 10,
                columns: new[] { "Name", "Value" },
                values: new object[] { "Morar Alley", 0.2356751990670690m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 11,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Katelynn Plaza", 13, 0.6964086562844040m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 12,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Armand Ridge", 9, 0.9991365442979780m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 13,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Barrows Spurs", 3, 0.06824146866250850m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 14,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Marietta Mission", 9, 0.8802099259943750m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 15,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Jacobs Ranch", 8, 0.4600264660362280m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 16,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Abbey Terrace", 19, 0.9139938712650880m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 17,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Lorenz Glen", 3, 0.6901753208088570m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 18,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Romaine Plaza", 6, 0.6080328284800210m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 19,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Yundt Mill", 5, 0.1904735556759280m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 20,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Fadel Square", 8, 0.08989608012600620m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 21,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Smitham Fort", 18, 0.9252294520499320m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 22,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Tillman Square", 8, 0.6223258146188810m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 23,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Corkery Forge", 12, 0.5558681481312350m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 24,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Littel Walk", 8, 0.2505453029882840m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 25,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Rath Gateway", 14, 0.6145707041093010m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 26,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Abshire Overpass", 12, 0.7852373923106290m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 27,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Charlene Lights", 17, 0.4812139009503710m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 28,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Emile Crest", 13, 0.3281813153662630m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 29,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "McGlynn Path", 5, 0.428296189023320m });

            migrationBuilder.UpdateData(
                table: "PropertyTraces",
                keyColumn: "PropertyTraceId",
                keyValue: 30,
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Ward Views", 2, 0.5298357082204130m });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 18, "Randy", "Koepp", "49Ma6bP0SA", "Laurine_Block44" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 2, "Elsa", "Kihn", "zSPhigi82P", "Gladyce_Altenwerth35" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 3, "Fannie", "Koepp", "Hd8FR5WMee", "Tomasa39" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 4, "Destini", "Denesik", "1pPVvRP6E7", "Gwen.Cummings28" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 5, "Filomena", "Murray", "P4242p3s5p", "Marcia.Feil97" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 6, "Winona", "Pfeffer", "Y7uMCP08Fi", "Merl.Armstrong" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 7, "Walker", "Boyle", "NyB9jaS2GX", "Shayne48" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 8, "Franz", "Mohr", "4apqL28gnE", "Tristian_Halvorson70" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 19, "Casandra", "Kirlin", "ZmaBUfZoKT", "Nick34" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 9, "Justina", "Hammes", "m37pnKFBVY", "Rhea53" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 11, "Ashton", "Lakin", "MjtXRrjgM2", "Jaime.Hilpert79" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 12, "Jarrod", "Feest", "m7u91rrRjr", "Ludie37" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 13, "Aylin", "Haley", "GVIqkELDTZ", "Janet.Runolfsson" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 14, "Enrique", "Lesch", "faIIz6nDC2", "Gertrude.Kiehn6" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 15, "Amara", "Funk", "Fc5vfCCqbj", "Vicenta_Howell" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 16, "Syble", "Wiegand", "b0HHD0xX43", "Ines_Ullrich" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 17, "Cordia", "Veum", "1x9YuafQed", "Jace88" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 10, "Oral", "Spinka", "2sWdlt9RNj", "Lois89" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "LastName", "Password", "Username" },
                values: new object[] { 1, "Rosalia", "O'Reilly", "_7Oy0rMQkJ", "Will.Gulgowski" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19);

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
                columns: new[] { "Address", "Birthday", "Name", "Photo" },
                values: new object[] { "North", new DateTime(2014, 2, 18, 1, 57, 40, 886, DateTimeKind.Unspecified).AddTicks(8313), "Araceli Wehner", "https://picsum.photos/640/480/?image=642" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "OwnerId",
                keyValue: 3,
                columns: new[] { "Birthday", "Name", "Photo" },
                values: new object[] { new DateTime(1997, 4, 6, 15, 33, 42, 267, DateTimeKind.Unspecified).AddTicks(3), "Jennifer Jerde", "https://picsum.photos/640/480/?image=999" });

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
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Southeast", "THX", "Andrew Stanton", 8, 2015m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 2,
                columns: new[] { "Address", "InternalCode", "Name", "Price" },
                values: new object[] { "Southwest", "SCSI", "Skylar Swaniawski", 2015m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 3,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Southwest", "SMS", "Tom Muller", 8, 2016m });

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
                columns: new[] { "Address", "Name", "OwnerId", "Price" },
                values: new object[] { "South", "Brown Beatty", 4, 2020m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 7,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Northwest", "XML", "Harley Hamill", 7, 2015m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 8,
                columns: new[] { "Address", "InternalCode", "Name", "Price" },
                values: new object[] { "East", "SQL", "Rhiannon Labadie", 2017m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 9,
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId" },
                values: new object[] { "West", "TCP", "Lilliana Gleason", 2 });

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
                columns: new[] { "Address", "InternalCode", "Name" },
                values: new object[] { "Northwest", "SMTP", "Jamarcus Ernser" });

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
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "North", "TCP", "Efren Upton", 3, 2017m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 15,
                columns: new[] { "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "COM", "Joany Boyer", 8, 2016m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 16,
                columns: new[] { "InternalCode", "Name", "Price" },
                values: new object[] { "ADP", "Cassandre Klocko", 2018m });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "PropertyId",
                keyValue: 17,
                columns: new[] { "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "IB", "Guido Parisian", 9, 2019m });

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
                columns: new[] { "Address", "InternalCode", "Name", "OwnerId", "Price" },
                values: new object[] { "Northeast", "PCI", "Lucio MacGyver", 7, 2015m });

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
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=541", 1 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 7,
                columns: new[] { "Enabled", "FilePath" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=942" });

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
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=151", 4 });

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
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=624", 18 });

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
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=848", 5 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 18,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=1052", 6 });

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
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=750", 2 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 22,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=709", 7 });

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
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { true, "https://picsum.photos/640/480/?image=717", 16 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 27,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=355", 17 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 28,
                columns: new[] { "Enabled", "FilePath", "PropertyId" },
                values: new object[] { false, "https://picsum.photos/640/480/?image=57", 19 });

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "PropertyImageId",
                keyValue: 29,
                columns: new[] { "FilePath", "PropertyId" },
                values: new object[] { "https://picsum.photos/640/480/?image=539", 15 });

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
                columns: new[] { "Name", "Value" },
                values: new object[] { "Dietrich Walks", 0.7582780745617480m });

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
                columns: new[] { "Name", "PropertyId", "Value" },
                values: new object[] { "Ava Dam", 9, 0.08518070033061350m });

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
    }
}
