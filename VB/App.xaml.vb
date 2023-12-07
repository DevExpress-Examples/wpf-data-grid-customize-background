Imports DevExpress.Xpf.Core
Imports System.Windows
Imports System.Diagnostics

Namespace DataGridBackground

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Public Partial Class App
        Inherits Application

        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            MyBase.OnStartup(e)
            Call Theme.RegisterPredefinedPaletteThemes()
            ApplicationThemeHelper.UpdateApplicationThemeName()
        End Sub
    End Class
End Namespace
