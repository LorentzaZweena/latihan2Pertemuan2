<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        ListBox1 = New ListBox()
        PictureBox1 = New PictureBox()
        ProgressBar1 = New ProgressBar()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(27, 22)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(180, 129)
        ListBox1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(238, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(300, 129)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(238, 176)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(300, 34)
        ProgressBar1.TabIndex = 2
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(238, 235)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(238, 286)
        Button1.Name = "Button1"
        Button1.Size = New Size(300, 34)
        Button1.TabIndex = 4
        Button1.Text = "Tampilkan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(ProgressBar1)
        Controls.Add(PictureBox1)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button

End Class
