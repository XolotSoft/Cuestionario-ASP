Public Class WebForm1
    Inherits System.Web.UI.Page
    
    Dim ra As Integer = 0
    Dim rb As Integer = 0
    Dim rc As Integer = 0
    Dim rd As Integer = 0
    Dim re As Integer = 0
    Dim rm As Integer = 0
    Dim rok As Integer = 0


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
     
        Chart1.Series("Series1").XValueMember = 2
        Chart1.Series("Series1").YValueMembers = 12
    End Sub

    Protected Sub p1a_CheckedChanged(sender As Object, e As EventArgs) Handles p1a.CheckedChanged
        Panel1.Visible = False
        Image1.ImageUrl = "src/bad.png"
        ViewState("ra") += 1
        ViewState("rm") += 1
    End Sub

    Protected Sub p1b_CheckedChanged(sender As Object, e As EventArgs) Handles p1b.CheckedChanged
        Panel1.Visible = False
        Image1.ImageUrl = "src/bad.png"

        ViewState("rb") += 1
        ViewState("rm") += 1
    End Sub

    Protected Sub p1c_CheckedChanged(sender As Object, e As EventArgs) Handles p1c.CheckedChanged
        Panel1.Visible = False
        Image1.ImageUrl = "src/bad.png"
        ViewState("rc") += 1
        ViewState("rm") += 1
    End Sub

    Protected Sub p1d_CheckedChanged(sender As Object, e As EventArgs) Handles p1d.CheckedChanged
        Panel1.Visible = False
        Image1.ImageUrl = "src/bad.png"
        ViewState("rd") += 1
        ViewState("rm") += 1
    End Sub

    Protected Sub p1e_CheckedChanged(sender As Object, e As EventArgs) Handles p1e.CheckedChanged
        Panel1.Visible = False
        Image1.ImageUrl = "src/ok.png"
        ViewState("re") += 1
        ViewState("rok") += 1
    End Sub

    Protected Sub p2a_CheckedChanged(sender As Object, e As EventArgs) Handles p2a.CheckedChanged
        Panel2.Visible = False
        Image2.ImageUrl = "src/bad.png"
        ViewState("ra") += 1
        ViewState("rm") += 1
    End Sub

    Protected Sub p2b_CheckedChanged(sender As Object, e As EventArgs) Handles p2b.CheckedChanged
        Panel2.Visible = False
        Image2.ImageUrl = "src/bad.png"
        ViewState("rb") += 1
        ViewState("rm") += 1
    End Sub

    Protected Sub p2c_CheckedChanged(sender As Object, e As EventArgs) Handles p2c.CheckedChanged
        Panel2.Visible = False
        Image2.ImageUrl = "src/ok.png"
        ViewState("rc") += 1
        ViewState("rok") += 1
    End Sub

    Protected Sub p2d_CheckedChanged(sender As Object, e As EventArgs) Handles p2d.CheckedChanged
        Panel2.Visible = False
        Image2.ImageUrl = "src/bad.png"
        ViewState("rd") += 1
        ViewState("rm") += 1
    End Sub

    Protected Sub p2e_CheckedChanged(sender As Object, e As EventArgs) Handles p2e.CheckedChanged
        Panel2.Visible = False
        Image2.ImageUrl = "src/bad.png"
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Panel3.Visible = False
        If DropDownList1.SelectedIndex = 5 Then
            Image3.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("re") += 1
        End If
        If DropDownList1.SelectedIndex = 4 Then
            Image3.ImageUrl = "src/ok.png"
            ViewState("rok") += 1
            ViewState("rd") += 1
        End If
        If DropDownList1.SelectedIndex = 3 Then
            Image3.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("rc") += 1
        End If
        If DropDownList1.SelectedIndex = 2 Then
            Image3.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("rb") += 1
        End If
        If DropDownList1.SelectedIndex = 1 Then
            Image3.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("ra") += 1
        End If
    End Sub

    Protected Sub p4a_CheckedChanged(sender As Object, e As EventArgs) Handles p4a.CheckedChanged
        Panel4.Visible = False
        Image4.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("ra") += 1
    End Sub

    Protected Sub p4b_CheckedChanged(sender As Object, e As EventArgs) Handles p4b.CheckedChanged
        Panel4.Visible = False
        Image4.ImageUrl = "src/ok.png"
        ViewState("rok") += 1
        ViewState("rb") += 1
    End Sub

    Protected Sub p4c_CheckedChanged(sender As Object, e As EventArgs) Handles p4c.CheckedChanged
        Panel4.Visible = False
        Image4.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rc") += 1
    End Sub

    Protected Sub p4d_CheckedChanged(sender As Object, e As EventArgs) Handles p4d.CheckedChanged
        Panel4.Visible = False
        Image4.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rd") += 1
    End Sub

    Protected Sub p4e_CheckedChanged(sender As Object, e As EventArgs) Handles p4e.CheckedChanged
        Panel4.Visible = False
        Image4.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("re") += 1
    End Sub

    Protected Sub p5a_CheckedChanged(sender As Object, e As EventArgs) Handles p5a.CheckedChanged
        Panel5.Visible = False
        Image5.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("ra") += 1
    End Sub

    Protected Sub p5b_CheckedChanged(sender As Object, e As EventArgs) Handles p5b.CheckedChanged
        Panel5.Visible = False
        Image5.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rb") += 1
    End Sub

    Protected Sub p5c_CheckedChanged(sender As Object, e As EventArgs) Handles p5c.CheckedChanged
        Panel5.Visible = False
        Image5.ImageUrl = "src/ok.png"
        ViewState("rok") += 1
        ViewState("rc") += 1
    End Sub

    Protected Sub p5d_CheckedChanged(sender As Object, e As EventArgs) Handles p5d.CheckedChanged
        Panel5.Visible = False
        Image5.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rd") += 1
    End Sub

    Protected Sub p5e_CheckedChanged(sender As Object, e As EventArgs) Handles p5e.CheckedChanged
        Panel5.Visible = False
        Image5.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("re") += 1
    End Sub

    Protected Sub p6a_CheckedChanged(sender As Object, e As EventArgs) Handles p6a.CheckedChanged
        Panel6.Visible = False
        Image6.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("ra") += 1
    End Sub

    Protected Sub p6b_CheckedChanged(sender As Object, e As EventArgs) Handles p6b.CheckedChanged
        Panel6.Visible = False
        Image6.ImageUrl = "src/ok.png"
        ViewState("rok") += 1
        ViewState("rb") += 1
    End Sub

    Protected Sub p6c_CheckedChanged(sender As Object, e As EventArgs) Handles p6c.CheckedChanged
        Panel6.Visible = False
        Image6.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rc") += 1
    End Sub

    Protected Sub p6d_CheckedChanged(sender As Object, e As EventArgs) Handles p6d.CheckedChanged
        Panel6.Visible = False
        Image6.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rd") += 1
    End Sub

    Protected Sub p6e_CheckedChanged(sender As Object, e As EventArgs) Handles p6e.CheckedChanged
        Panel6.Visible = False
        Image6.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("re") += 1
    End Sub

    Protected Sub DropDownList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList2.SelectedIndexChanged
        Panel7.Visible = False
        If DropDownList1.SelectedIndex = 5 Then
            Image7.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("re") += 1
        End If
        If DropDownList1.SelectedIndex = 4 Then
            Image7.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("rd") += 1
        End If
        If DropDownList2.SelectedIndex = 3 Then
            Image7.ImageUrl = "src/ok.png"
            ViewState("rc") += 1
            ViewState("rok") += 1
        End If
        If DropDownList1.SelectedIndex = 2 Then
            Image7.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("rb") += 1
        End If
        If DropDownList1.SelectedIndex = 1 Then
            Image7.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("ra") += 1
        End If
    End Sub

    Protected Sub p8a_CheckedChanged(sender As Object, e As EventArgs) Handles p8a.CheckedChanged
        Panel8.Visible = False
        Image8.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("ra") += 1
    End Sub

    Protected Sub p8b_CheckedChanged(sender As Object, e As EventArgs) Handles p8b.CheckedChanged
        Panel8.Visible = False
        Image8.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rb") += 1
    End Sub

    Protected Sub p8c_CheckedChanged(sender As Object, e As EventArgs) Handles p8c.CheckedChanged
        Panel8.Visible = False
        Image8.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rc") += 1
    End Sub

    Protected Sub p8d_CheckedChanged(sender As Object, e As EventArgs) Handles p8d.CheckedChanged
        Panel8.Visible = False
        Image8.ImageUrl = "src/ok.png"
        ViewState("rok") += 1
        ViewState("rd") += 1
    End Sub

    Protected Sub p8e_CheckedChanged(sender As Object, e As EventArgs) Handles p8e.CheckedChanged
        Panel8.Visible = False
        Image8.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("re") += 1
    End Sub

    Protected Sub p9a_CheckedChanged(sender As Object, e As EventArgs) Handles p9a.CheckedChanged
        Panel9.Visible = False
        Image9.ImageUrl = "src/ok.png"
        ViewState("rok") += 1
        ViewState("ra") += 1
    End Sub

    Protected Sub p9b_CheckedChanged(sender As Object, e As EventArgs) Handles p9b.CheckedChanged
        Panel9.Visible = False
        Image9.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rb") += 1
    End Sub

    Protected Sub p9c_CheckedChanged(sender As Object, e As EventArgs) Handles p9c.CheckedChanged
        Panel9.Visible = False
        Image9.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rc") += 1
    End Sub

    Protected Sub p9d_CheckedChanged(sender As Object, e As EventArgs) Handles p9d.CheckedChanged
        Panel9.Visible = False
        Image9.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rd") += 1
    End Sub

    Protected Sub p9e_CheckedChanged(sender As Object, e As EventArgs) Handles p9e.CheckedChanged
        Panel9.Visible = False
        Image9.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("re") += 1
    End Sub

    Protected Sub DropDownList3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList3.SelectedIndexChanged
        Panel10.Visible = False
        If DropDownList1.SelectedIndex = 1 Then
            Image10.ImageUrl = "src/ok.png"
            ViewState("rok") += 1
            ViewState("ra") += 1
        End If
        If DropDownList1.SelectedIndex = 5 Then
            Image10.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("re") += 1
        End If
        If DropDownList1.SelectedIndex = 4 Then
            Image10.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("rd") += 1
        End If
        If DropDownList2.SelectedIndex = 3 Then
            Image10.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("rc") += 1
        End If
        If DropDownList1.SelectedIndex = 2 Then
            Image10.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("rb") += 1
        End If
    End Sub

    Protected Sub p11a_CheckedChanged(sender As Object, e As EventArgs) Handles p11a.CheckedChanged
        Panel11.Visible = False
        Image11.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("ra") += 1
    End Sub

    Protected Sub p11b_CheckedChanged(sender As Object, e As EventArgs) Handles p11b.CheckedChanged
        Panel11.Visible = False
        Image11.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rb") += 1
    End Sub

    Protected Sub p11c_CheckedChanged(sender As Object, e As EventArgs) Handles p11c.CheckedChanged
        Panel11.Visible = False
        Image11.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rc") += 1
    End Sub

    Protected Sub p11d_CheckedChanged(sender As Object, e As EventArgs) Handles p11d.CheckedChanged
        Panel11.Visible = False
        Image11.ImageUrl = "src/ok.png"
        ViewState("rok") += 1
        ViewState("rd") += 1
    End Sub

    Protected Sub p11e_CheckedChanged(sender As Object, e As EventArgs) Handles p11e.CheckedChanged
        Panel11.Visible = False
        Image11.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("re") += 1
    End Sub

    Protected Sub p12a_CheckedChanged(sender As Object, e As EventArgs) Handles p12a.CheckedChanged
        Panel12.Visible = False
        Image12.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("ra") += 1
    End Sub

    Protected Sub p12b_CheckedChanged(sender As Object, e As EventArgs) Handles p12b.CheckedChanged
        Panel12.Visible = False
        Image12.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rb") += 1
    End Sub

    Protected Sub p12c_CheckedChanged(sender As Object, e As EventArgs) Handles p12c.CheckedChanged
        Panel12.Visible = False
        Image12.ImageUrl = "src/ok.png"
        ViewState("rok") += 1
        ViewState("rc") += 1
    End Sub

    Protected Sub p12d_CheckedChanged(sender As Object, e As EventArgs) Handles p12d.CheckedChanged
        Panel12.Visible = False
        Image12.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rd") += 1
    End Sub

    Protected Sub p12e_CheckedChanged(sender As Object, e As EventArgs) Handles p12e.CheckedChanged
        Panel12.Visible = False
        Image12.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("re") += 1
    End Sub

    Protected Sub DropDownList4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList4.SelectedIndexChanged
        Panel13.Visible = False
        If DropDownList4.SelectedIndex = 1 Then
            Image13.ImageUrl = "src/ok.png"
            ViewState("rok") += 1
            ViewState("ra") += 1
        End If
        If DropDownList1.SelectedIndex = 2 Then
            Image13.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("rb") += 1
        End If
        If DropDownList2.SelectedIndex = 3 Then
            Image13.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("rc") += 1
        End If
        If DropDownList1.SelectedIndex = 4 Then
            Image13.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("rd") += 1
        End If
        If DropDownList1.SelectedIndex = 5 Then
            Image13.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("re") += 1
        End If
       
      
       
    End Sub

    Protected Sub p14a_CheckedChanged(sender As Object, e As EventArgs) Handles p14a.CheckedChanged
        Panel14.Visible = False
        Image14.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("ra") += 1
    End Sub

    Protected Sub p14b_CheckedChanged(sender As Object, e As EventArgs) Handles p14b.CheckedChanged
        Panel14.Visible = False
        Image14.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rb") += 1
    End Sub

    Protected Sub p14c_CheckedChanged(sender As Object, e As EventArgs) Handles p14c.CheckedChanged
        Panel14.Visible = False
        Image14.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rc") += 1
    End Sub

    Protected Sub p14d_CheckedChanged(sender As Object, e As EventArgs) Handles p14d.CheckedChanged
        Panel14.Visible = False
        Image14.ImageUrl = "src/ok.png"
        ViewState("rok") += 1
        ViewState("rd") += 1
    End Sub

    Protected Sub p14e_CheckedChanged(sender As Object, e As EventArgs) Handles p14e.CheckedChanged
        Panel14.Visible = False
        Image14.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("re") += 1
    End Sub

    Protected Sub p15a_CheckedChanged(sender As Object, e As EventArgs) Handles p15a.CheckedChanged
        Panel15.Visible = False
        Image15.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("ra") += 1
    End Sub

    Protected Sub p15b_CheckedChanged(sender As Object, e As EventArgs) Handles p15b.CheckedChanged
        Panel15.Visible = False
        Image15.ImageUrl = "src/ok.png"
        ViewState("rok") += 1
        ViewState("rb") += 1
    End Sub

    Protected Sub p15c_CheckedChanged(sender As Object, e As EventArgs) Handles p15c.CheckedChanged
        Panel15.Visible = False
        Image15.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rc") += 1
    End Sub

    Protected Sub p15d_CheckedChanged(sender As Object, e As EventArgs) Handles p15d.CheckedChanged
        Panel15.Visible = False
        Image15.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rd") += 1
    End Sub

    Protected Sub p15e_CheckedChanged(sender As Object, e As EventArgs) Handles p15e.CheckedChanged
        Panel15.Visible = False
        Image15.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("re") += 1
    End Sub

    Protected Sub DropDownList5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList5.SelectedIndexChanged
        Panel16.Visible = False
        If DropDownList4.SelectedIndex = 1 Then
            Image16.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("ra") += 1
        End If

        If DropDownList1.SelectedIndex = 2 Then
            Image16.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("rb") += 1
        End If
        If DropDownList2.SelectedIndex = 3 Then
            Image16.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("rc") += 1
        End If
        If DropDownList5.SelectedIndex = 4 Then
            Image16.ImageUrl = "src/ok.png"
            ViewState("rok") += 1
            ViewState("rd") += 1
        End If
        If DropDownList2.SelectedIndex = 5 Then
            Image16.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("re") += 1
        End If
    End Sub

    Protected Sub p17a_CheckedChanged(sender As Object, e As EventArgs) Handles p17a.CheckedChanged
        Panel17.Visible = False
        Image17.ImageUrl = "src/ok.png"
        ViewState("rok") += 1
        ViewState("ra") += 1
    End Sub

    Protected Sub p17b_CheckedChanged(sender As Object, e As EventArgs) Handles p17b.CheckedChanged
        Panel17.Visible = False
        Image17.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rb") += 1
    End Sub

    Protected Sub p17c_CheckedChanged(sender As Object, e As EventArgs) Handles p17c.CheckedChanged
        Panel17.Visible = False
        Image17.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rc") += 1
    End Sub

    Protected Sub p17d_CheckedChanged(sender As Object, e As EventArgs) Handles p17d.CheckedChanged
        Panel17.Visible = False
        Image17.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rd") += 1
    End Sub

    Protected Sub p17e_CheckedChanged(sender As Object, e As EventArgs) Handles p17e.CheckedChanged
        Panel17.Visible = False
        Image17.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("re") += 1
    End Sub

    Protected Sub p18a_CheckedChanged(sender As Object, e As EventArgs) Handles p18a.CheckedChanged
        Panel18.Visible = False
        Image18.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("ra") += 1
    End Sub

    Protected Sub p18b_CheckedChanged(sender As Object, e As EventArgs) Handles p18b.CheckedChanged
        Panel18.Visible = False
        Image18.ImageUrl = "src/ok.png"
        ViewState("rok") += 1
        ViewState("rb") += 1
    End Sub

    Protected Sub p18c_CheckedChanged(sender As Object, e As EventArgs) Handles p18c.CheckedChanged
        Panel18.Visible = False
        Image18.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rc") += 1
    End Sub

    Protected Sub p18d_CheckedChanged(sender As Object, e As EventArgs) Handles p18d.CheckedChanged
        Panel18.Visible = False
        Image18.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rd") += 1
    End Sub

    Protected Sub p18e_CheckedChanged(sender As Object, e As EventArgs) Handles p18e.CheckedChanged
        Panel18.Visible = False
        Image18.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("re") += 1
    End Sub

    Protected Sub DropDownList6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList6.SelectedIndexChanged
        Panel19.Visible = False
        If DropDownList6.SelectedIndex = 5 Then
            Image19.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("re") += 1
        End If
        If DropDownList6.SelectedIndex = 4 Then
            Image19.ImageUrl = "src/ok.png"
            ViewState("rok") += 1
            ViewState("rd") += 1
        End If
        If DropDownList6.SelectedIndex = 3 Then
            Image19.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("rc") += 1
        End If
        If DropDownList6.SelectedIndex = 2 Then
            Image19.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("rb") += 1
        End If
        If DropDownList6.SelectedIndex = 1 Then
            Image19.ImageUrl = "src/bad.png"
            ViewState("rm") += 1
            ViewState("ra") += 1
        End If
    End Sub

    Protected Sub p20a_CheckedChanged(sender As Object, e As EventArgs) Handles p20a.CheckedChanged
        Panel20.Visible = False
        Image20.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("ra") += 1
    End Sub

    Protected Sub p20b_CheckedChanged(sender As Object, e As EventArgs) Handles p20b.CheckedChanged
        Panel20.Visible = False
        Image20.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("ra") += 1
    End Sub

    Protected Sub p20c_CheckedChanged(sender As Object, e As EventArgs) Handles p20c.CheckedChanged
        Panel20.Visible = False
        Image20.ImageUrl = "src/ok.png"
        ViewState("rok") += 1
        ViewState("rc") += 1
    End Sub

    Protected Sub p20d_CheckedChanged(sender As Object, e As EventArgs) Handles p20d.CheckedChanged
        Panel20.Visible = False
        Image20.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("rd") += 1
    End Sub

    Protected Sub p20e_CheckedChanged(sender As Object, e As EventArgs) Handles p20e.CheckedChanged
        Panel20.Visible = False
        Image20.ImageUrl = "src/bad.png"
        ViewState("rm") += 1
        ViewState("re") += 1
    End Sub


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ra = ViewState("ra")
        rb = ViewState("rb")
        rc = ViewState("rc")
        rd = ViewState("rd")
        re = ViewState("re")
        rm = ViewState("rm")
        rok = ViewState("rok")
        lblra.Text = ra
        lblrb.Text = rb
        lblrc.Text = rc
        lblrd.Text = rd
        lblre.Text = re
        lblrm.Text = rm
        lblrok.Text = rok
        lblcal.Text = (rok * 10) / 20
        

    End Sub
End Class