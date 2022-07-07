using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnConfiguring_ve_Entity_Tanımlama_Kuralları
{
    public class ETicaretContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // override edilerek kullanılır
        {
            optionsBuilder.UseSqlServer("");
            // Provider, Connection String, Lazy Loading vb yapılandırmalar yapılır
        }
    }

    public class Urun
    {
        public int Id { get; set; }

    }

    #region Entity Tanımlama Kuralları
    // Her tablonun default olarak bir primary key kolonu olması gerekir. (HasNoKey kullanarak bunun üstesinden gelinebiliyor)
    // Idli bir property varsa EF onu otomatik olarak primary key olarak alır.
    #endregion
}
