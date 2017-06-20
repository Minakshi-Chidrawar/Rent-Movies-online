namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4fee17d2-987b-4b64-b998-a43c0601cdbc', N'admin@vidyl.com', 0, N'AHxTidPi0DyyMaZpllqI8twKPi8KHBOqYl1sTvuHoWdVUjMOox6p2ZLzyQZaf8DirA==', N'1c912882-3c4f-4240-bb05-6f882cf1f224', NULL, 0, 0, NULL, 1, 0, N'admin@vidyl.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5d7e9ab3-76c0-4130-acf1-01f62a0a5e0e', N'guest@vidyl.com', 0, N'AP5kK4XYpe1VpV09E6m3uMUDcENgEmyS/yx7skqLrlVAbzWHip7cIbnjO9MKc+vzfA==', N'2a82d04c-195e-44d4-9fd8-4c06e148616c', NULL, 0, 0, NULL, 1, 0, N'guest@vidyl.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0b5148ae-766e-446b-973d-1a500b112cf8', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4fee17d2-987b-4b64-b998-a43c0601cdbc', N'0b5148ae-766e-446b-973d-1a500b112cf8')
            ");
        }

        public override void Down()
        {
        }
    }
}
