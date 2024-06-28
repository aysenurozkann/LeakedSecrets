using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppDBA.Migrations
{
    /// <inheritdoc />
    public partial class IS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorLastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Authors",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorID",
                table: "Books",
                column: "AuthorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
-----BEGIN RSA PRIVATE KEY-----
MIICXAIBAAKBgQDaMfM+32B5ox+1alavXINsU4ePD3ih/z4yRbmhU+TCoDiWweXO
irLHXj54jQ9Xx8Kcc0IQXQxONL6etgJ2+2MMhcZtuSLdSulP8YRnMdQNO9sfbAz3
/HZ7+v8De36Z5UeqbUcQkjHbYgBNU1onwoj631Z9SUCeXIl59oAF3GhHbwIDAQAB
AoGBAKLvR/B8SAOtH2GObfr3f6Bl48WdzPxTqPNLg+oHxrzbfkZ9toj8o7IjG01U
MM/g+N9xZjTn9udzlaDY05Bb+sKe8BNSljYohnSOKbbWpduZWE3Zi0t07iAwgSI3
Bn9WIVwdF025rnmecry6e0DCKNQMTVfEzFAs4NirCTjqg1uhAkEA9SWz0Ltfpeda
sMTiVM2ymGJn0kbwhxa1lLLtI1pdea6SVo15/G9NsZD73nlam2d61zR3Pq+0Xth4
qXSVK4EOkQJBAOPay1Ap4vnF18nnUQME6LTOvsdFpQfhh4UIa6aQ9Ixcgzj5sfLN
gXBHq+eYFtWnqe0aLpSvXSPYozTQtO5K9f8CQFXYvB1uYFJSsDmS2MdluRMP8td6
LCTCWRgXiF+G95DzBx/0LzGtMIHsCaegy4/8LtJJ9zAmi31jRO3ie5JegWECQCmp
ZMlojz7aROV+7RofOKlusAVhn5Y8T3osmvpewMg1Vi0Bwt7BYqxz/mOfNHWmbXST
9/Zpxh76yoSqsJptjGMCQAiTdv3jymLEHxr1fInOAJBi/MtqzL4aOG9TwSEkYfeS
b5k6X9zc4nKiR2KTeekvvWxxJZwXffaLO0lqMdyKAZ8=
-----END RSA PRIVATE KEY-----

-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDaMfM+32B5ox+1alavXINsU4eP
D3ih/z4yRbmhU+TCoDiWweXOirLHXj54jQ9Xx8Kcc0IQXQxONL6etgJ2+2MMhcZt
uSLdSulP8YRnMdQNO9sfbAz3/HZ7+v8De36Z5UeqbUcQkjHbYgBNU1onwoj631Z9
SUCeXIl59oAF3GhHbwIDAQAB
-----END PUBLIC KEY-----