# 🎓 Öğrenci Kurs Kayıt Sistemi

Bu proje, ASP.NET Core MVC ve Entity Framework Core kullanılarak geliştirilmiş, öğrencilerin kurslara kaydolabildiği basit ama öğretici bir kayıt sistemidir.

---

## 🏗️ Proje Mimarisi

- ASP.NET Core MVC
- Entity Framework Core
- PostgreSQL
- Razor View (cshtml)
- Bootstrap 5 ile sade tasarım

---

## 📸 Ekran Görüntüleri

### 🎓 Öğrenci Listeleme Sayfası

<img src="https://github.com/user-attachments/assets/c18fdc5e-56a5-4751-a269-1682a34cff62" width="600"/>

### ➕ Kurs Listeleme Formu

<img src ="https://github.com/user-attachments/assets/8e482a20-bb5c-4799-8308-6a38c86bf5dd" width =600/> 


### 📚 Kurs Kayıt Oluşturma

<img src="https://github.com/user-attachments/assets/141685ca-ffe8-4727-bed0-8697a1fd9f28" width="600"/>
<br/>
<img src="https://github.com/user-attachments/assets/f202d318-a4e0-4e1f-b7ac-fe1db7801660" width="600"/>

---

## 🔗 Kullanılan Ana Yapılar

### Entity'ler:
- **Ogrenci.cs** → Ad, Soyad, Eposta, Telefon
- **Kurs.cs** → Kurs başlığı
- **KursKayit.cs** → Öğrenci ve kurs ilişkisi (many-to-many)

### Navigation Property:
- `Ogrenci.KursKayitlari`
- `Kurs.KursKayitlari`
- `KursKayit.Ogrenci`, `KursKayit.Kurs`

### Controller’lar:
- `OgrenciController`
- `KursController`
- `KursKayitController`

### Öne Çıkan Özellikler:
- CRUD işlemleri (Ekle / Listele / Güncelle / Sil)
- Navigation property kullanımı
- Dropdown liste ile ilişki seçimi
- Detay sayfasında alınan kursların listelenmesi
