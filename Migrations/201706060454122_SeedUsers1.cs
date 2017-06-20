namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'168dc8c2-51be-4908-803b-dde2e584c1a3', N'admin_manage@vidyl.com', 0, N'ACb3+R64/eECZHSpEP+rbf/K+n6EsnJwjftJyVAwbwoi70smbzXVFhTirzardCCTgg==', N'd2a1ee97-aaac-4619-9c64-cd02d2052afb', NULL, 0, 0, NULL, 1, 0, N'admin_manage@vidyl.com', N'yes', N'012345')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'96cb9083-0a5b-4cd8-9536-24bdd48c4bab', N'customer1@vidly.com', 0, N'AFc/rAP5WyozkEiD+gqPcoHUZ4bUao/S541HdF4HUKTlqc4fL+oiyMOrwHUrwsPDrA==', N'b802cc45-25f8-4430-9401-c7899030e03b', NULL, 0, 0, NULL, 1, 0, N'customer1@vidly.com', N'yes', N'01235')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0b5148ae-766e-446b-973d-1a500b112cf8', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'168dc8c2-51be-4908-803b-dde2e584c1a3', N'0b5148ae-766e-446b-973d-1a500b112cf8')
");
        }

        public override void Down()
        {
        }
    }
}
