# WindowsLogSaveData
Të zhvillohet programi me C# si shërbim (Windows Service) që ruan në Windows Log të dhënat sa herë që në formë paraqitet fjala "Username", "Password" etj.

Për ta realizuar detyrën për Windows Service, që ruan të dhënat në Windows Log projektin e kemi ndarë në tre module: 
1. WcfServiceLibrary – Web Service projekt në Visual Studio i cili mundëson krijimin e Web-Services në Windows. Po ashtu është pjesa e parë e cila bëhet build.
2. SaveData – Modul përmes të cilit definohet se çfarë funksioni do të ketë Web-Service i zhvilluar. Në këtë rast ky modul ruan të dhënat e pranuara nga një Login Form në Windows Log.
OurWinForm: Një UI formë e cila mundëson dërgimin e Username dhe Password në mënyrë që të lexohen nga Web-Service i krijuar
![image](https://user-images.githubusercontent.com/44554983/205511123-f0c98b98-7e85-4d34-aeca-652ce9bfe708.png)
