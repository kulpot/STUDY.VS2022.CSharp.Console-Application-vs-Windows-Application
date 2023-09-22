using System;

//ref link:https://www.youtube.com/watch?v=4OIG1E6ju5w&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=8
// .subsystem 0x0003 - Console App, .subsystem 0x0002 - Windows App -> 1 Bit difference

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

-------------------------CONSOLE APP: Created---------------------------------------
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

C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application>MeConsole.exe
Hellow World
-------------------------CONSOLE APP------------------------------------END
-------------------------WINDOWS APP: Created----------------------------

C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application>csc /t:winexe /out:MeWindows.exe Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application

23/09/2023  02:28 am    <DIR>          .
23/09/2023  02:28 am    <DIR>          ..
22/09/2023  10:53 pm    <DIR>          bin
23/09/2023  02:23 am             4,096 MeConsole.exe
23/09/2023  02:28 am             4,096 MeWindows.exe
22/09/2023  10:53 pm    <DIR>          obj
23/09/2023  02:27 am             4,264 Program.cs
22/09/2023  10:53 pm    <DIR>          Properties
               3 File(s)         12,456 bytes
               5 Dir(s)  490,445,430,784 bytes free

-------------------------WINDOWS APP------------------------------------END

C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application>MeWindows.exe

C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application>MeConsole.exe
Hellow World

C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application>ildasm /out:MeConsole.txt MeConsole.exe

C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application>ildasm /out:MeWindows.txt MeWindows.exe

C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application>MeConsole.txt
------------------------NOTEPAD: MeConsole.txt--------------------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly MeConsole
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module MeConsole.exe
// MVID: {A7863F65-5F2C-43FA-B21A-3080D594090B}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x067C0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000e:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class private auto ansi beforefieldinit MainClass
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main() cil managed
  {
    .entrypoint
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "Hellow World"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ret
  } // end of method MainClass::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method MainClass::.ctor

} // end of class MainClass


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file MeConsole.res


------------------------NOTEPAD: MeConsole.txt--------------------------------END

C:\Users\sunny\source\repos\Console Application vs Windows Application\Console Application vs Windows Application>MeWindows.txt
------------------------NOTEPAD: MeWindows.txt--------------------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly MeWindows
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module MeWindows.exe
// MVID: {75991E5A-A98D-4781-980B-12D05CF82675}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0002       // WINDOWS_GUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x06910000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000e:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class private auto ansi beforefieldinit MainClass
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main() cil managed
  {
    .entrypoint
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "Hellow World"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ret
  } // end of method MainClass::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method MainClass::.ctor

} // end of class MainClass


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file MeWindows.res


------------------------NOTEPAD: MeWindows.txt--------------------------------END




 * 
 */

class MainClass
{
    static void Main()
    {
        Console.WriteLine("Hellow World");
    }
}