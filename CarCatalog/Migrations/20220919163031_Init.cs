using Microsoft.EntityFrameworkCore.Migrations;

namespace CarCatalog.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "EngineTypes",
                columns: table => new
                {
                    EngineTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineTypes", x => x.EngineTypeID);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    FuelTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.FuelTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    ManufacturerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.ManufacturerID);
                    table.ForeignKey(
                        name: "FK_Manufacturers_Countries_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartProductionDate = table.Column<int>(type: "int", nullable: false),
                    EndProductionDate = table.Column<int>(type: "int", nullable: false),
                    NumberOfDoors = table.Column<int>(type: "int", nullable: false),
                    NumberOfSeats = table.Column<int>(type: "int", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarID);
                    table.ForeignKey(
                        name: "FK_Cars_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BodyStyles",
                columns: table => new
                {
                    BodyStyleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyStyleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyStyles", x => x.BodyStyleID);
                    table.ForeignKey(
                        name: "FK_BodyStyles_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "CarID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Drivetrains",
                columns: table => new
                {
                    DrivetrainID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrivetrainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivetrains", x => x.DrivetrainID);
                    table.ForeignKey(
                        name: "FK_Drivetrains_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "CarID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    EngineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineCapacity = table.Column<int>(type: "int", nullable: false),
                    EnginePower = table.Column<int>(type: "int", nullable: false),
                    EngineTorque = table.Column<int>(type: "int", nullable: false),
                    NumberOfCylinders = table.Column<int>(type: "int", nullable: false),
                    EngineTypeID = table.Column<int>(type: "int", nullable: false),
                    FuelTypeID = table.Column<int>(type: "int", nullable: false),
                    CarID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.EngineID);
                    table.ForeignKey(
                        name: "FK_Engines_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "CarID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Engines_EngineTypes_EngineTypeID",
                        column: x => x.EngineTypeID,
                        principalTable: "EngineTypes",
                        principalColumn: "EngineTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Engines_FuelTypes_FuelTypeID",
                        column: x => x.FuelTypeID,
                        principalTable: "FuelTypes",
                        principalColumn: "FuelTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransmissionTypes",
                columns: table => new
                {
                    TransmissionTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransmissionTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransmissionTypes", x => x.TransmissionTypeID);
                    table.ForeignKey(
                        name: "FK_TransmissionTypes_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "CarID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BodyStyles_CarID",
                table: "BodyStyles",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ManufacturerId",
                table: "Cars",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivetrains_CarID",
                table: "Drivetrains",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_Engines_CarID",
                table: "Engines",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_Engines_EngineTypeID",
                table: "Engines",
                column: "EngineTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Engines_FuelTypeID",
                table: "Engines",
                column: "FuelTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturers_CountryID",
                table: "Manufacturers",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_TransmissionTypes_CarID",
                table: "TransmissionTypes",
                column: "CarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BodyStyles");

            migrationBuilder.DropTable(
                name: "Drivetrains");

            migrationBuilder.DropTable(
                name: "Engines");

            migrationBuilder.DropTable(
                name: "TransmissionTypes");

            migrationBuilder.DropTable(
                name: "EngineTypes");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
