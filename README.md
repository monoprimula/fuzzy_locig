Bulanık Mantık ile Çamaşır Makinesi Kontrol Sistemi


Bu proje, C# ve Windows Forms kullanılarak geliştirilmiş bir Bulanık Mantık Denetleyici (Fuzzy Logic Controller) uygulamasıdır. Uygulama, bir çamaşır makinesinin deterjan miktarı, yıkama süresi ve tambur dönüş hızını; çamaşırın hassaslığı, kirlilik derecesi ve miktarına göre belirlemektedir.

🎯 Proje Amacı
Bulanık mantık kullanılarak bir çamaşır makinesi kontrol sisteminin modellenmesi ve gerçeklenmesi. Hazır bulanık mantık kütüphaneleri kullanılmadan, tüm mantık kuralları, üyelik fonksiyonları, Mamdani çıkarım ve ağırlıklı ortalama durulaştırma yöntemleri manuel olarak kodlanmıştır.

🧩 Girdi Değişkenleri
Hassaslık (0.00 - 10.00)

Miktar (0.00 - 10.00)

Kirlilik (0.00 - 10.00)

Her bir değişken için üçgen üyelik fonksiyonları kullanılmıştır (örn. Küçük, Orta, Büyük).

🔁 Çıktı Değişkenleri
Dönüş Hızı

Süre

Deterjan Miktarı

Çıktılar, Mamdani çıkarım mekanizması ve Ağırlıklı Ortalama durulaştırma yöntemi ile hesaplanır.

🖼️ Arayüz Özellikleri
Girdi değerleri kullanıcı tarafından girilebilir.

Girişlere uygun olarak tetiklenen kurallar görüntülenir.

Üyelik fonksiyonları grafiklerle (isteğe bağlı) gösterilir.

Tüm hesaplamalar adım adım yapılır ve sonuçlar gösterilir.

Kurallar tablo olarak listelenir.

📷 Ekran Görüntüsü

![image](https://github.com/user-attachments/assets/04bca9be-7753-4f22-bfc4-030abda0eafe)

![image](https://github.com/user-attachments/assets/ac3d0eef-a106-4064-a45f-bda8283a6075)

⚙️ Nasıl Çalıştırılır?
Projeyi Visual Studio’da açın.

Windows Forms App (.NET Framework) projesi olarak başlatın.

Form1.cs noktasını başlangıç değeri olarak belirleyerek uygulamayı çalıştırın. 

Değerleri değiştirdiğinizde işlemler otomatik olarak uygulanacaktır.
