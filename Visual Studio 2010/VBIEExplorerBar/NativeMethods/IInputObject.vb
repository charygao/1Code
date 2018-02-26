﻿'*************************** Module Header ******************************'
' Module Name:  IInputObject.vb
' Project:	    VBIEExplorerBar
' Copyright (c) Microsoft Corporation.
' 
' Exposes methods that change UI activation and process accelerators for a 
' user input object contained in the Shell.
' 
' 
' This source is subject to the Microsoft Public License.
' See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
' All other rights reserved.
' 
' THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
' EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
'*************************************************************************'

Imports System.Runtime.InteropServices

Namespace NativeMethods
    <ComImport()>
    <Guid("68284faa-6a48-11d0-8c78-00c04fd918b4")>
    <InterfaceType(ComInterfaceType.InterfaceIsIUnknown)>
    Public Interface IInputObject
        Sub UIActivateIO(ByVal fActivate As Integer, ByRef msg As MSG)
        <PreserveSig()>
        Function HasFocusIO() As Integer
        <PreserveSig()>
        Function TranslateAcceleratorIO(ByRef msg As MSG) As Integer
    End Interface
End Namespace
