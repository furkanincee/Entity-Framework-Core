
/*
 * Önceden hazırlanmış bir veritabanı varsa --> DbFirst
 * DbFirst yaklaşımı ile var olan veritabanını tersine mühendislik ile kod kısmında modelleriz.
 * 
 * Uzun süreli devam eden uygulamalarda (devlet projeleri gibi köklü kurumsal projelerin veritabanları modellenirken mesela)
 * Veritabanı yönetim sürecine ve tasarımına dair kararların geliştiriciler tarafından alınmadığı durumlarda DbFirst tercih edilmelidir.
 * DB'deki değişiklikler geliştirici tarafından kod tarafında kontrol edilip güncellenmelidir.
 * 
 * Veritabanı önceden oluşturulmamışsa veritabanının kod kısmında modellenip sonradan veritabanı sunucusuna migrate edilmesi --> CodeFirst
 * 
 * Yönetim süreci geliştirici tarafından sağlanır.
 */