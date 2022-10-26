<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bed_Sizes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bed_Sizes))
        Me.CK = New System.Windows.Forms.Button()
        Me.K = New System.Windows.Forms.Button()
        Me.Q = New System.Windows.Forms.Button()
        Me.S = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CK
        '
        Me.CK.BackColor = System.Drawing.Color.Cornsilk
        Me.CK.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CK.Location = New System.Drawing.Point(129, 116)
        Me.CK.Name = "CK"
        Me.CK.Size = New System.Drawing.Size(244, 219)
        Me.CK.TabIndex = 0
        Me.CK.Text = "California King"
        Me.CK.UseVisualStyleBackColor = False
        '
        'K
        '
        Me.K.BackColor = System.Drawing.Color.Cornsilk
        Me.K.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K.Location = New System.Drawing.Point(502, 116)
        Me.K.Name = "K"
        Me.K.Size = New System.Drawing.Size(244, 219)
        Me.K.TabIndex = 1
        Me.K.Text = "King"
        Me.K.UseVisualStyleBackColor = False
        '
        'Q
        '
        Me.Q.BackColor = System.Drawing.Color.Cornsilk
        Me.Q.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Q.Location = New System.Drawing.Point(129, 390)
        Me.Q.Name = "Q"
        Me.Q.Size = New System.Drawing.Size(244, 219)
        Me.Q.TabIndex = 2
        Me.Q.Text = "Queen"
        Me.Q.UseVisualStyleBackColor = False
        '
        'S
        '
        Me.S.BackColor = System.Drawing.Color.Cornsilk
        Me.S.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S.Location = New System.Drawing.Point(502, 390)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(244, 219)
        Me.S.TabIndex = 3
        Me.S.Text = "Single"
        Me.S.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(289, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 49)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Select Bed Size"
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.Cornsilk
        Me.Back.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(21, 25)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(100, 36)
        Me.Back.TabIndex = 6
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(219, 654)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(431, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Note: Based on standard sizes in the market"
        '
        'Bed_Sizes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(882, 683)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.S)
        Me.Controls.Add(Me.Q)
        Me.Controls.Add(Me.K)
        Me.Controls.Add(Me.CK)
        Me.Name = "Bed_Sizes"
        Me.Text = "Bed Sizes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CK As Button
    Friend WithEvents K As Button
    Friend WithEvents Q As Button
    Friend WithEvents S As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Back As Button
    Friend WithEvents Label2 As Label
End Class
