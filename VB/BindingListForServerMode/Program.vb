Imports System
Imports DevExpress.Xpo
Imports DevExpress.Skins
Imports DevExpress.Xpo.DB
Imports System.Windows.Forms

Namespace BindingListForServerMode
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            SkinManager.EnableFormSkins()
            InitDal()
            Application.Run(New MainForm())
        End Sub

        Private Shared Sub InitDal()
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(MSSqlConnectionProvider.GetConnectionString(".\sqlexpress", "ServerModeGridProjects"), AutoCreateOption.None)
        End Sub
    End Class
End Namespace