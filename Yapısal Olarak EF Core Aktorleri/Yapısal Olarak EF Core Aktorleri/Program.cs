
// Veri tabanını temsil edecek olan class --> DbContexttir. 

public class myContext : DbContext // bu şekilde dbcontext sınıfından türetilmelidir burada hata gözüküyor tabi çünkü ef toollarını kurmadım
{
    public DbSet<Employee> Employees { get; set; } 
    // mimaride entity olan her şey veritabanın içinde gösterilir.
    // Burada aslında şöyle birşey demiş oluyoruz içinde employee'ler barındıran bir employees tablosu var 
}

// DbContext sınıfı;
// *Konfigürasyon -> Veritabanı bağlantısı vs ilişkileri sağlar.
// *Sorgulama -> Kod tarafında gerçekleştirilen sorguları SQL sorgusuna dönüştürerek veritabanına gönderir
// *Change Tracking -> Veriler üzerindeki değişiklikleri takip eder.
// *Veri kalıcılığı -> Verilerin kaydı güncellenmesi silinmesi operasyonlarını gerçekleştirir
// *Caching

// EF Core'da tabloları temsil eden sınıflar 'Entity' olarak isimlendirilir. 