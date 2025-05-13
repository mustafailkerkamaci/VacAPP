![vacappconsole](https://github.com/user-attachments/assets/2b55d4af-9cf3-4212-a61f-4f3b6bf05b03)

# VacApp - Tatil Planlama Uygulaması

## 📌 Proje Hakkında

**VacApp**, kullanıcıların tatil planlarını kolayca yapabilmesi için tasarlanmış basit bir konsol uygulamasıdır. Uygulama, kullanıcıdan tatil için gitmek istediği konumu, kaç kişi olduklarını ve ulaşım tercihini aldıktan sonra toplam tatil maliyetini hesaplar.
Uygulama tekrar eden planlamalara olanak tanımak için kullanıcıya birden fazla plan yapma seçeneği sunar.

## 🚀 Özellikler

- Kullanıcıdan tatil konumunu alma (Bodrum, Marmaris, Çeşme)
- Geçerli giriş sağlanana kadar tekrar eden doğrulama kontrolleri
- Kişi sayısına göre ulaşım ve konaklama ücretlerini hesaplama
- Ulaşım tipi seçimi (Kara yolu / Hava yolu)
- Birden fazla tatil planı yapılabilme seçeneği
- Konsol ekranında toplam ücret hesaplaması ve gösterimi

## 🧮 Ücret Hesaplama Kuralları

| Konum     | Başlangıç Ücreti (Kişi başı) |
|-----------|-------------------------------|
| Bodrum    | 4000 TL                       |
| Marmaris  | 3000 TL                       |
| Çeşme     | 5000 TL                       |

| Ulaşım Tipi | Ücret (Kişi başı, Gidiş-Dönüş) |
|-------------|---------------------------------|
| Karayolu    | 1500 TL                         |
| Havayolu    | 4000 TL                         |

Toplam ücret şu şekilde hesaplanır:

Toplam Ücret = (Kişi Sayısı x Ulaşım Ücreti) + (Kişi Sayısı x Konum Ücreti)
