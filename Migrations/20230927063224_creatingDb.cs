using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyProject.Migrations
{
    /// <inheritdoc />
    public partial class creatingDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "establishments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_establishments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ingridients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingridients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pizza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pizza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "salads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sushi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sushi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstablishmentPizza",
                columns: table => new
                {
                    establishmentsId = table.Column<int>(type: "int", nullable: false),
                    pizzasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstablishmentPizza", x => new { x.establishmentsId, x.pizzasId });
                    table.ForeignKey(
                        name: "FK_EstablishmentPizza_establishments_establishmentsId",
                        column: x => x.establishmentsId,
                        principalTable: "establishments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstablishmentPizza_pizza_pizzasId",
                        column: x => x.pizzasId,
                        principalTable: "pizza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngridientPizza",
                columns: table => new
                {
                    ingridientsId = table.Column<int>(type: "int", nullable: false),
                    pizzasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngridientPizza", x => new { x.ingridientsId, x.pizzasId });
                    table.ForeignKey(
                        name: "FK_IngridientPizza_ingridients_ingridientsId",
                        column: x => x.ingridientsId,
                        principalTable: "ingridients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngridientPizza_pizza_pizzasId",
                        column: x => x.pizzasId,
                        principalTable: "pizza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pizzaIngridients",
                columns: table => new
                {
                    PizzaId = table.Column<int>(type: "int", nullable: false),
                    IngridientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pizzaIngridients", x => new { x.PizzaId, x.IngridientId });
                    table.ForeignKey(
                        name: "FK_pizzaIngridients_ingridients_IngridientId",
                        column: x => x.IngridientId,
                        principalTable: "ingridients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pizzaIngridients_pizza_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "pizza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstablishmentSalad",
                columns: table => new
                {
                    establishmentsId = table.Column<int>(type: "int", nullable: false),
                    saladsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstablishmentSalad", x => new { x.establishmentsId, x.saladsId });
                    table.ForeignKey(
                        name: "FK_EstablishmentSalad_establishments_establishmentsId",
                        column: x => x.establishmentsId,
                        principalTable: "establishments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstablishmentSalad_salads_saladsId",
                        column: x => x.saladsId,
                        principalTable: "salads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngridientSalad",
                columns: table => new
                {
                    ingridientsId = table.Column<int>(type: "int", nullable: false),
                    saladsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngridientSalad", x => new { x.ingridientsId, x.saladsId });
                    table.ForeignKey(
                        name: "FK_IngridientSalad_ingridients_ingridientsId",
                        column: x => x.ingridientsId,
                        principalTable: "ingridients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngridientSalad_salads_saladsId",
                        column: x => x.saladsId,
                        principalTable: "salads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "saladIngridients",
                columns: table => new
                {
                    SaladId = table.Column<int>(type: "int", nullable: false),
                    IngridientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saladIngridients", x => new { x.SaladId, x.IngridientId });
                    table.ForeignKey(
                        name: "FK_saladIngridients_ingridients_IngridientId",
                        column: x => x.IngridientId,
                        principalTable: "ingridients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_saladIngridients_salads_SaladId",
                        column: x => x.SaladId,
                        principalTable: "salads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstablishmentSushi",
                columns: table => new
                {
                    establishmentsId = table.Column<int>(type: "int", nullable: false),
                    sushisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstablishmentSushi", x => new { x.establishmentsId, x.sushisId });
                    table.ForeignKey(
                        name: "FK_EstablishmentSushi_establishments_establishmentsId",
                        column: x => x.establishmentsId,
                        principalTable: "establishments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstablishmentSushi_sushi_sushisId",
                        column: x => x.sushisId,
                        principalTable: "sushi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngridientSushi",
                columns: table => new
                {
                    ingridientsId = table.Column<int>(type: "int", nullable: false),
                    sushisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngridientSushi", x => new { x.ingridientsId, x.sushisId });
                    table.ForeignKey(
                        name: "FK_IngridientSushi_ingridients_ingridientsId",
                        column: x => x.ingridientsId,
                        principalTable: "ingridients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngridientSushi_sushi_sushisId",
                        column: x => x.sushisId,
                        principalTable: "sushi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sushiIngridients",
                columns: table => new
                {
                    SushiId = table.Column<int>(type: "int", nullable: false),
                    IngridientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sushiIngridients", x => new { x.SushiId, x.IngridientId });
                    table.ForeignKey(
                        name: "FK_sushiIngridients_ingridients_IngridientId",
                        column: x => x.IngridientId,
                        principalTable: "ingridients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sushiIngridients_sushi_SushiId",
                        column: x => x.SushiId,
                        principalTable: "sushi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "establishments",
                columns: new[] { "Id", "Adress", "Name" },
                values: new object[,]
                {
                    { 1, "Soborna_1 st", "Number_1" },
                    { 2, "Soborna_2 st", "Number_2" },
                    { 3, "Soborna_3 st", "Number_3" }
                });

            migrationBuilder.InsertData(
                table: "ingridients",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 22, "Ingrid_1", 1m },
                    { 23, "Ingrid_2", 2m },
                    { 24, "Ingrid_3", 3m },
                    { 25, "Ingrid_4", 4m },
                    { 26, "Ingrid_5", 5m },
                    { 27, "Ingrid_6", 6m }
                });

            migrationBuilder.InsertData(
                table: "pizza",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Neapolitana", 6m },
                    { 2, "Neapolitana-2", 7m }
                });

            migrationBuilder.InsertData(
                table: "salads",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1001, "Cesair", 12m },
                    { 1002, "King", 6m }
                });

            migrationBuilder.InsertData(
                table: "sushi",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 2001, "Dragon", 19m },
                    { 2002, "Gold Dragon", 23m }
                });

            migrationBuilder.InsertData(
                table: "pizzaIngridients",
                columns: new[] { "IngridientId", "PizzaId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "saladIngridients",
                columns: new[] { "IngridientId", "SaladId" },
                values: new object[,]
                {
                    { 7, 1001 },
                    { 8, 1001 },
                    { 9, 1001 },
                    { 10, 1002 },
                    { 11, 1002 },
                    { 12, 1002 }
                });

            migrationBuilder.InsertData(
                table: "sushiIngridients",
                columns: new[] { "IngridientId", "SushiId" },
                values: new object[,]
                {
                    { 13, 2001 },
                    { 14, 2001 },
                    { 15, 2001 },
                    { 16, 2001 },
                    { 17, 2002 },
                    { 18, 2002 },
                    { 19, 2002 },
                    { 20, 2002 },
                    { 21, 2002 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstablishmentPizza_pizzasId",
                table: "EstablishmentPizza",
                column: "pizzasId");

            migrationBuilder.CreateIndex(
                name: "IX_EstablishmentSalad_saladsId",
                table: "EstablishmentSalad",
                column: "saladsId");

            migrationBuilder.CreateIndex(
                name: "IX_EstablishmentSushi_sushisId",
                table: "EstablishmentSushi",
                column: "sushisId");

            migrationBuilder.CreateIndex(
                name: "IX_IngridientPizza_pizzasId",
                table: "IngridientPizza",
                column: "pizzasId");

            migrationBuilder.CreateIndex(
                name: "IX_IngridientSalad_saladsId",
                table: "IngridientSalad",
                column: "saladsId");

            migrationBuilder.CreateIndex(
                name: "IX_IngridientSushi_sushisId",
                table: "IngridientSushi",
                column: "sushisId");

            migrationBuilder.CreateIndex(
                name: "IX_pizzaIngridients_IngridientId",
                table: "pizzaIngridients",
                column: "IngridientId");

            migrationBuilder.CreateIndex(
                name: "IX_saladIngridients_IngridientId",
                table: "saladIngridients",
                column: "IngridientId");

            migrationBuilder.CreateIndex(
                name: "IX_sushiIngridients_IngridientId",
                table: "sushiIngridients",
                column: "IngridientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstablishmentPizza");

            migrationBuilder.DropTable(
                name: "EstablishmentSalad");

            migrationBuilder.DropTable(
                name: "EstablishmentSushi");

            migrationBuilder.DropTable(
                name: "IngridientPizza");

            migrationBuilder.DropTable(
                name: "IngridientSalad");

            migrationBuilder.DropTable(
                name: "IngridientSushi");

            migrationBuilder.DropTable(
                name: "pizzaIngridients");

            migrationBuilder.DropTable(
                name: "saladIngridients");

            migrationBuilder.DropTable(
                name: "sushiIngridients");

            migrationBuilder.DropTable(
                name: "establishments");

            migrationBuilder.DropTable(
                name: "pizza");

            migrationBuilder.DropTable(
                name: "salads");

            migrationBuilder.DropTable(
                name: "ingridients");

            migrationBuilder.DropTable(
                name: "sushi");
        }
    }
}
