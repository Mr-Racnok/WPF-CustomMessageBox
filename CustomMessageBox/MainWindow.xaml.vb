Class MainWindow
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        With MainBorder
            .CornerRadius = New CornerRadius(12)
            .Background = CType(New BrushConverter().ConvertFromString("#FFFFFF"), Brush)
        End With
        With MainStackPanel
            .Width = 400
            .Orientation = Orientation.Vertical
            .VerticalAlignment = VerticalAlignment.Center
        End With
        With msgButton
            .Width = 200
            .Margin = New Thickness(55, 0, 55, 0)
        End With
    End Sub

    Private Sub ShowMessageBox()
        Dim messagebox As New MessageBox()
        messagebox.Owner = Me
        messagebox.WindowStartupLocation = WindowStartupLocation.CenterOwner
        messagebox.ShowDialog()
    End Sub
End Class
