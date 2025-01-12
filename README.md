# CarBook 🚗

Lokasyona dayalı araç kiralama işlemleri için geliştirilen modern bir web API uygulamasıdır. **ASP.NET Core 8.0** kullanılarak hazırlanmış ve **Onion Architecture** ile yapılandırılmıştır. 

---

## 🔍 Projeye Genel Bakış

- **Admin Paneli:** Admin, araç bilgilerini, lokasyonları, marka ve modelleri kolayca yönetebilir. Ayrıca referans ve blog içeriklerini ekleyebilir, güncelleyebilir.
- **Kullanıcı İşlevleri:** Kullanıcılar, belirli bir lokasyondaki araçları listeleyebilir, araç detaylarını görüntüleyebilir ve rezervasyon yapabilir.
- **Yazar Paneli:** Yazarlar, blog ve yorum içeriklerini CRUD işlemleriyle yönetebilir.

---

## 🎯 Projenin Amacı

- Kullanıcılara, bulundukları lokasyona uygun araçları listeleyip kiralama imkânı sunmak.  
- Yazarlar ve yöneticiler için güçlü bir yönetim paneli sağlamak.  
- Bloglar ve yorumlar aracılığıyla kullanıcı deneyimini zenginleştirmek.

---

## 🛠️ Kullanılan Teknolojiler ve Uygulamalar

| Teknoloji / Uygulama        | Kullanım Amacı                                      |
|-----------------------------|----------------------------------------------------|
| **ASP.NET Core 8.0**        | Web API geliştirme                                |
| **Entity Framework Core**   | Veritabanı işlemleri (ORM)                        |
| **Onion Architecture**      | Modüler ve sürdürülebilir yapı                     |
| **CQRS & MediatR**          | Sorgu ve komut işlemlerinin ayrıştırılması         |
| **JWT (JSON Web Token)**    | Kimlik doğrulama ve yetkilendirme                 |
| **SignalR**                 | Gerçek zamanlı bildirimler                        |
| **Microsoft SQL Server**    | Veritabanı yönetimi                               |
| **FluentValidation**        | Giriş doğrulama ve iş kurallarının kontrolü       |
| **Swagger (OpenAPI)**       | API dokümantasyonu                                |
| **HTML-CSS-Bootstrap**      | Kullanıcı arayüzü tasarımı                        |
| **LINQ**                    | Veritabanı sorguları                              |

---

## 📂 Proje Yapısı (Onion Architecture)

### 🧩 Öne Çıkan Katmanlar
1. **Domain Katmanı:** Temel iş kuralları ve varlıklar (`Car`, `Location`, `Reservation` vb.).
2. **Application Katmanı:** CQRS desenine göre sorgu ve komut işlemleri.  
   Örnek: `CreateCarCommand`, `GetCarsByLocationQuery`.
3. **Persistence Katmanı:** Veritabanı erişimi (`CarConfiguration`, `HasData()` metotları ile başlangıç verileri).
4. **API Katmanı:** Kullanıcılara ve yöneticilere RESTful servisler sağlar.

---

## 🔑 Özellikler

- 🖱️ **Admin Paneli:** Marka, model, lokasyon ve araç yönetimi.  
- 👤 **Kullanıcı İşlevleri:** Araç listeleme ve rezervasyon yapma.  
- ✍️ **Blog ve Yorum Yönetimi:** Yazarlar için kolay içerik yönetimi.  
- 🔒 **JWT ile Güvenlik:** Kullanıcı oturum açma ve yetkilendirme.  
- 📡 **Gerçek Zamanlı Bildirimler:** SignalR ile anlık iletişim.

---

## 🚀 Projeyi Çalıştırma

### Gerekli Kurulumlar:
1. [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
2. [Microsoft SQL Server](https://www.microsoft.com/sql-server)

### Adımlar:

### 1. Projeyi Klonlayın:
- İlk olarak, projeyi GitHub'dan klonlayın:
```
git clone https://github.com/eypacr/CarBook.git
```
```
cd CarBook
```

### 2.Gerekli bağımlılıkları yükleyin:
```
dotnet restore
```

### 3.Veritabanını yapılandırın:
- ``appsettings.json`` dosyasındaki bağlantı dizesini (``ConnectionString``) düzenleyin.
- EF Core Migration işlemini çalıştırın:
```
dotnet ef database update
```

### 4.Projeyi başlatın:
```
dotnet run --project CarBook.API
```
