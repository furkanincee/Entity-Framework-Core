
/* ORM teknolojileri OOP'nin özelliklerinden faydalanarak veri tabanının koda dökülmesini sağlar.
 * Veritabanındaki tabloların sınıflar, satırların da objeler olarak gelmesi vb işlemlere genel olarak 
 * object related mapping denir. Yani nesne ilgili eşleme.
 * 
 * Kodun yönetimini kolaylaştırır, kodu kullanılan database programından bağımsızlaştırır.
 * ORM teknolojileri yazılan sorguyu arka planda kullanılan database'in diline çevirerek gönderir.
 * 
 * SQL server yüklediğinde gelen SQL Profiler ile atılmış bir LINQ sorgusunun SQL çıktısını görebilirsin
 * 
 * dotnet-ef CLI komutlarını kullanabilmemiz için;
 * Windows powershellden dotnet tool install --global dotnet-ef ile global olarak toolu yükleyebiliriz
 * güncelleme için dotnet tool update --global dotnet-ef
 * kontrol etmek için dotnet ef
 * 
 * Tool yüklendikten sonra bir projede kullanabilmek için Microsoft.EntityFrameworkCore.Design paketini projeye yüklememiz gerek. (CLI ile ilgili kısımlar için)
 * 
 * Package-manager üzerinden kullanımlar için Microsoft.EntityFrameworkCore.Tools
 */
