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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFilas = New System.Windows.Forms.TextBox()
        Me.txtColumnas = New System.Windows.Forms.TextBox()
        Me.btnDiagonalPrincipal = New System.Windows.Forms.Button()
        Me.btnSecundaria = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Matriz de dimensión NxN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnEnd
        '
        Me.btnEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(493, 349)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(200, 87)
        Me.btnEnd.TabIndex = 1
        Me.btnEnd.Text = "Salir"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(239, 59)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowTemplate.Height = 24
        Me.DGV1.Size = New System.Drawing.Size(726, 269)
        Me.DGV1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fila:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Columna:"
        '
        'txtFilas
        '
        Me.txtFilas.Location = New System.Drawing.Point(114, 78)
        Me.txtFilas.Name = "txtFilas"
        Me.txtFilas.Size = New System.Drawing.Size(100, 22)
        Me.txtFilas.TabIndex = 5
        Me.txtFilas.Text = "4"
        Me.txtFilas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtColumnas
        '
        Me.txtColumnas.Location = New System.Drawing.Point(114, 135)
        Me.txtColumnas.Name = "txtColumnas"
        Me.txtColumnas.Size = New System.Drawing.Size(100, 22)
        Me.txtColumnas.TabIndex = 6
        Me.txtColumnas.Text = "4"
        Me.txtColumnas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDiagonalPrincipal
        '
        Me.btnDiagonalPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiagonalPrincipal.Location = New System.Drawing.Point(39, 223)
        Me.btnDiagonalPrincipal.Name = "btnDiagonalPrincipal"
        Me.btnDiagonalPrincipal.Size = New System.Drawing.Size(175, 30)
        Me.btnDiagonalPrincipal.TabIndex = 7
        Me.btnDiagonalPrincipal.Text = "Diagonal Principal"
        Me.btnDiagonalPrincipal.UseVisualStyleBackColor = True
        '
        'btnSecundaria
        '
        Me.btnSecundaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecundaria.Location = New System.Drawing.Point(37, 275)
        Me.btnSecundaria.Name = "btnSecundaria"
        Me.btnSecundaria.Size = New System.Drawing.Size(177, 35)
        Me.btnSecundaria.TabIndex = 8
        Me.btnSecundaria.Text = "Diagonal Secundaria"
        Me.btnSecundaria.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(68, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 33)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 543)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSecundaria)
        Me.Controls.Add(Me.btnDiagonalPrincipal)
        Me.Controls.Add(Me.txtColumnas)
        Me.Controls.Add(Me.txtFilas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFilas As System.Windows.Forms.TextBox
    Friend WithEvents txtColumnas As System.Windows.Forms.TextBox
    Friend WithEvents btnDiagonalPrincipal As System.Windows.Forms.Button
    Friend WithEvents btnSecundaria As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
