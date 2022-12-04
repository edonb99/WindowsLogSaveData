# WindowsLogSaveData
Të zhvillohet programi me C# si shërbim (Windows Service) që ruan në Windows Log të dhënat sa herë që në formë paraqitet fjala "Username", "Password" etj.

Për ta realizuar detyrën për Windows Service, që ruan të dhënat në Windows Log projektin e kemi ndarë në tre module: 
1. WcfServiceLibrary – Web Service projekt në Visual Studio i cili mundëson krijimin e Web-Services në Windows. Po ashtu është pjesa e parë e cila bëhet build.
2. SaveData – Modul përmes të cilit definohet se çfarë funksioni do të ketë Web-Service i zhvilluar. Në këtë rast ky modul ruan të dhënat e pranuara nga një Login Form në Windows Log.
OurWinForm: Një UI formë e cila mundëson dërgimin e Username dhe Password në mënyrë që të lexohen nga Web-Service i krijuar

![image](https://user-images.githubusercontent.com/44554983/205511123-f0c98b98-7e85-4d34-aeca-652ce9bfe708.png)

Open Windows PowerShell > Open Windows PowerShell as administrator. Në rast që nuk e keni këtë opsion, rrugën e njejtë mund ta bëjmë edhe përmes Command Prompt.
3. Pasi të na hapet dritarja e Powershell shkruajmë : 
New-Service -Name "SaveData" -BinaryPathName C:\Users\ebuda\OneDrive\Desktop\SaveDataWindowsLog-main\SaveData\bin\Debug\SaveData.exe

![image](https://user-images.githubusercontent.com/44554983/205511166-fd215aaa-9cc1-4034-8e67-8534c52df7b5.png)

Pas ekzekutimit të komandes tek Services shikojmë:

![image](https://user-images.githubusercontent.com/44554983/205511200-13eebbe4-936b-4982-be0d-94ed66926e61.png)


Pasi që klikojmë “Regjistro”, hapim Event Viewer të cilin e kërkojmë në Start dhe pastaj hyjmë tek “Windows Log”, pastaj tek “Application”
Ky është Warning që e dërguam në Windows Log momentin që klikuam në butonin “Regjistro”:

Pasi klikuam mbi “Warning”  mund t’i shohim të dhënat te cilat janë ruajtur në log:


![image](https://user-images.githubusercontent.com/44554983/205511267-e84fc0e9-c1af-47f2-8657-788befb6aa9c.png)
