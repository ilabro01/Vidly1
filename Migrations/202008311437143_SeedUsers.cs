namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'33b0d054-a084-461c-92be-f7e342cc81d0', N'guest@vidly.com', 0, N'AOv1zrg/O6PR/UH2eIQT8pTQnrsoEcfGeYzv4t0DqGBZfFDUZMmhTk8gkWdx7j8mgQ==', N'd2c226d9-0286-431d-a506-2b441c04822d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'376b14b3-3b3c-4592-a27f-e3f223124701', N'admin@vidly.com', 0, N'AP8Wux3OXu8e4qiqeaHAJ07uFVqbmehbLLs/Rk0iNRUL6sa1R5GB7C5t28qroqjCYQ==', N'0eaa79c6-a072-40a8-b3f5-060b56179ef7', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6aa28053-56f6-403d-a1a8-978723b65a1c', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'376b14b3-3b3c-4592-a27f-e3f223124701', N'6aa28053-56f6-403d-a1a8-978723b65a1c')

");
        }
        
        public override void Down()
        {
        }
    }
}
