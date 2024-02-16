<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtFirstnum = New TextBox()
        Label2 = New Label()
        txtSecondnum = New TextBox()
        btndivide = New Button()
        Label3 = New Label()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 20)
        Label1.TabIndex = 0
        Label1.Text = "Firstnum"
        ' 
        ' txtFirstnum
        ' 
        txtFirstnum.Location = New Point(12, 32)
        txtFirstnum.Name = "txtFirstnum"
        txtFirstnum.Size = New Size(125, 27)
        txtFirstnum.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 2
        Label2.Text = "Secondnum"
        ' 
        ' txtSecondnum
        ' 
        txtSecondnum.Location = New Point(12, 98)
        txtSecondnum.Name = "txtSecondnum"
        txtSecondnum.Size = New Size(125, 27)
        txtSecondnum.TabIndex = 3
        ' 
        ' btndivide
        ' 
        btndivide.Location = New Point(25, 158)
        btndivide.Name = "btndivide"
        btndivide.Size = New Size(94, 29)
        btndivide.TabIndex = 4
        btndivide.Text = "Divide"
        btndivide.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 5
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(42, 213)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(49, 20)
        lblResult.TabIndex = 6
        lblResult.Text = "Result"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Controls.Add(Label3)
        Controls.Add(btndivide)
        Controls.Add(txtSecondnum)
        Controls.Add(Label2)
        Controls.Add(txtFirstnum)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstnum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSecondnum As TextBox
    Friend WithEvents btndivide As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResult As Label

End Class
