Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub p1a_CheckedChanged(sender As Object, e As EventArgs) Handles p1a.CheckedChanged
        Panel1.Visible = False
        Image1.ImageUrl = "src/ok.png"
    End Sub

    Protected Sub p1b_CheckedChanged(sender As Object, e As EventArgs) Handles p1b.CheckedChanged
        Panel1.Visible = False
        Image1.ImageUrl = "src/bad.png"
    End Sub

    Protected Sub p1c_CheckedChanged(sender As Object, e As EventArgs) Handles p1c.CheckedChanged
        Panel1.Visible = False
        Image1.ImageUrl = "src/bad.png"
    End Sub

    Protected Sub p1d_CheckedChanged(sender As Object, e As EventArgs) Handles p1d.CheckedChanged
        Panel1.Visible = False
        Image1.ImageUrl = "src/bad.png"
    End Sub

    Protected Sub p1e_CheckedChanged(sender As Object, e As EventArgs) Handles p1e.CheckedChanged
        Panel1.Visible = False
        Image1.ImageUrl = "src/bad.png"
    End Sub

    Protected Sub p2a_CheckedChanged(sender As Object, e As EventArgs) Handles p2a.CheckedChanged
        Panel2.Visible = False
        Image2.ImageUrl = "src/bad.png"
    End Sub

    Protected Sub p2b_CheckedChanged(sender As Object, e As EventArgs) Handles p2b.CheckedChanged
        Panel2.Visible = False
        Image2.ImageUrl = "src/bad.png"
    End Sub

    Protected Sub p2c_CheckedChanged(sender As Object, e As EventArgs) Handles p2c.CheckedChanged
        Panel2.Visible = False
        Image2.ImageUrl = "src/ok.png"
    End Sub

    Protected Sub p2d_CheckedChanged(sender As Object, e As EventArgs) Handles p2d.CheckedChanged
        Panel2.Visible = False
        Image2.ImageUrl = "src/bad.png"
    End Sub

    Protected Sub p2e_CheckedChanged(sender As Object, e As EventArgs) Handles p2e.CheckedChanged
        Panel2.Visible = False
        Image2.ImageUrl = "src/bad.png"
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Panel3.Visible = False
        If DropDownList1.SelectedIndex = 2 Then
            Image3.ImageUrl = "src/ok.png"
        else
        Image3.ImageUrl = "src/bad.png"
        End If
    End Sub

    Protected Sub p4a_CheckedChanged(sender As Object, e As EventArgs) Handles p4a.CheckedChanged
        Panel4.Visible = False
        Image4.ImageUrl = "src/bad.png"
    End Sub

    Protected Sub p4b_CheckedChanged(sender As Object, e As EventArgs) Handles p4b.CheckedChanged
        Panel4.Visible = False
        Image4.ImageUrl = "src/ok.png"
    End Sub

    Protected Sub p4c_CheckedChanged(sender As Object, e As EventArgs) Handles p4c.CheckedChanged
        Panel4.Visible = False
        Image4.ImageUrl = "src/bad.png"
    End Sub

    Protected Sub p4d_CheckedChanged(sender As Object, e As EventArgs) Handles p4d.CheckedChanged
        Panel4.Visible = False
        Image4.ImageUrl = "src/bad.png"
    End Sub

    Protected Sub p4e_CheckedChanged(sender As Object, e As EventArgs) Handles p4e.CheckedChanged
        Panel4.Visible = False
        Image4.ImageUrl = "src/bad.png"
    End Sub

    Protected Sub p5a_CheckedChanged(sender As Object, e As EventArgs) Handles p5a.CheckedChanged
        Panel5.Visible = False
        Image5.ImageUrl = "src/bad.png"
    End Sub

    Protected Sub p5b_CheckedChanged(sender As Object, e As EventArgs) Handles p5b.CheckedChanged
        Panel5.Visible = False
        Image5.ImageUrl = "src/bad.png"
    End Sub

    Protected Sub p5c_CheckedChanged(sender As Object, e As EventArgs) Handles p5c.CheckedChanged
        Panel5.Visible = False
        Image5.ImageUrl = "src/ok.png"
    End Sub

    Protected Sub p5d_CheckedChanged(sender As Object, e As EventArgs) Handles p5d.CheckedChanged
        Panel5.Visible = False
        Image5.ImageUrl = "src/bad.png"
    End Sub

    Protected Sub p5e_CheckedChanged(sender As Object, e As EventArgs) Handles p5e.CheckedChanged
        Panel5.Visible = False
        Image5.ImageUrl = "src/bad.png"
    End Sub
End Class