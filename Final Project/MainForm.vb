Public Class MainForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This is formload
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        OrdersForm.ShowDialog()
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        InventoryForm.ShowDialog()
    End Sub

    Private Sub RecipesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecipesToolStripMenuItem.Click
        RecipeForm.ShowDialog()
    End Sub
End Class
