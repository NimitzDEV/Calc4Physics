﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.34014
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    '此类是由 StronglyTypedResourceBuilder
    '类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    '若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    '(以 /str 作为命令选项)，或重新生成 VS 项目。
    '''<summary>
    '''  一个强类型的资源类，用于查找本地化的字符串等。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  返回此类使用的缓存的 ResourceManager 实例。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("懒人计算器.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  使用此强类型资源类，为所有资源查找
        '''  重写当前线程的 CurrentUICulture 属性。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property alipayqrcode() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("alipayqrcode", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property info() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("info", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 米（m）#1
        '''分米（dm）#10
        '''厘米（cm）#100
        '''公里（km）#0.001
        '''毫米（mm）#1000
        '''微米（um）#1000000
        '''纳米（nm）#1e+9
        '''皮米（pm）#1e+12
        '''-#0
        '''里#0.002
        '''丈#0.3
        '''寸#30
        '''尺#3
        '''分#300
        '''厘#3000
        '''毫#30000
        '''-#0
        '''海里（nmi）#0.00054
        '''英寻#0.5468066
        '''英里（mi）#0.0006214
        '''费隆（fur）#0.004971
        '''码（yd）#1.0936133
        '''英尺（ft）#3.2808399
        '''英寸（in）#39.3700787
        '''杆（rod）#0.19883878
        '''链（chn）#0.0497097
        '''手（hand）#9.84251969
        '''-#0
        '''光年（ly）#1.0570234e-16
        '''天文单位（au）#6.68458581e-12 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property list_distance() As String
            Get
                Return ResourceManager.GetString("list_distance", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property n_48() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("n_48", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property off() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("off", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
