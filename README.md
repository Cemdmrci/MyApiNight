# MyApiNight Projesi
Bu proje, kitap yönetimi için geliştirilmiş modern bir API ve web uygulamasıdır. Proje geliştirme sürecinde N-Tier Architecture prensiplerine tam anlamıyla uyulmuştur.
## Katmanlı Mimari Yapısı
Proje, birbirinden bağımsız çalışabilen ve sorumlulukları net bir şekilde ayrılmış 5 ana katmandan oluşmaktadır:  
📃 EntityLayer  
Veritabanı tablolarını temsil eden entity sınıflarını içerir.    
🔎 DataAccessLayer  
Veritabanı işlemlerini yönetir ve repository pattern'ini uygular.    
⚙️ BusinessLayer  
İş mantığını kapsar ve veri doğrulama işlemlerini gerçekleştirir.    
🌐 WebApi  
RESTful API endpoint'lerini içerir ve dış dünya ile iletişimi sağlar.    
📚 WebUI  
Kullanıcı dostu bir arayüz sunarak kitap yönetim işlemlerini kolaylaştırır.  
## Proje Özellikleri
- Identity Kütüphanesi kullanılarak ASP.NET Core 6.0 ile geliştirildi.
- Veritabanı olarak MSSQL tercih edildi.
- Entity Framework ile Code First yaklaşımıyla geliştirildi.
- Anasayfa'da "En Çok Satan Kitabımız" alanında sayfa her yüklendiğinde rastgele olarak bir kitap listelenmektedir.
- Son eklenen 4 kitap " Eklenen Son Kitaplarımız" başlığı altında listelenmektedir.
- Kategori Bazlı Kitap Filtrelemesi yapılabilmektedir.
- Admin panelinde ise "Öne Çıkanlar", "Kategoriler", "Yazarlar" ve "Kitaplar" için ayrı ayrı CRUD işlemleri gerçekleştirilebilmektedir.

## Kullanılan Teknolojiler
- Asp.Net Core 6.0
- Entity Framework / Code First
- MSSQL Veritabanı
- Repository Design Pattern
- N-Tier Architecture
- Identity Kütüphanesi
- ViewComponents
- DTOs (Data Transfer Objects)
- DataTable
- LINQ Sorguları
  ## Proje İçerisinden Görüntüler
  ![screencapture-localhost-7026-Register-Index-2025-01-27-22_04_27](https://github.com/user-attachments/assets/c7c84d38-5d3f-4b91-9fc9-90e092e87893)
![screencapture-localhost-7026-Login-Index-2025-01-27-22_05_15](https://github.com/user-attachments/assets/0775bd36-92cb-4a6a-95a3-2154c8c39d1b)
![screencapture-localhost-7026-Admin-Dashboard-Index-2025-01-27-22_05_42](https://github.com/user-attachments/assets/70b32545-1829-42b8-a4dc-acd35b945ad2)
![screencapture-localhost-7026-Admin-Feature-FeatureList-2025-01-27-22_05_55](https://github.com/user-attachments/assets/e9dc32ce-881a-4c17-b9e2-f2300c3423bb)
![screencapture-localhost-7026-Admin-Category-CategoryList-2025-01-27-22_06_10](https://github.com/user-attachments/assets/bdd96ae6-77fd-4ed6-a487-b9437025500c)
![screencapture-localhost-7026-Admin-Writer-WriterList-2025-01-27-22_06_25](https://github.com/user-attachments/assets/4de7a02d-30a3-4789-8091-df8bf29e84d7)
![screencapture-localhost-7026-Admin-Writer-CreateWriter-2025-01-27-22_06_35](https://github.com/user-attachments/assets/65f8e9ed-2d5c-45a6-8494-74c8b56aaa6d)
![screencapture-localhost-7026-Admin-Book-BookList-2025-01-27-22_06_46](https://github.com/user-attachments/assets/132811f5-c6f9-4584-968c-5cb26c20ac80)
![Ekran görüntüsü 2025-01-27 220737](https://github.com/user-attachments/assets/0da0f223-95d2-4458-8ce8-e965f549cd42)
![Ekran görüntüsü 2025-01-27 220757](https://github.com/user-attachments/assets/4f8d49eb-abd3-4474-a94b-dce7f5aca19e)
![Ekran görüntüsü 2025-01-27 220819](https://github.com/user-attachments/assets/463a1146-7633-4f71-aa25-0f70e2812ac8)
![Ekran görüntüsü 2025-01-27 220838](https://github.com/user-attachments/assets/b7e586eb-2fe9-44a7-9b8e-22595e93998e)
![Ekran görüntüsü 2025-01-27 220853](https://github.com/user-attachments/assets/717f4009-2bb7-4787-a818-3bc6cd648e5b)
![Ekran görüntüsü 2025-01-27 220916](https://github.com/user-attachments/assets/af0e19ab-53ad-4495-b771-22cfe1503085)
