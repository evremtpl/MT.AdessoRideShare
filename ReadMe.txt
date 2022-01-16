Merhaba,

Kullan�c�lar�n A �ehrinden B �ehrine �ahsi arabalar� ile seyehat ederken yolcu bulaca�� API,

.Net Core 5.0 da geli�tirilmi�tir.
AdessoRideShareAPI olmak �zere bir adet service bulunmaktad�r.
Database olarak serviste MSSQL kullan�lm��t�r. Db le ileti�ime ge�erken ORM ara�lar�ndan EntityFramework Core kullan�lm��t�r.
Proje development branchinde ad�m ad�m geli�tirilmi�, commitlenmi�, master branchine merge edilmi�tir.
Servisle HTTP �zerinden ileti�im kurulmaktad�r.
Proje NLayerArchitecture olarak geli�tirilip, SOLID e uygun kodlama yap�lm��t�r.


Servis Kestrelde 5002 portundan aya�a kalkmaktad�r.Ports.txt dok�man�nda belirtilmi�tir.
Projenin migration yap�s� code first olarak geli�tirilmi�,   servis aya�a kalkt���nda db olu�acakt�r.
Db connection stringi servisin appsettings.json dosyas�ndan ilgili b�l�m�n   taraf�n�zca d�zenlenmesi gerekmektedir.

Kullan�c� ilgili endpointlerden seyehat plan� ekleme ve kald�rma i�lemi yapabilecektir.
Sistemdeki herhangi bir seyehate koltuk say�s� dolmam��sa istek g�nderebileceklerdir.
Seyehat planlar�n� nereden nereye olarak aratabileceklerdir.
Kullan�c�lar sisteme eklenebileceklerdir.

Hata mekanizmas� i�in kod tekrar�n� �nlemek, temiz kod yaz�m�n� sa�lamak ad�na filterlar eklenilmesi gerekti�inin fark�nda olunup, s�re k�s�t�ndan dolay� eklenememi�tir.
Servisin g�venli�i a��s�ndan bir token mekan�zmas� (JWT) s�re nedeniyle eklenememi�tir.
Best practise ler not al�n�p, belirtilmi�tir.

Projede bulunan endpointler a�a��da verilmi�tir. Ayr�ca projenin endpoint kullan�m dok�man� olan swagger entegrasyonu mevcuttur.



Te�ekk�rler.


http://localhost:5002/api/TravelPlan HttpPost

http://localhost:5002/api/TravelPlan?id=1 HttpDelete (id=TravelPlanId)

http://localhost:5002/api/TravelPlan HttpGet (fromWheretowhere)

http://localhost:5002/api/TravelPlan/SendJoinRequest HttpPost

http://localhost:5002/api/user HttpPost Kullan�c�Ekle

http://localhost:5002/api/user HttpDelete Kullan�c�Kald�r

http://localhost:5002/api/TravelPlan/ShowRoute HttpGet -opsiyonel olan 2. b�l�m i�in olu�turulmu�tur.

�rnek travelPlan post body
{
  "fromWhere": "A",
  "toWhere": "F",
  "travelTime": "2022-01-15T20:14:02.189Z",
  "numberOfSeats": 5,
  "explanation": "Seyehat Dizel ara�la 100 km h�zda 2 mola vererek ger�eklestirilecektir.",
  "route": "A,B,O,P,M,N,F"
}