namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "ImageUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Abouts", "ImageUrl2", c => c.String(nullable: false));
            AlterColumn("dbo.Abouts", "Item1", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.Abouts", "Item2", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.Abouts", "Item3", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.Abouts", "Description", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Abouts", "VideoUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Abouts", "PhoneNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Admins", "NameSurname", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.Admins", "Username", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.Admins", "Password", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Admins", "ImageUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Bookings", "Name", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.Bookings", "Email", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.Bookings", "PhoneNumber", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.Bookings", "MessageContent", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false, maxLength: 70));
            AlterColumn("dbo.Products", "ImageUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Products", "Ingredients", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Chefs", "ChefName", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.ChefSocials", "Url", c => c.String(nullable: false));
            AlterColumn("dbo.ChefSocials", "Icon", c => c.String(nullable: false));
            AlterColumn("dbo.ChefSocials", "SocialMediaName", c => c.String(nullable: false));
            AlterColumn("dbo.ContactInfoes", "Address", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.ContactInfoes", "PhoneNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.ContactInfoes", "MapUrl", c => c.String(nullable: false));
            AlterColumn("dbo.ContactInfoes", "OpenHours", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Events", "ImageUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "Title", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Events", "Description", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Events", "Price", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Features", "Title", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Messages", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Messages", "Email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Messages", "Subject", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Messages", "MessageContent", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Rating_Stars", "Rating_Stars_Selectable", c => c.String(maxLength: 10));
            AlterColumn("dbo.Services", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Services", "Description", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Services", "Icon", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.SocialMedias", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.SocialMedias", "Icon", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Testimonials", "NameSurname", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Testimonials", "Title", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Testimonials", "Comment", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Testimonials", "Comment", c => c.String(maxLength: 3));
            AlterColumn("dbo.Testimonials", "Title", c => c.String(maxLength: 3));
            AlterColumn("dbo.Testimonials", "NameSurname", c => c.String(maxLength: 3));
            AlterColumn("dbo.SocialMedias", "Icon", c => c.String(maxLength: 3));
            AlterColumn("dbo.SocialMedias", "Title", c => c.String(maxLength: 3));
            AlterColumn("dbo.Services", "Icon", c => c.String(maxLength: 3));
            AlterColumn("dbo.Services", "Description", c => c.String(maxLength: 3));
            AlterColumn("dbo.Services", "Title", c => c.String(maxLength: 3));
            AlterColumn("dbo.Rating_Stars", "Rating_Stars_Selectable", c => c.String(maxLength: 1));
            AlterColumn("dbo.Messages", "MessageContent", c => c.String(maxLength: 5));
            AlterColumn("dbo.Messages", "Subject", c => c.String(maxLength: 3));
            AlterColumn("dbo.Messages", "Email", c => c.String(maxLength: 3));
            AlterColumn("dbo.Messages", "Name", c => c.String(maxLength: 3));
            AlterColumn("dbo.Features", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "Price", c => c.String());
            AlterColumn("dbo.Events", "Description", c => c.String(maxLength: 5));
            AlterColumn("dbo.Events", "Title", c => c.String(maxLength: 3));
            AlterColumn("dbo.Events", "ImageUrl", c => c.String());
            AlterColumn("dbo.ContactInfoes", "OpenHours", c => c.String(maxLength: 3));
            AlterColumn("dbo.ContactInfoes", "MapUrl", c => c.String());
            AlterColumn("dbo.ContactInfoes", "PhoneNumber", c => c.String(maxLength: 3));
            AlterColumn("dbo.ContactInfoes", "Address", c => c.String(maxLength: 10));
            AlterColumn("dbo.ChefSocials", "SocialMediaName", c => c.String(maxLength: 3));
            AlterColumn("dbo.ChefSocials", "Icon", c => c.String());
            AlterColumn("dbo.ChefSocials", "Url", c => c.String());
            AlterColumn("dbo.Chefs", "ChefName", c => c.String(maxLength: 3));
            AlterColumn("dbo.Products", "Ingredients", c => c.String(maxLength: 3));
            AlterColumn("dbo.Products", "ProductName", c => c.String(maxLength: 3));
            AlterColumn("dbo.Products", "ImageUrl", c => c.String());
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Bookings", "MessageContent", c => c.String(maxLength: 10));
            AlterColumn("dbo.Bookings", "PhoneNumber", c => c.String(maxLength: 50));
            AlterColumn("dbo.Bookings", "Email", c => c.String(maxLength: 30));
            AlterColumn("dbo.Bookings", "Name", c => c.String(maxLength: 15));
            AlterColumn("dbo.Admins", "ImageUrl", c => c.String());
            AlterColumn("dbo.Admins", "Password", c => c.String(maxLength: 8));
            AlterColumn("dbo.Admins", "Username", c => c.String(maxLength: 30));
            AlterColumn("dbo.Admins", "NameSurname", c => c.String(maxLength: 30));
            AlterColumn("dbo.Abouts", "PhoneNumber", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Abouts", "VideoUrl", c => c.String());
            AlterColumn("dbo.Abouts", "Description", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Abouts", "Item3", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Abouts", "Item2", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Abouts", "Item1", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Abouts", "ImageUrl2", c => c.String());
            AlterColumn("dbo.Abouts", "ImageUrl", c => c.String());
        }
    }
}
