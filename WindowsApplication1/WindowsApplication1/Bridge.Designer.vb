<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNameGuess = New System.Windows.Forms.TextBox()
        Me.txtQuestGuess = New System.Windows.Forms.TextBox()
        Me.txtColorGuess = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblQ1Answer = New System.Windows.Forms.Label()
        Me.lblQ2Answer = New System.Windows.Forms.Label()
        Me.lblQ3Answer = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNameGuess
        '
        Me.txtNameGuess.Location = New System.Drawing.Point(318, 49)
        Me.txtNameGuess.Name = "txtNameGuess"
        Me.txtNameGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtNameGuess.TabIndex = 0
        '
        'txtQuestGuess
        '
        Me.txtQuestGuess.Location = New System.Drawing.Point(318, 99)
        Me.txtQuestGuess.Name = "txtQuestGuess"
        Me.txtQuestGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtQuestGuess.TabIndex = 1
        '
        'txtColorGuess
        '
        Me.txtColorGuess.Location = New System.Drawing.Point(318, 146)
        Me.txtColorGuess.Name = "txtColorGuess"
        Me.txtColorGuess.Size = New System.Drawing.Size(100, 20)
        Me.txtColorGuess.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(132, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome to the Bridge of Death!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "What is your name?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "What is your quest?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "What is your favorite color?"
        '
        'lblQ1Answer
        '
        Me.lblQ1Answer.AutoSize = True
        Me.lblQ1Answer.Location = New System.Drawing.Point(63, 210)
        Me.lblQ1Answer.Name = "lblQ1Answer"
        Me.lblQ1Answer.Size = New System.Drawing.Size(0, 13)
        Me.lblQ1Answer.TabIndex = 7
        '
        'lblQ2Answer
        '
        Me.lblQ2Answer.AutoSize = True
        Me.lblQ2Answer.Location = New System.Drawing.Point(195, 210)
        Me.lblQ2Answer.Name = "lblQ2Answer"
        Me.lblQ2Answer.Size = New System.Drawing.Size(0, 13)
        Me.lblQ2Answer.TabIndex = 8
        '
        'lblQ3Answer
        '
        Me.lblQ3Answer.AutoSize = True
        Me.lblQ3Answer.Location = New System.Drawing.Point(327, 210)
        Me.lblQ3Answer.Name = "lblQ3Answer"
        Me.lblQ3Answer.Size = New System.Drawing.Size(0, 13)
        Me.lblQ3Answer.TabIndex = 9
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(198, 182)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 10
        Me.btnGo.Text = "Test your FATE!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 320)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblQ3Answer)
        Me.Controls.Add(Me.lblQ2Answer)
        Me.Controls.Add(Me.lblQ1Answer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtColorGuess)
        Me.Controls.Add(Me.txtQuestGuess)
        Me.Controls.Add(Me.txtNameGuess)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNameGuess As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestGuess As System.Windows.Forms.TextBox
    Friend WithEvents txtColorGuess As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblQ1Answer As System.Windows.Forms.Label
    Friend WithEvents lblQ2Answer As System.Windows.Forms.Label
    Friend WithEvents lblQ3Answer As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button

End Class
