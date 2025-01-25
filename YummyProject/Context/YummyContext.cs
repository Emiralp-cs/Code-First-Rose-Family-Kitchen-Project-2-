using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using YummyProject.Models;

namespace YummyProject.Context
{
    public class YummyContext : DbContext
    {
        //Bu kısımda oluşturduğumuz classların veri tabanında tablo halini oluşturuyoruz.

        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<ChefSocial> ChefSocials { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PhotoGallery> PhotoGalleries { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<SocialMediaLogo> SocialMediasLogo { get; set; }

        public DbSet<Stats> Stats { get; set; }
        public DbSet<ConInfo> ContactInfo { get; set; }
        public DbSet<Rating_Stars> Rating_Stars { get; set; }



    }
}