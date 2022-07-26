# Reseller
Vehicle/Estate Marketing Application

## Giriş
Çalışmada belirlenen amaç,bir uygulama gerçekleştirimi ile beraber Emlak/Araç satışının ya da kiralanmasının sağlandığı bir uygulama gerçekleştirilmesidir.

## Yöntem
ASP.NET Core tabanlı yapı kullanılarak bir web uygulaması hazırlanmıştır.

C# yazılım dili kullanılmıştır.

Kodun yazıldığı platform Visual Studio 2019'dur.

Veritabanı Database First EF Core yöntemiyle oluşturulmuştur.

Scaffold metoduyla Package Manager Console'da MSSQL Server'ın bağlı olduğu "Connection String" (Ör:(localdb)\MSSQLLocalDB) sunucu ve oluşturulan database ismi girilerek Models klasörü içerisinde veritabanında bulunan tabloların içindeki değişkenler oluşturuldu.

Sonrasında kullanıcıların erişebileceği basit bir arayüz oluşturuldu.

Kullanıcı bilgilerine göre Controller dosyaları ve Views klasörü altında .cshtml uzantılı arayüz dosyaları üretildi.
