using Microsoft.EntityFrameworkCore;
using Blog.Shared;


namespace Blog.Server.Data
{

    //DbContext, EF Core ile veritabanı işlemlerini yapmak için temel sınıftır.
    public class AppDbContext : DbContext
    {

        //AppDbContext sınıfı, EF Core ile veritabanı işlemlerini yönetmek için kullanılan bir sınıftır.Bu sınıf, veritabanı
        //    bağlantısı ve yapılandırma seçeneklerini alırken, DbSet özelliği aracılığıyla BlogPost sınıfının veritabanı tablosunu
        //    temsil eder.Bu şekilde, AppDbContext sınıfı, uygulamanın diğer kısımlarında veritabanı işlemlerini gerçekleştirmek için
        //    kullanılabilir.

        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<BlogPost> BlogPosts { get; set; }

    }
}
