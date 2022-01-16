Merhaba,

Kullanýcýlarýn A þehrinden B þehrine þahsi arabalarý ile seyehat ederken yolcu bulacaðý API,

.Net Core 5.0 da geliþtirilmiþtir.
AdessoRideShareAPI olmak üzere bir adet service bulunmaktadýr.
Database olarak serviste MSSQL kullanýlmýþtýr. Db le iletiþime geçerken ORM araçlarýndan EntityFramework Core kullanýlmýþtýr.
Proje development branchinde adým adým geliþtirilmiþ, commitlenmiþ, master branchine merge edilmiþtir.
Servisle HTTP üzerinden iletiþim kurulmaktadýr.
Proje NLayerArchitecture olarak geliþtirilip, SOLID e uygun kodlama yapýlmýþtýr.


Servis Kestrelde 5002 portundan ayaða kalkmaktadýr.Ports.txt dokümanýnda belirtilmiþtir.
Projenin migration yapýsý code first olarak geliþtirilmiþ,   servis ayaða kalktýðýnda db oluþacaktýr.
Db connection stringi servisin appsettings.json dosyasýndan ilgili bölümün   tarafýnýzca düzenlenmesi gerekmektedir.

Kullanýcý ilgili endpointlerden seyehat planý ekleme ve kaldýrma iþlemi yapabilecektir.
Sistemdeki herhangi bir seyehate koltuk sayýsý dolmamýþsa istek gönderebileceklerdir.
Seyehat planlarýný nereden nereye olarak aratabileceklerdir.
Kullanýcýlar sisteme eklenebileceklerdir.

Hata mekanizmasý için kod tekrarýný önlemek, temiz kod yazýmýný saðlamak adýna filterlar eklenilmesi gerektiðinin farkýnda olunup, süre kýsýtýndan dolayý eklenememiþtir.
Servisin güvenliði açýsýndan bir token mekanýzmasý (JWT) süre nedeniyle eklenememiþtir.
Best practise ler not alýnýp, belirtilmiþtir.

Projede bulunan endpointler aþaðýda verilmiþtir. Ayrýca projenin endpoint kullaným dokümaný olan swagger entegrasyonu mevcuttur.



Teþekkürler.


http://localhost:5002/api/TravelPlan HttpPost

http://localhost:5002/api/TravelPlan?id=1 HttpDelete (id=TravelPlanId)

http://localhost:5002/api/TravelPlan HttpGet (fromWheretowhere)

http://localhost:5002/api/TravelPlan/SendJoinRequest HttpPost

http://localhost:5002/api/user HttpPost KullanýcýEkle

http://localhost:5002/api/user HttpDelete KullanýcýKaldýr

http://localhost:5002/api/TravelPlan/ShowRoute HttpGet -opsiyonel olan 2. bölüm için oluþturulmuþtur.

örnek travelPlan post body
{
  "fromWhere": "A",
  "toWhere": "F",
  "travelTime": "2022-01-15T20:14:02.189Z",
  "numberOfSeats": 5,
  "explanation": "Seyehat Dizel araçla 100 km hýzda 2 mola vererek gerçeklestirilecektir.",
  "route": "A,B,O,P,M,N,F"
}