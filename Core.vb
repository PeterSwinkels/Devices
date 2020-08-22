'This module's imports and settings.
Option Compare Binary
Option Explicit On
Option Infer Off
Option Strict On

Imports System
Imports System.Management

'This module contains this program's core procedures.
Public Module CoreModule

   'This procedure is executed when this program is started.
   Public Sub Main()
      For Each Item As ManagementObject In (New ManagementObjectSearcher("SELECT * From Win32_PnPEntity")).Get()
         For Each ItemProperty As PropertyData In Item.Properties
            Console.WriteLine($"{ItemProperty.Name}: {ItemProperty.Value}")
         Next ItemProperty
         Console.WriteLine()
      Next Item
   End Sub
End Module
