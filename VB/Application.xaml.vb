Imports DevExpress.Xpf.Core
Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Reflection
Imports System.Diagnostics
Imports System.Runtime

Namespace DataGridBackground
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application

		Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
			MyBase.OnStartup(e)

			Theme.RegisterPredefinedPaletteThemes()

			DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName()
		End Sub
	End Class
End Namespace
