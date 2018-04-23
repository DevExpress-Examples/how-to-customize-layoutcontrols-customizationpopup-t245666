Imports Microsoft.VisualBasic
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("CustomizationPopup")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("Microsoft")>
<Assembly: AssemblyProduct("CustomizationPopup")>
<Assembly: AssemblyCopyright("Copyright © Microsoft 2011")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

#If SILVERLIGHT Then
' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("7b0e3edb-d165-4016-a604-549d3631e8b1")>
<Assembly: AssemblyVersion("1.0.0.0")>
#Else
	'(used if a resource is not found in the page, 
	' or application resource dictionaries)
	'(used if a resource is not found in the page, 
	' app, or any theme specific resource dictionaries)
<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly), assembly: AssemblyVersion("1.0.0.0")>
#End If

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Revision and Build Numbers 
' by using the '*' as shown below:
<Assembly: AssemblyFileVersion("1.0.0.0")>
