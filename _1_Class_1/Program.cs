using _1_Class_1; // namespacesi program.cs'ye dahil eder bu namespace içerisindeki kodlara erişeceğimiz belirtiyoruz...

#region aciklama

// Class ve Nesne

//string[] ogrenciAdlari = new string[10];
//ogrenciAdlari[0] = "Ziya";
//ogrenciAdlari[1] = "İsmail";

//float[] vizeler = new float[10];
//vizeler[0] = 60;
//vizeler[1] = 70;

//float[] finaller = new float[10];
//finaller[0] = 60;
//finaller[1] = 50;

// new ifadesi ile Ogrenci tipinde yeni bir nesne oluşturduk...
// new ifadesi ile bellekte yeni bir alan açılır..bu alanda kendine bağlı tiplerin (verilerin) referansı tululur..
// Sınıf üyelerine sınıf üzerinden değil nesnesi üzerinden erişlebilir. yani ogrenci sınıfının üyelerine ogr1 nesnesi üzerinden erişebiliriz.

#endregion
Ogrenci ogr1 = new Ogrenci();
ogr1.Adi = "Ziya";
ogr1.Vize = 60;
ogr1.Final = 60;

Ogrenci ogr2 = new Ogrenci();
ogr2.Adi = "İsmail";
ogr2.Vize = 70;
ogr2.Final = 50;

Console.WriteLine($"Adı ={ogr1.Adi} Vize = {ogr1.Vize} Final = {ogr1.Final} Ort = {ogr1.Ortalama()}");
Console.WriteLine($"Adı ={ogr2.Adi} Vize = {ogr2.Vize} Final = {ogr2.Final} Ort = {ogr2.Ortalama()}");

Console.ReadKey();