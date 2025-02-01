RoomFinity Projesi

🏨 Bu proje M&Y Yazılım Eğitim Akademi Danışmanlık bünyesinde Murat Yücedağ eğitmenliği tarafından verilen eğitim kapsamındaki 6. projedir. RoomFinity adını verdiğim bu proje RapidApi üzerinde bulunan Booking API kullanılarak geliştirilmiş bir otel bulma projesidir. Kullanıcıların belirlediği kriterlere uygun otelleri api üzerinden çekip sitede listeleme işlemi gerçekleştirilmiştir.

Anasayfa
🔍 Kullanıcılardan aşağıdaki bilgiler alınır:

🗺️ Filtrelemek istedikleri şehir bilgisi

📅 Giriş ve çıkış tarihleri

👤 Yetişkin kişi sayısı

🧒 Çocuk sayısı

Sonuç Sayfası
✔️ Girilen kriterlere uyan oteller liste halinde gösterilir.

ℹ️ Kullanıcılar listelenen otellerin şu bilgilerine erişebilir:

🏠 Otel adı

⭐ Otel puanı

👥 Kaç kişi tarafından değerlendirme yapıldığı

🛠️ Kullanılan Teknolojiler
💻 Asp.Net Core(6.0) ile geliştirildi.

🏗️ Tek katmanlı yapı ile işlemler gerçekleştirildi.

🌐 Booking API'nin üç farklı endpoint'i kullanıldı:

🔍 Auto Complete Endpoint:

Kullanıcının girdiği şehir bilgisine karşılık gelen şehir ID'si ve Destination ID'si elde edildi.
🏨 Search Hotels Endpoint:

Elde edilen şehir ID'si ve diğer filtreleme kriterleri kullanılarak otellerin listesi çekildi.
🖼️ Get Hotel Photos Endpoint:

Elde edilen otellerin ID'si kullanılarak ilgili otellerin fotoğrafları çekildi.
📦 ViewModel Kullanımı:

API'den gelen JSON verilerini karşılamak ve yönetmek için ViewModel yapıları oluşturuldu.
📌 Proje Detayları
1️⃣ API entegrasyonu sırasında şehir ID'si ve Destination ID'sine ulaşmak için öncelikle Auto Complete Endpoint'ine istek gönderilir, parametre olarak kullanıcının girdiği şehir bilgisi gönderilir.

2️⃣ Buradan elde edilen şehir ID'si, sonrasında Search Hotels Endpoint'ine gönderilerek kriterlere uygun otel bilgileri alınır, parametre olarak şehir ID'si dışında kullanıcının girdiği diğer kriterler de bu aşamada gönderilir.

3️⃣ Uygun otel bilgileri alındıktan sonra buradaki otellerin otel ID'leri alınır ve Get Hotel Photos Endpoint'ine istek gönderilir. Buradan gelen yanıt ile ilgili otellerin fotoğrafları da elde edilmiş olur.

4️⃣ JSON veri yapısı, ViewModel'ler ile düzenlenip proje içerisinde kullanılabilir hale getirilmiştir.

🖼️ Proje Görselleri 
![1](https://github.com/user-attachments/assets/637e81b8-c45a-4a0b-909f-0a7546d1731a)
![2](https://github.com/user-attachments/assets/600387ca-5c1f-4709-ba56-6c4f5bc1d1b9)
![3](https://github.com/user-attachments/assets/6a28bd47-b5cc-427c-beac-a1d8f349f89b)
![4](https://github.com/user-attachments/assets/b2b73de0-2013-48f5-851c-68612507cf49)
![5](https://github.com/user-attachments/assets/db54c413-ee47-473a-838b-504744dd8d16)
![6](https://github.com/user-attachments/assets/92b3693c-582a-4356-8b21-9fa38ec8177c)
![7](https://github.com/user-attachments/assets/88196ad2-e817-44f2-b1e8-11e7763bda6d)
![8](https://github.com/user-attachments/assets/68a63dd4-8ebf-48f3-8e32-67e090ffab03)
![9](https://github.com/user-attachments/assets/6c453fdc-0370-442a-8fbc-5cd5c8e9c811)
![10](https://github.com/user-attachments/assets/fa482a82-15c6-4463-80fc-17586b4d3563)









https://github.com/user-attachments/assets/a4b9a44f-5dcf-4a16-be26-df0b9ab78eee




