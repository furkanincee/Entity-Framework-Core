
// Packet manager consoldan Scaffold işlemi 
// Scaffold-DbContext 'Connection string' Microsoft.EntityFrameworkCore.[Provider]

// Bunu yapabilmek için;
// Microsoft.EntityFrameworkCore.Tools
// Database provider ( Microsoft.EntityFrameworkCore.SqlServer ) Kütüphaneleri yüklü olmalı.

// local db ile çalışıyosan bu komutu kullanabilirsin;
// Scaffold-DbContext "Server=.\SQLExpress;Database=Northwind;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer 

// dotnet CLI üzerinden
// dotnet ef dbcontext scaffold 'conn string' Microsoft.EntityFrameworkCore.[Provider]
// bunun için tools yerine design yüklenmesi lazım tek farkı bu
// powershelli View-->Terminal'den açıyosun

// belli başlı tabloları getirmek için ise
// paket managerden: Scaffold-DbContext 'Connection string' Microsoft.EntityFrameworkCore.[Provider] -Tables Tablo1, tablo2, tablo3...
// dotnet CLI'dan ise;
// Scaffold-DbContext "Server=.\SQLExpress;Database=Northwind;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer --table tablo1 --table tablo2...
// dotnet CLI eziyet yani

// gelecek olan contextin adını da -Context istediğinAd şeklinde değiştirebiliyorsun
// oluşturulacak modellerin farklı dizinlerde gitmesini istiyorsak -ContextDir contextyeri -OutputDir modelyeri
// napespace belirtmek için -Namespace isimboslugu -ContextNamespace contextisimboslgu

// veritabanında değişiklikler olduğu zaman kodu güncellemek için yine scaffoldlu komutu yazıp -Force parametresi ekliyoruz

// DBfirst kullanırken bazen kod üzerinde özelleştirmeler yapma ihtiyacı duyabiliriz örneğin bi classa yeni bir property eklenecek
// fakat ilerleyen zamanlarda dbden güncelleme yapıldığı zaman bu eklenen property ezilir ve silinir. Bu kayıpların önüne geçmek için
// dbden çektiğimiz tüm modeller partial class olarak gelir. Biz üzerine bir şey ekleme yapmak istediğimizde ekleme değişiklik vs yapmak istediğimiz
// model ile aynı isimde bir partial class oluştururuz. Entities-->Partials klasöründe örnek var
// dolayısıyla güncelleme yapıldığında sadece entities içindeki model güncellenecektir partials klasöründe bulunan yaptığımız eklemeler vs ezilmemiş olacaktır

