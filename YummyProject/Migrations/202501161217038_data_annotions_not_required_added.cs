namespace YummyProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data_annotions_not_required_added : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "NameSurname", c => c.String(maxLength: 30));
            AlterColumn("dbo.Admins", "Username", c => c.String(maxLength: 30));
            AlterColumn("dbo.Admins", "Password", c => c.String(maxLength: 8));
            AlterColumn("dbo.Bookings", "Name", c => c.String(maxLength: 15));
            AlterColumn("dbo.Bookings", "Email", c => c.String(maxLength: 30));
            AlterColumn("dbo.Bookings", "PhoneNumber", c => c.String(maxLength: 50));
            AlterColumn("dbo.Bookings", "MessageContent", c => c.String(maxLength: 10));
            AlterColumn("dbo.Products", "ProductName", c => c.String(maxLength: 3));
            AlterColumn("dbo.Products", "Ingredients", c => c.String(maxLength: 3));
            AlterColumn("dbo.Chefs", "ChefName", c => c.String(maxLength: 3));
            AlterColumn("dbo.Chefs", "Title", c => c.String(maxLength: 3));
            AlterColumn("dbo.Chefs", "Description", c => c.String(maxLength: 10));
            AlterColumn("dbo.ChefSocials", "SocialMediaName", c => c.String(maxLength: 3));
            AlterColumn("dbo.ContactInfoes", "Address", c => c.String(maxLength: 10));
            AlterColumn("dbo.ContactInfoes", "PhoneNumber", c => c.String(maxLength: 3));
            AlterColumn("dbo.ContactInfoes", "OpenHours", c => c.String(maxLength: 3));
            AlterColumn("dbo.Events", "Title", c => c.String(maxLength: 3));
            AlterColumn("dbo.Events", "Description", c => c.String(maxLength: 5));
            AlterColumn("dbo.Messages", "Name", c => c.String(maxLength: 3));
            AlterColumn("dbo.Messages", "Email", c => c.String(maxLength: 3));
            AlterColumn("dbo.Messages", "Subject", c => c.String(maxLength: 3));
            AlterColumn("dbo.Messages", "MessageContent", c => c.String(maxLength: 5));
            AlterColumn("dbo.Rating_Stars", "Rating_Stars_Selectable", c => c.String(maxLength: 1));
            AlterColumn("dbo.Services", "Title", c => c.String(maxLength: 3));
            AlterColumn("dbo.Services", "Description", c => c.String(maxLength: 3));
            AlterColumn("dbo.Services", "Icon", c => c.String(maxLength: 3));
            AlterColumn("dbo.SocialMedias", "Title", c => c.String(maxLength: 3));
            AlterColumn("dbo.SocialMedias", "Icon", c => c.String(maxLength: 3));
            AlterColumn("dbo.SocialMediaLogoes", "SocialMediaLogos", c => c.String(maxLength: 3));
            AlterColumn("dbo.SocialMediaLogoes", "SocialMediaLogoName", c => c.String(maxLength: 3));
            AlterColumn("dbo.Testimonials", "NameSurname", c => c.String(maxLength: 3));
            AlterColumn("dbo.Testimonials", "Title", c => c.String(maxLength: 3));
            AlterColumn("dbo.Testimonials", "Comment", c => c.String(maxLength: 3));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Testimonials", "Comment", c => c.String());
            AlterColumn("dbo.Testimonials", "Title", c => c.String());
            AlterColumn("dbo.Testimonials", "NameSurname", c => c.String());
            AlterColumn("dbo.SocialMediaLogoes", "SocialMediaLogoName", c => c.String());
            AlterColumn("dbo.SocialMediaLogoes", "SocialMediaLogos", c => c.String());
            AlterColumn("dbo.SocialMedias", "Icon", c => c.String());
            AlterColumn("dbo.SocialMedias", "Title", c => c.String());
            AlterColumn("dbo.Services", "Icon", c => c.String());
            AlterColumn("dbo.Services", "Description", c => c.String());
            AlterColumn("dbo.Services", "Title", c => c.String());
            AlterColumn("dbo.Rating_Stars", "Rating_Stars_Selectable", c => c.String());
            AlterColumn("dbo.Messages", "MessageContent", c => c.String());
            AlterColumn("dbo.Messages", "Subject", c => c.String());
            AlterColumn("dbo.Messages", "Email", c => c.String());
            AlterColumn("dbo.Messages", "Name", c => c.String());
            AlterColumn("dbo.Events", "Description", c => c.String());
            AlterColumn("dbo.Events", "Title", c => c.String());
            AlterColumn("dbo.ContactInfoes", "OpenHours", c => c.String());
            AlterColumn("dbo.ContactInfoes", "PhoneNumber", c => c.String());
            AlterColumn("dbo.ContactInfoes", "Address", c => c.String());
            AlterColumn("dbo.ChefSocials", "SocialMediaName", c => c.String());
            AlterColumn("dbo.Chefs", "Description", c => c.String());
            AlterColumn("dbo.Chefs", "Title", c => c.String());
            AlterColumn("dbo.Chefs", "ChefName", c => c.String());
            AlterColumn("dbo.Products", "Ingredients", c => c.String());
            AlterColumn("dbo.Products", "ProductName", c => c.String());
            AlterColumn("dbo.Bookings", "MessageContent", c => c.String());
            AlterColumn("dbo.Bookings", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Bookings", "Email", c => c.String());
            AlterColumn("dbo.Bookings", "Name", c => c.String());
            AlterColumn("dbo.Admins", "Password", c => c.String());
            AlterColumn("dbo.Admins", "Username", c => c.String());
            AlterColumn("dbo.Admins", "NameSurname", c => c.String());
        }
    }
}
