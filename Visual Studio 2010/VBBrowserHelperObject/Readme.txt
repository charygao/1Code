﻿================================================================================
       Windows APPLICATION: VBBrowserHelperObject Overview                        
===============================================================================
/////////////////////////////////////////////////////////////////////////////
Summary:
The sample demonstrates how to create and deploy a Browser Helper Object. A Browser
Helper Object runs within Internet Explorer and offers additional services,  and 
the BHO in this sample is used to disable the context menu in IE.

To add a BHO to IE, this class should be registered to COM with a class ID (CLSID,
{C42D40F0-BEBF-418D-8EA1-18D99AC2AB17} in this sample), and add a key under 
"HKLM\Software\Microsoft\Windows\CurrentVersion\Explorer\Browser Helper Objects".

NOTE: 
1. On 64bit machine, 32bit IE will use 
   "HKLM\Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\Browser Helper Objects"

2. On Windows Server 2008 or Windows Server 2008 R2, the Internet Explorer Enhanced 
   Security Configuration (IE ESC) is set to On by default, which means that this BHO
   can not be loaded by IE. You have to turn off IE ESC for you. 


/////////////////////////////////////////////////////////////////////////////
Setup and Removal:

--------------------------------------
In the Development Environment

A. Setup

For 32bit IE on x86 or x64 OS, run 'Visual Studio Command Prompt (2010)' in the 
Microsoft Visual Studio 2010 \ Visual Studio Tools menu as administrator. For 64bit
IE on x64 OS, run Visual Studio x64 Win64 Command Prompt (2010).

Navigate to the folder that contains the build result VBBrowserHelperObject.dll and 
enter the command:

    Regasm.exe VBBrowserHelperObject.dll /codebase

The BHO is registered successfully if the command prints:
    "Types registered successfully"

B. Removal

For 32bit IE on x86 or x64 OS, run 'Visual Studio Command Prompt (2010)' in the 
Microsoft Visual Studio 2010 \ Visual Studio Tools menu as administrator. For 64bit
IE on x64 OS, run Visual Studio x64 Win64 Command Prompt (2010).

Navigate to the folder that contains the build result VBBrowserHelperObject.dll and 
enter the command:

    Regasm.exe VBBrowserHelperObject.dll /unregister

The BHO is unregistered successfully if the command prints:

    "Types un-registered successfully"

--------------------------------------
In the Deployment Environment

A. Setup

For 32bit IE on x86 or x64 OS, install VBBrowserHelperObjectSetup(x86).msi, the output
of the VBBrowserHelperObjectSetup(x86) setup project.

For 64bit IE on x64 OS, install VBBrowserHelperObjectSetup(x64).msi outputted by the 
VBBrowserHelperObjectSetup(x64) setup project.

B. Removal

For 32bit IE on x86 or x64 OS, uninstall VBBrowserHelperObjectSetup(x86).msi, the 
output of the VBBrowserHelperObjectSetup(x86) setup project. 

For 64bit IE on x64 OS, uninstall VBBrowserHelperObjectSetup(x64).msi, the output of
the VBBrowserHelperObjectSetup(x64) setup project.



////////////////////////////////////////////////////////////////////////////////
Demo:
 
Step1. Open this project in VS2010 and set the platform of the solution to x86. Make
       sure that the projects VBBrowserHelperObject and VBBrowserHelperObjectSetup(x86)
	   are selected to build in Configuration Manager.

	   NOTE: If you want to use this BHO in 64bit IE, set the platform to x64 and 
	         select VBBrowserHelperObject and VBBrowserHelperObjectSetup(x64) to build.
        
Step2. Build the solution.
 
Step3. Right click the project VBBrowserHelperObjectSetup(x86) in Solution Explorer, 
       and choose "Install".

	   After the installation, open 32bit IE and click Tools=>Manage Add-ons, in the 
	   Manage Add-ons dialog, you can find the item 
	   "VBBrowserHelperObject.BHOIEContextMenu" and make sure it is enabled. You may 
	   have to restart IE to make it take effect. 

	   NOTE: You can also use the Regasm command in the "Setup and Removal" section.
 
Step4. Open IE and visit http://www.microsoft.com/. After the page was loaded 
       completely, right click this page and you will find that the context menu is 
	   disabled.


/////////////////////////////////////////////////////////////////////////////
Implementation:

A. Create the project and add references

In Visual Studio 2010, create a Visual Basic / Windows / Class Library project 
named "VBBrowserHelperObject". 

Right click the project in Solution Explorer and choose "Add Reference". Add
"Microsoft HTML Object Library" and "Microsoft Internet Controls" in COM tab.
-----------------------------------------------------------------------------

B. Implement a basic Component Object Model (COM) DLL

A Browser Helper Object is a COM object implemented as a DLL. Making a basic 
.NET COM component is very straightforward. You just need to define a 
'public' class with ComVisible(true), use the Guid attribute to specify its 
CLSID, and explicitly implements certain COM interfaces. For example, 

<ComVisible(True), ClassInterface(ClassInterfaceType.None),
Guid("C42D40F0-BEBF-418D-8EA1-18D99AC2AB17")>
Public Class SimpleObject
    Implements ISimpleObject
	...
EndClass


You even do not need to implement IUnknown and class factory by yourself 
because .NET Framework handles them for you.

-----------------------------------------------------------------------------

C. Implement the IObjectWithSite interface. 


The BHOIEContextMenu.cs file defines the BHO. 

The class also implements the IObjectWithSite interface. In the SetSite method, you 
can get an instance implemented the InternetExplorer interface.

     Public Sub SetSite(ByVal site As Object) Implements IObjectWithSite.SetSite
        If site IsNot Nothing Then
            ieInstance = CType(site, InternetExplorer)

            ' Register the DocumentComplete event.
            AddHandler ieInstance.DocumentComplete, AddressOf ieInstance_DocumentComplete
        End If
    End Sub

    Public Sub GetSite(ByRef guid_Renamed As Guid,
                       <System.Runtime.InteropServices.Out()> ByRef ppvSite As Object) _
                   Implements IObjectWithSite.GetSite
        Dim punk As IntPtr = Marshal.GetIUnknownForObject(ieInstance)
        ppvSite = New Object()
        Dim ppvSiteIntPtr As IntPtr = Marshal.GetIUnknownForObject(ppvSite)
        Dim hr As Integer = Marshal.QueryInterface(punk, guid_Renamed, ppvSiteIntPtr)
        Marshal.ThrowExceptionForHR(hr)
        Marshal.Release(ppvSiteIntPtr)
        Marshal.Release(punk)
    End Sub


-----------
Register the BHO:

The registration and unregistration logic of the BHO are also implemented in 
this class. To register a BHO, a new key should be created under the key:

HKLM\Software\Microsoft\Windows\CurrentVersion\Explorer\Browser Helper Objects


-----------------------------------------------------------------------------

D. Deploying the BHO with a setup project.

  (1) In BHOIEContextMenu, add an Installer class (named BHOInstaller in this 
   code sample) to define the custom actions in the setup. The class derives from
   System.Configuration.Install.Installer. We use the custom actions to 
   register/unregister the COM-visible classes in the current managed assembly
   when user installs/uninstalls the component. 

    <RunInstaller(True), ComVisible(False)>
Partial Public Class BHOInstaller
    Inherits Installer
    Public Sub New()
        InitializeComponent()
    End Sub
 
    Public Overrides Sub Install(ByVal stateSaver As System.Collections.IDictionary)
        MyBase.Install(stateSaver)

        Dim regsrv As New RegistrationServices()
        If Not regsrv.RegisterAssembly(Me.GetType().Assembly,
                                       AssemblyRegistrationFlags.SetCodeBase) Then
            Throw New InstallException("Failed To Register for COM")
        End If
    End Sub
   
    Public Overrides Sub Uninstall(ByVal savedState As System.Collections.IDictionary)
        MyBase.Uninstall(savedState)
        Dim regsrv As New RegistrationServices()
        If Not regsrv.UnregisterAssembly(Me.GetType().Assembly) Then
            Throw New InstallException("Failed To Unregister for COM")
        End If
    End Sub

End Class

  In the overriden Install method, we use RegistrationServices.RegisterAssembly 
  to register the classes in the current managed assembly to enable creation 
  from COM. The method also invokes the static method marked with 
  ComRegisterFunctionAttribute to perform the custom COM registration steps. 
  The call is equivalent to running the command: 
  
    "Regasm.exe VBBrowserHelperObject.dll /codebase"

  in the development environment. 

  (2) To add a deployment project, on the File menu, point to Add, and then 
  click New Project. In the Add New Project dialog box, expand the Other 
  Project Types node, expand the Setup and Deployment Projects, click Visual 
  Studio Installer, and then click Setup Project. In the Name box, type 
  VBBrowserHelperObjectSetup(x86). Click OK to create the project. 
  In the Properties dialog of the setup project, make sure that the 
  TargetPlatform property is set to x86. This setup project is to be deployed 
  for 32bit IE on x86 or x64 Windows operating systems. 

  Right-click the setup project, and choose Add / Project Output ... 
  In the Add Project Output Group dialog box, VBBrowserHelperObject will  
  be displayed in the Project list. Select Primary Output and click OK. VS
  will detect the dependencies of the VBBrowserHelperObject, including .NET
  Framework 4.0 (Client Profile).	

  Right-click the setup project again, and choose View / Custom Actions. 
  In the Custom Actions Editor, right-click the root Custom Actions node. On 
  the Action menu, click Add Custom Action. In the Select Item in Project 
  dialog box, double-click the Application Folder. Select Primary output from 
  VBBrowserHelperObject. This adds the custom actions that we defined 
  in BHOInstaller of VBBrowserHelperObject. 

  Build the setup project. If the build succeeds, you will get a .msi file 
  and a Setup.exe file. You can distribute them to your users to install or 
  uninstall this BHO. 

  (3) To deploy the BHO for 64bit IE on a x64 operating system, you 
  must create a new setup project (e.g. VBBrowserHelperObjectSetup(x64) 
  in this code sample), and set its TargetPlatform property to x64. 

  Although the TargetPlatform property is set to x64, the native shim 
  packaged with the .msi file is still a 32-bit executable. The Visual Studio 
  embeds the 32-bit version of InstallUtilLib.dll into the Binary table as 
  InstallUtil. So the custom actions will be run in the 32-bit, which is 
  unexpected in this code sample. To workaround this issue and ensure that 
  the custom actions run in the 64-bit mode, you either need to import the 
  appropriate bitness of InstallUtilLib.dll into the Binary table for the 
  InstallUtil record or - if you do have or will have 32-bit managed custom 
  actions add it as a new record in the Binary table and adjust the 
  CustomAction table to use the 64-bit Binary table record for 64-bit managed 
  custom actions. This blog article introduces how to do it manually with 
  Orca http://blogs.msdn.com/b/heaths/archive/2006/02/01/64-bit-managed-custom-actions-with-visual-studio.aspx

  In this code sample, we automate the modification of InstallUtil by using a 
  post-build javascript: Fix64bitInstallUtilLib.js. You can find the script 
  file in the VBBrowserHelperObjectSetup(x64) project folder. To 
  configure the script to run in the post-build event, you select the 
  VBBrowserHelperObjectSetup(x64) project in Solution Explorer, and 
  find the PostBuildEvent property in the Properties window. Specify its 
  value to be 
  
	"$(ProjectDir)Fix64bitInstallUtilLib.js" "$(BuiltOuputPath)" "$(ProjectDir)"

  Repeat the rest steps in (2) to add the project output, set the custom 
  actions, configure the prerequisites, and build the setup project.


/////////////////////////////////////////////////////////////////////////////
Diagnostic:

To debug BHO, you can attach to iexplorer.exe. 



///////////////////////////////////////////////////////////////////////////// 
 
References:

Browser Helper Objects: The Browser the Way You Want It
http://msdn.microsoft.com/en-us/library/ms976373.aspx

Hosting and Reuse
http://msdn.microsoft.com/en-us/library/aa752038(VS.85).aspx

IHTMLDocument2 Interface
http://msdn.microsoft.com/en-us/library/aa752574(VS.85).aspx

Mouse event handling problem in BHO
http://social.msdn.microsoft.com/Forums/en/ieextensiondevelopment/thread/1ea154a5-5802-460c-9941-30f14b36d0a4

/////////////////////////////////////////////////////////////////////////////

