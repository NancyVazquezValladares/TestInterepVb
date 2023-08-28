<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtTextoxd = New System.Windows.Forms.TextBox()
        Me.lblTextoxd = New System.Windows.Forms.Label()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnWord = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTextoxd
        '
        Me.txtTextoxd.Location = New System.Drawing.Point(24, 88)
        Me.txtTextoxd.Name = "txtTextoxd"
        Me.txtTextoxd.Size = New System.Drawing.Size(206, 22)
        Me.txtTextoxd.TabIndex = 2
        '
        'lblTextoxd
        '
        Me.lblTextoxd.AutoSize = True
        Me.lblTextoxd.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTextoxd.Location = New System.Drawing.Point(20, 30)
        Me.lblTextoxd.Name = "lblTextoxd"
        Me.lblTextoxd.Size = New System.Drawing.Size(201, 24)
        Me.lblTextoxd.TabIndex = 4
        Me.lblTextoxd.Text = "Generador de Formato"
        '
        'btnExcel
        '
        Me.btnExcel.BackgroundImage = Global.TestInterepVb.My.Resources.Resources.Exce
        Me.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.ForeColor = System.Drawing.Color.Transparent
        Me.btnExcel.Location = New System.Drawing.Point(136, 147)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(68, 52)
        Me.btnExcel.TabIndex = 1
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnWord
        '
        Me.btnWord.BackgroundImage = Global.TestInterepVb.My.Resources.Resources.Word
        Me.btnWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWord.ForeColor = System.Drawing.Color.Transparent
        Me.btnWord.Location = New System.Drawing.Point(24, 147)
        Me.btnWord.Name = "btnWord"
        Me.btnWord.Size = New System.Drawing.Size(64, 52)
        Me.btnWord.TabIndex = 0
        Me.btnWord.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(255, 224)
        Me.Controls.Add(Me.lblTextoxd)
        Me.Controls.Add(Me.txtTextoxd)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnWord)
        Me.Name = "Form1"
        Me.Text = "TestInteropVB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnWord As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents txtTextoxd As TextBox
    Private WithEvents lblTextoxd As Label
End Class
