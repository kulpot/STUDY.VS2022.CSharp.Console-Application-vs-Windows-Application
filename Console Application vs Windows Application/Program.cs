using System;

//ref link:https://www.youtube.com/watch?v=4OIG1E6ju5w&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=8
//

/*--------------------------------------CMD----------------------------------------
 * 
C:\Users\sunny\source\repos\Console Application vs Windows Application>cd Console Application vs Windows Application

C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application

23/09/2023  02:19 am    <DIR>          .
23/09/2023  02:19 am    <DIR>          ..
22/09/2023  10:53 pm               189 App.config
22/09/2023  10:53 pm    <DIR>          bin
22/09/2023  10:53 pm             2,434 Console Application vs Windows Application.csproj
22/09/2023  10:53 pm    <DIR>          obj
23/09/2023  02:19 am               233 Program.cs
22/09/2023  10:53 pm    <DIR>          Properties
               3 File(s)          2,856 bytes
               5 Dir(s)  490,449,571,840 bytes free

C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application>erase *.*
C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application\*.*, Are you sure (Y/N)? y

C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application

23/09/2023  02:21 am    <DIR>          .
23/09/2023  02:21 am    <DIR>          ..
22/09/2023  10:53 pm    <DIR>          bin
22/09/2023  10:53 pm    <DIR>          obj
22/09/2023  10:53 pm    <DIR>          Properties
               0 File(s)              0 bytes
               5 Dir(s)  490,449,580,032 bytes free

C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application

23/09/2023  02:21 am    <DIR>          .
23/09/2023  02:21 am    <DIR>          ..
22/09/2023  10:53 pm    <DIR>          bin
22/09/2023  10:53 pm    <DIR>          obj
23/09/2023  02:21 am               233 Program.cs
22/09/2023  10:53 pm    <DIR>          Properties
               1 File(s)            233 bytes
               5 Dir(s)  490,449,309,696 bytes free

C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application>csc /t:exe /out:MeConsole.exe Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application

23/09/2023  02:23 am    <DIR>          .
23/09/2023  02:23 am    <DIR>          ..
22/09/2023  10:53 pm    <DIR>          bin
23/09/2023  02:23 am             4,096 MeConsole.exe
22/09/2023  10:53 pm    <DIR>          obj
23/09/2023  02:22 am             2,915 Program.cs
22/09/2023  10:53 pm    <DIR>          Properties
               2 File(s)          7,011 bytes
               5 Dir(s)  490,446,663,680 bytes free



 * 
 */

class MainClass
{
    static void Main()
    {
        Console.WriteLine("Hellow World");
    }
}