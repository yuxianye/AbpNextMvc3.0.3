using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Solution.Migrations
{
    public partial class AddTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppCustomers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Address = table.Column<string>(maxLength: 256, nullable: false),
                    Contact = table.Column<string>(maxLength: 32, nullable: false),
                    Phone = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCustomers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEnterprises",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Address = table.Column<string>(maxLength: 256, nullable: false),
                    Phone = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEnterprises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentBrands",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentInspectionResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentInspectionResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentMaintenanceResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentMaintenanceResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentSparePartTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentSparePartTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppOrderStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOrderStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppProductTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppQualityInspectResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppQualityInspectResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppQualityInspectTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Code = table.Column<string>(maxLength: 8, nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppQualityInspectTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppQualityProblemLibs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Code = table.Column<string>(maxLength: 8, nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppQualityProblemLibs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppSupplierLevels",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSupplierLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppWarehouseTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWarehouseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CheckType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ControlCode",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppEnterpriseSites",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    EnterpriseId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Address = table.Column<string>(maxLength: 256, nullable: false),
                    Manager = table.Column<string>(maxLength: 32, nullable: true),
                    Phone = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEnterpriseSites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppEnterpriseSites_AppEnterprises_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "AppEnterprises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentSpareParts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    EquipmentSparePartTypeId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentSpareParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppEquipmentSpareParts_AppEquipmentSparePartTypes_EquipmentSparePartTypeId",
                        column: x => x.EquipmentSparePartTypeId,
                        principalTable: "AppEquipmentSparePartTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    EquipmentTypeId = table.Column<Guid>(nullable: false),
                    EquipmentBrandId = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(maxLength: 8, nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Specification = table.Column<string>(maxLength: 64, nullable: false),
                    ManufactureDate = table.Column<DateTime>(nullable: false),
                    EquipmentStatusId = table.Column<Guid>(nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppEquipment_AppEquipmentBrands_EquipmentBrandId",
                        column: x => x.EquipmentBrandId,
                        principalTable: "AppEquipmentBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppEquipment_AppEquipmentStatuses_EquipmentStatusId",
                        column: x => x.EquipmentStatusId,
                        principalTable: "AppEquipmentStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppEquipment_AppEquipmentTypes_EquipmentTypeId",
                        column: x => x.EquipmentTypeId,
                        principalTable: "AppEquipmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppSuppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Code = table.Column<string>(maxLength: 8, nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    SupplierLevelId = table.Column<Guid>(nullable: false),
                    Contact = table.Column<string>(maxLength: 32, nullable: false),
                    Phone = table.Column<string>(maxLength: 32, nullable: false),
                    Fax = table.Column<string>(maxLength: 32, nullable: false),
                    Address = table.Column<string>(maxLength: 256, nullable: false),
                    Email = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSuppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppSuppliers_AppSupplierLevels_SupplierLevelId",
                        column: x => x.SupplierLevelId,
                        principalTable: "AppSupplierLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppMaterials",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Code = table.Column<string>(maxLength: 8, nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Specification = table.Column<string>(maxLength: 64, nullable: false),
                    UnitId = table.Column<Guid>(nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppMaterials_AppUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "AppUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Code = table.Column<string>(maxLength: 8, nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    ProductTypeId = table.Column<Guid>(nullable: false),
                    Specification = table.Column<string>(maxLength: 64, nullable: false),
                    UnitId = table.Column<Guid>(nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppProducts_AppProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "AppProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppProducts_AppUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "AppUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Process",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ControlCodeId = table.Column<Guid>(nullable: false),
                    CheckTypeId = table.Column<Guid>(nullable: false),
                    IsAutotransfer = table.Column<bool>(nullable: false),
                    PrepareTime = table.Column<int>(nullable: false),
                    ManufactureTime = table.Column<int>(nullable: false),
                    UnloadingTime = table.Column<int>(nullable: false),
                    QueueTime = table.Column<int>(nullable: false),
                    IsEnabled = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Process_CheckType_CheckTypeId",
                        column: x => x.CheckTypeId,
                        principalTable: "CheckType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Process_ControlCode_ControlCodeId",
                        column: x => x.ControlCodeId,
                        principalTable: "ControlCode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppEnterpriseAreas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    EnterpriseSiteId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Manager = table.Column<string>(maxLength: 32, nullable: true),
                    Phone = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEnterpriseAreas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppEnterpriseAreas_AppEnterpriseSites_EnterpriseSiteId",
                        column: x => x.EnterpriseSiteId,
                        principalTable: "AppEnterpriseSites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentInspections",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    EquipmentId = table.Column<Guid>(nullable: false),
                    InspectPerson = table.Column<string>(maxLength: 32, nullable: false),
                    InspectionTime = table.Column<DateTime>(nullable: false),
                    EquipmentInspectionResultId = table.Column<Guid>(nullable: false),
                    Problem = table.Column<string>(maxLength: 256, nullable: true),
                    Cause = table.Column<string>(maxLength: 256, nullable: true),
                    Solution = table.Column<string>(maxLength: 256, nullable: true),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentInspections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppEquipmentInspections_AppEquipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "AppEquipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppEquipmentMaintenances",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    EquipmentId = table.Column<Guid>(nullable: false),
                    Problem = table.Column<string>(maxLength: 256, nullable: false),
                    Cause = table.Column<string>(maxLength: 256, nullable: false),
                    Solution = table.Column<string>(maxLength: 256, nullable: false),
                    ActualStartTime = table.Column<DateTime>(nullable: false),
                    ActualFinishTime = table.Column<DateTime>(nullable: false),
                    Consumable = table.Column<string>(maxLength: 256, nullable: false),
                    ResponsiblePerson = table.Column<string>(maxLength: 32, nullable: false),
                    MaintenanceTime = table.Column<DateTime>(nullable: false),
                    EquipmentMaintenanceResultId = table.Column<Guid>(nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEquipmentMaintenances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppEquipmentMaintenances_AppEquipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "AppEquipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppEquipmentMaintenances_AppEquipmentMaintenanceResults_EquipmentMaintenanceResultId",
                        column: x => x.EquipmentMaintenanceResultId,
                        principalTable: "AppEquipmentMaintenanceResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppBOMs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    Version = table.Column<string>(maxLength: 64, nullable: false),
                    MaterialId = table.Column<Guid>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    IsEnabled = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBOMs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppBOMs_AppMaterials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "AppMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Code = table.Column<int>(maxLength: 8, nullable: false),
                    CustomerId = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    OrderStatusId = table.Column<Guid>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppOrders_AppCustomers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AppCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppOrders_AppOrderStatuses_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "AppOrderStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppOrders_AppProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "AppProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppQualityInspects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Code = table.Column<string>(maxLength: 8, nullable: false),
                    InspectPerson = table.Column<string>(maxLength: 32, nullable: false),
                    QualityInspectTypeId = table.Column<Guid>(nullable: false),
                    InspectTime = table.Column<DateTime>(nullable: false),
                    ProcessId = table.Column<Guid>(nullable: false),
                    QualityProblemLibId = table.Column<Guid>(nullable: false),
                    QualityInspectResultId = table.Column<Guid>(nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppQualityInspects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppQualityInspects_Process_ProcessId",
                        column: x => x.ProcessId,
                        principalTable: "Process",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppQualityInspects_AppQualityInspectResults_QualityInspectResultId",
                        column: x => x.QualityInspectResultId,
                        principalTable: "AppQualityInspectResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppQualityInspects_AppQualityInspectTypes_QualityInspectTypeId",
                        column: x => x.QualityInspectTypeId,
                        principalTable: "AppQualityInspectTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppQualityInspects_AppQualityProblemLibs_QualityProblemLibId",
                        column: x => x.QualityProblemLibId,
                        principalTable: "AppQualityProblemLibs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppEnterpriseProductionLines",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    EnterpriseAreaId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Manager = table.Column<string>(maxLength: 32, nullable: true),
                    Phone = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEnterpriseProductionLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppEnterpriseProductionLines_AppEnterpriseAreas_EnterpriseAreaId",
                        column: x => x.EnterpriseAreaId,
                        principalTable: "AppEnterpriseAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppWarehouses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    EnterpriseAreaId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Manager = table.Column<string>(maxLength: 32, nullable: false),
                    Phone = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWarehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppWarehouses_AppEnterpriseAreas_EnterpriseAreaId",
                        column: x => x.EnterpriseAreaId,
                        principalTable: "AppEnterpriseAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppEnterpriseWorkCenters",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    EnterpriseProductionLineId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Manager = table.Column<string>(maxLength: 32, nullable: true),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEnterpriseWorkCenters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppEnterpriseWorkCenters_AppEnterpriseProductionLines_EnterpriseProductionLineId",
                        column: x => x.EnterpriseProductionLineId,
                        principalTable: "AppEnterpriseProductionLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppWarehouseAreas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    WarehouseId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWarehouseAreas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppWarehouseAreas_AppWarehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "AppWarehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppEnterpriseWorkLocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    EnterpriseWorkCenterId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    EquipmentId = table.Column<Guid>(nullable: false),
                    ProcessId = table.Column<Guid>(nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEnterpriseWorkLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppEnterpriseWorkLocations_AppEnterpriseWorkCenters_EnterpriseWorkCenterId",
                        column: x => x.EnterpriseWorkCenterId,
                        principalTable: "AppEnterpriseWorkCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppEnterpriseWorkLocations_AppEquipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "AppEquipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppEnterpriseWorkLocations_Process_ProcessId",
                        column: x => x.ProcessId,
                        principalTable: "Process",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppWarehouseLocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    WarehouseAreaId = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(maxLength: 8, nullable: false),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppWarehouseLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppWarehouseLocations_AppWarehouseAreas_WarehouseAreaId",
                        column: x => x.WarehouseAreaId,
                        principalTable: "AppWarehouseAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppBOMs_MaterialId",
                table: "AppBOMs",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_AppEnterpriseAreas_EnterpriseSiteId",
                table: "AppEnterpriseAreas",
                column: "EnterpriseSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_AppEnterpriseProductionLines_EnterpriseAreaId",
                table: "AppEnterpriseProductionLines",
                column: "EnterpriseAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_AppEnterpriseSites_EnterpriseId",
                table: "AppEnterpriseSites",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_AppEnterpriseWorkCenters_EnterpriseProductionLineId",
                table: "AppEnterpriseWorkCenters",
                column: "EnterpriseProductionLineId");

            migrationBuilder.CreateIndex(
                name: "IX_AppEnterpriseWorkLocations_EnterpriseWorkCenterId",
                table: "AppEnterpriseWorkLocations",
                column: "EnterpriseWorkCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_AppEnterpriseWorkLocations_EquipmentId",
                table: "AppEnterpriseWorkLocations",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppEnterpriseWorkLocations_ProcessId",
                table: "AppEnterpriseWorkLocations",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_AppEquipment_EquipmentBrandId",
                table: "AppEquipment",
                column: "EquipmentBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_AppEquipment_EquipmentStatusId",
                table: "AppEquipment",
                column: "EquipmentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AppEquipment_EquipmentTypeId",
                table: "AppEquipment",
                column: "EquipmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppEquipmentInspections_EquipmentId",
                table: "AppEquipmentInspections",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppEquipmentMaintenances_EquipmentId",
                table: "AppEquipmentMaintenances",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppEquipmentMaintenances_EquipmentMaintenanceResultId",
                table: "AppEquipmentMaintenances",
                column: "EquipmentMaintenanceResultId");

            migrationBuilder.CreateIndex(
                name: "IX_AppEquipmentSpareParts_EquipmentSparePartTypeId",
                table: "AppEquipmentSpareParts",
                column: "EquipmentSparePartTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppMaterials_UnitId",
                table: "AppMaterials",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AppOrders_CustomerId",
                table: "AppOrders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_AppOrders_OrderStatusId",
                table: "AppOrders",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AppOrders_ProductId",
                table: "AppOrders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AppProducts_ProductTypeId",
                table: "AppProducts",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppProducts_UnitId",
                table: "AppProducts",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AppQualityInspects_ProcessId",
                table: "AppQualityInspects",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_AppQualityInspects_QualityInspectResultId",
                table: "AppQualityInspects",
                column: "QualityInspectResultId");

            migrationBuilder.CreateIndex(
                name: "IX_AppQualityInspects_QualityInspectTypeId",
                table: "AppQualityInspects",
                column: "QualityInspectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppQualityInspects_QualityProblemLibId",
                table: "AppQualityInspects",
                column: "QualityProblemLibId");

            migrationBuilder.CreateIndex(
                name: "IX_AppSuppliers_SupplierLevelId",
                table: "AppSuppliers",
                column: "SupplierLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_AppWarehouseAreas_WarehouseId",
                table: "AppWarehouseAreas",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_AppWarehouseLocations_WarehouseAreaId",
                table: "AppWarehouseLocations",
                column: "WarehouseAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_AppWarehouses_EnterpriseAreaId",
                table: "AppWarehouses",
                column: "EnterpriseAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_CheckTypeId",
                table: "Process",
                column: "CheckTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Process_ControlCodeId",
                table: "Process",
                column: "ControlCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppBOMs");

            migrationBuilder.DropTable(
                name: "AppEnterpriseWorkLocations");

            migrationBuilder.DropTable(
                name: "AppEquipmentInspectionResults");

            migrationBuilder.DropTable(
                name: "AppEquipmentInspections");

            migrationBuilder.DropTable(
                name: "AppEquipmentMaintenances");

            migrationBuilder.DropTable(
                name: "AppEquipmentSpareParts");

            migrationBuilder.DropTable(
                name: "AppOrders");

            migrationBuilder.DropTable(
                name: "AppQualityInspects");

            migrationBuilder.DropTable(
                name: "AppSuppliers");

            migrationBuilder.DropTable(
                name: "AppWarehouseLocations");

            migrationBuilder.DropTable(
                name: "AppWarehouseTypes");

            migrationBuilder.DropTable(
                name: "AppMaterials");

            migrationBuilder.DropTable(
                name: "AppEnterpriseWorkCenters");

            migrationBuilder.DropTable(
                name: "AppEquipment");

            migrationBuilder.DropTable(
                name: "AppEquipmentMaintenanceResults");

            migrationBuilder.DropTable(
                name: "AppEquipmentSparePartTypes");

            migrationBuilder.DropTable(
                name: "AppCustomers");

            migrationBuilder.DropTable(
                name: "AppOrderStatuses");

            migrationBuilder.DropTable(
                name: "AppProducts");

            migrationBuilder.DropTable(
                name: "Process");

            migrationBuilder.DropTable(
                name: "AppQualityInspectResults");

            migrationBuilder.DropTable(
                name: "AppQualityInspectTypes");

            migrationBuilder.DropTable(
                name: "AppQualityProblemLibs");

            migrationBuilder.DropTable(
                name: "AppSupplierLevels");

            migrationBuilder.DropTable(
                name: "AppWarehouseAreas");

            migrationBuilder.DropTable(
                name: "AppEnterpriseProductionLines");

            migrationBuilder.DropTable(
                name: "AppEquipmentBrands");

            migrationBuilder.DropTable(
                name: "AppEquipmentStatuses");

            migrationBuilder.DropTable(
                name: "AppEquipmentTypes");

            migrationBuilder.DropTable(
                name: "AppProductTypes");

            migrationBuilder.DropTable(
                name: "AppUnits");

            migrationBuilder.DropTable(
                name: "CheckType");

            migrationBuilder.DropTable(
                name: "ControlCode");

            migrationBuilder.DropTable(
                name: "AppWarehouses");

            migrationBuilder.DropTable(
                name: "AppEnterpriseAreas");

            migrationBuilder.DropTable(
                name: "AppEnterpriseSites");

            migrationBuilder.DropTable(
                name: "AppEnterprises");
        }
    }
}
