## DÜZCE ÜNİVERSİTESİ TEKNOLOJİ FAKÜLLTESİ BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ GÖRSEL PROGRAMLAMA DERSİ FİNAL PROJESİ

### KÜTÜPHANE OTOMASYONU
* **Katmanlı mimari ile yapılmıştır.**
* **Entity framework core kullanılmıştır.**
* **Database olarak Sqlite kullanılmıştır.**
* **Generic yapı kullanılmıştır**
* **Kullancı yetkilendirme sistemi vardır.(admin-öğrenci)**

-------------------------------------------------------------

## Katmanlı Mimari Nedir?

![image](https://drive.google.com/uc?export=view&id=1owF8-030fRAy4_P1U0KETte2bvVwjwj-)

Yukarıdaki resime göre katmanları tanımlayacak olursak;

**Data Access Layer :** Bu katmanda sadece veritabanı işlemleri yapılmaktadır. Bu katmanın görevi veriyi ekleme, silme, güncelleme ve veritabanından çekme işlemidir. Bu katmanda bu işlemlerden başka herhangi bir işlem yapılmamaktadır.


**Business Logic Layer :** Bu katmanda iş yüklerimizi yazıyoruz. Öncelikle şunu söylemeliyim bu katman Data Access tarafından projeye çekilmiş olan verileri alarak işleyecek olan katmandır. Biz uygulamalarımızda Data Access katmanını direk olarak kullanmayız. Araya Business katmanını koyarak bizim yerimize Business’ın yapmasını sağlarız. Kullanıcıdan gelen veriler öncelikle Business katmanına gider oradan işlenerek Data Access katmanına aktarılır.


**Presentation Layer:** Bu katman kullanıcı ile etkileşimin yapıldığı katmandır. Burası Windows form da olabilir, Web’te olabilir veya Bir Consol uygulamasında olabilir. Burada temel amaç kullanıcıya verileri göstermek ve kullanıcıdan gelen verileri Business Katmanı ile Data Access’e iletmektir.

**Bu projedeki katman görünümleri şu şekildedir.**

![image](https://drive.google.com/uc?export=view&id=1nDfNVsdNsklCk00W5Wz4I2YWlyj1BSGu)

-----------------------------------------------------------------------
![image](https://drive.google.com/uc?export=view&id=1nu3CQpVuWLVLiCm-8HvIOkjeTWqMpwrG)

##Entity Frame Work - Core Nedir?


**Entity Framework ORM(Object Relational Mapping)** araçlarından biridir. ORM nedir dersek: İlişkisel veritabanı ile nesneye yönelik programlama(OOP) arasında bir köprü görevi gören araçtır. Bu köprü, ilişkisel veritabanındaki bilgilerimizi yönetmek için nesne modellerimizi kullandığımız bir yapıdır. Kısaca veritabanına bizim nesnelerimizi bağlayan ve bizim için veri alışverişini yapan Microsoft tarafından geliştirilmiş bir framework’tür

--------------------------------------------------------------------------
## Kurulum
[Buradaki linkten](https://drive.google.com/file/d/1taLivGjHSuiY5QrnoBVVssN3QD05vomp/view?usp=sharing) projeyi kurulumun dosyasını indirebilirsiniz.**"KutuphaneYonetimSistemi.msi"** dosyasını çalıştırarak kurulumu gerçekleştirebilirsiniz.

