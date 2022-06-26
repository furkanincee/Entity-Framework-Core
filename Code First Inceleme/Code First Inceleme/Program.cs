
using Microsoft.EntityFrameworkCore;

ExampleDbContext context = new();
await context.Database.MigrateAsync();
// Son kullanıcının dbyi oluşturacağı durumlarda bunu kullanabilirsin.

public class ExampleDbContext : DbContext // DbContext sınıfından türetiyoruz ve bunu kullanmak için entity paketini kuruyoruz.
{
    //Entitylerin bu dbnin tabloları olduğunu belirtmek için DbSet propertysi olarak ekliyoruz. 
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost ");  // hangi veritabanı programını kullandığımızı ve connection stringimizi belirtiyoruz
        // Bunu kullanabilmek için sql paketini kurduk
    }
}

// Migration oluşturmak için tools paketini kurduk.
// add-migration [migration name]
// remove-migration tüm migleri siler
// get-migration oluşturulmuş migrationları listeler
// migrationu dbye göndermek için -> update-database
// update-database [migration name] bu şekilde belli bir mig verdiğimizde o migrationdaki versiyona geri dönülür. 

// şimdiye kadar hep tool üzerinden migration yaptık fakat uygulama çalışırken yani runtime'da da kod üzerinden migration yapılabiliyor
// sayfa başına git 4-5. satırlara



public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
}