
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.6.1055.0




// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly ConsoleApp1
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 0B 43 6F 6E 73 6F 6C 65 41 70 70 31 00 00 ) // ...ConsoleApp1..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 0B 43 6F 6E 73 6F 6C 65 41 70 70 31 00 00 ) // ...ConsoleApp1..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 32 31 00 00 )                            //  2021..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 32 30 61 38 38 36 36 37 2D 34 36 34 32   // ..$20a88667-4642
                                                                                                  2D 34 62 39 61 2D 39 33 30 61 2D 34 37 37 62 38   // -4b9a-930a-477b8
                                                                                                  34 36 35 38 64 61 30 00 00 )                      // 4658da0..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 36 2E 31 01   // ,Version=v4.6.1.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 36 2E 31 )          // amework 4.6.1
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module ConsoleApp1.exe
// MVID: {8C85C3B3-F572-4902-ACD5-45E3410012ED}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x07C60000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit ConsoleApp1.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Размер кода:       55 (0x37)
    .maxstack  2
    .locals init ([0] string secret,
             [1] string input,
             [2] bool V_2)
    IL_0000:  nop
    IL_0001:  ldstr      "secret"
    IL_0006:  stloc.0
    IL_0007:  ldstr      "Enter password:"
    IL_000c:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0011:  nop
    IL_0012:  call       string [mscorlib]System.Console::ReadLine()
    IL_0017:  stloc.1
    IL_0018:  ldloc.1
    IL_0019:  ldloc.0
    IL_001a:  call       bool [mscorlib]System.String::op_Equality(string,
                                                                   string)
    IL_001f:  stloc.2
    IL_0020:  ldloc.2
    IL_0021:  brfalse.s  IL_0030

    IL_0023:  nop
    IL_0024:  ldstr      "!!!Welcome!"
    IL_0029:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_002e:  nop
    IL_002f:  nop
    IL_0030:  call       string [mscorlib]System.Console::ReadLine()
    IL_0035:  pop
    IL_0036:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class ConsoleApp1.Program


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 D:\TMP\GB_Education\HelloWorld_secret.res
