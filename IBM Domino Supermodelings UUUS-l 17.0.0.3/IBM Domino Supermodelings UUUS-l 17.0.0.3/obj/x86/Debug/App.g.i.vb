﻿#ExternalChecksum("C:\Users\aydua\source\repos\IBM Domino Supermodelings UUUS-l 17.0.0.3\IBM Domino Supermodelings UUUS-l 17.0.0.3\App.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "A998771EE7F21098BEC3037DE6953A81")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Namespace Global.IBM_Domino_Supermodelings_UUUS_l_17._0._0._3

#If Not DISABLE_XAML_GENERATED_MAIN Then
Public Class Program

    <MTAThread()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.17.0")>  _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Shared Sub Main(ByVal args() As String)
        Global.Windows.UI.Xaml.Application.Start(Function(p) New Global.IBM_Domino_Supermodelings_UUUS_l_17._0._0._3.App())
    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.17.0")>  _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Sub Program
    End Sub

End Class
#End If


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Class App
    Inherits Global.Windows.UI.Xaml.Application

    Private _contentLoaded As Boolean
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 10.0.17.0")>  _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub InitializeComponent()
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true

#If Debug AndAlso Not DISABLE_XAML_GENERATED_BINDING_DEBUG_OUTPUT Then
        AddHandler Me.DebugSettings.BindingFailed,
            Sub(Sender As Global.System.Object, bindingFailedArgs As Global.Windows.UI.Xaml.BindingFailedEventArgs)
                Global.System.Diagnostics.Debug.WriteLine(bindingFailedArgs.Message)
            End Sub
#End If

#If Debug AndAlso Not DISABLE_XAML_GENERATED_BREAK_ON_UNHANDLED_EXCEPTION Then
        AddHandler Me.UnhandledException,
            Sub(sender As Global.System.Object, unhandledExceptionArgs As Global.Windows.UI.Xaml.UnhandledExceptionEventArgs)
                If Global.System.Diagnostics.Debugger.IsAttached Then
                    Global.System.Diagnostics.Debugger.Break()
                End If
            End Sub
#End If
    End Sub

End Class

End Namespace

