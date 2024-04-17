<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORM_PRINCIPAL
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
        Me.TB1 = New System.Windows.Forms.TextBox()
        Me.B1 = New System.Windows.Forms.Button()
        Me.OP_ARITMETICAS = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB2 = New System.Windows.Forms.TextBox()
        Me.TBR = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OP_EXP_RAIZ = New System.Windows.Forms.ComboBox()
        Me.LB_RESULTADOS = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TABLA_ARITMETICA = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EJERCICIO1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUMADEDOSVALORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EJERCICIO2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EJERCICIO3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EJERCICIO4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EJERCICIO5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CERRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TB_V = New System.Windows.Forms.TextBox()
        Me.BT_CARGAR_VECTOR = New System.Windows.Forms.Button()
        Me.BT_INVERTIR_VECTOR = New System.Windows.Forms.Button()
        Me.BT_LIMPIAR = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TB1
        '
        Me.TB1.Location = New System.Drawing.Point(12, 67)
        Me.TB1.Name = "TB1"
        Me.TB1.Size = New System.Drawing.Size(100, 23)
        Me.TB1.TabIndex = 0
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(118, 67)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(75, 23)
        Me.B1.TabIndex = 1
        Me.B1.Text = "Verificar"
        Me.B1.UseVisualStyleBackColor = True
        '
        'OP_ARITMETICAS
        '
        Me.OP_ARITMETICAS.FormattingEnabled = True
        Me.OP_ARITMETICAS.Items.AddRange(New Object() {"SUMA", "RESTA", "MULTIPLICACIÓN", "DIVISIÓN"})
        Me.OP_ARITMETICAS.Location = New System.Drawing.Point(12, 223)
        Me.OP_ARITMETICAS.Name = "OP_ARITMETICAS"
        Me.OP_ARITMETICAS.Size = New System.Drawing.Size(121, 23)
        Me.OP_ARITMETICAS.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "VALOR 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "VALOR 2"
        '
        'TB2
        '
        Me.TB2.Location = New System.Drawing.Point(12, 111)
        Me.TB2.Name = "TB2"
        Me.TB2.Size = New System.Drawing.Size(100, 23)
        Me.TB2.TabIndex = 5
        '
        'TBR
        '
        Me.TBR.Location = New System.Drawing.Point(12, 155)
        Me.TBR.Name = "TBR"
        Me.TBR.Size = New System.Drawing.Size(100, 23)
        Me.TBR.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "RESULTADO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "OPERACIONES ARITMETICAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "OPERACIONES EXP Y RAIZ"
        '
        'OP_EXP_RAIZ
        '
        Me.OP_EXP_RAIZ.FormattingEnabled = True
        Me.OP_EXP_RAIZ.Items.AddRange(New Object() {"CUADRADO", "CUBO", "RAIZ"})
        Me.OP_EXP_RAIZ.Location = New System.Drawing.Point(12, 267)
        Me.OP_EXP_RAIZ.Name = "OP_EXP_RAIZ"
        Me.OP_EXP_RAIZ.Size = New System.Drawing.Size(121, 23)
        Me.OP_EXP_RAIZ.TabIndex = 10
        '
        'LB_RESULTADOS
        '
        Me.LB_RESULTADOS.FormattingEnabled = True
        Me.LB_RESULTADOS.ItemHeight = 15
        Me.LB_RESULTADOS.Location = New System.Drawing.Point(199, 67)
        Me.LB_RESULTADOS.Name = "LB_RESULTADOS"
        Me.LB_RESULTADOS.Size = New System.Drawing.Size(120, 94)
        Me.LB_RESULTADOS.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "TABLA ARITMETICA"
        '
        'TABLA_ARITMETICA
        '
        Me.TABLA_ARITMETICA.FormattingEnabled = True
        Me.TABLA_ARITMETICA.Items.AddRange(New Object() {"SUMA", "MULTIPLICACIÓN"})
        Me.TABLA_ARITMETICA.Location = New System.Drawing.Point(12, 311)
        Me.TABLA_ARITMETICA.Name = "TABLA_ARITMETICA"
        Me.TABLA_ARITMETICA.Size = New System.Drawing.Size(121, 23)
        Me.TABLA_ARITMETICA.TabIndex = 13
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EJERCICIO1ToolStripMenuItem, Me.EJERCICIO2ToolStripMenuItem, Me.EJERCICIO3ToolStripMenuItem, Me.EJERCICIO4ToolStripMenuItem, Me.EJERCICIO5ToolStripMenuItem, Me.CERRARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EJERCICIO1ToolStripMenuItem
        '
        Me.EJERCICIO1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SUMADEDOSVALORESToolStripMenuItem})
        Me.EJERCICIO1ToolStripMenuItem.Name = "EJERCICIO1ToolStripMenuItem"
        Me.EJERCICIO1ToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.EJERCICIO1ToolStripMenuItem.Text = "EJERCICIO 1"
        '
        'SUMADEDOSVALORESToolStripMenuItem
        '
        Me.SUMADEDOSVALORESToolStripMenuItem.Name = "SUMADEDOSVALORESToolStripMenuItem"
        Me.SUMADEDOSVALORESToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SUMADEDOSVALORESToolStripMenuItem.Text = "SUMA DE DOS VALORES"
        '
        'EJERCICIO2ToolStripMenuItem
        '
        Me.EJERCICIO2ToolStripMenuItem.Name = "EJERCICIO2ToolStripMenuItem"
        Me.EJERCICIO2ToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.EJERCICIO2ToolStripMenuItem.Text = "EJERCICIO 2"
        '
        'EJERCICIO3ToolStripMenuItem
        '
        Me.EJERCICIO3ToolStripMenuItem.Name = "EJERCICIO3ToolStripMenuItem"
        Me.EJERCICIO3ToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.EJERCICIO3ToolStripMenuItem.Text = "EJERCICIO 3"
        '
        'EJERCICIO4ToolStripMenuItem
        '
        Me.EJERCICIO4ToolStripMenuItem.Name = "EJERCICIO4ToolStripMenuItem"
        Me.EJERCICIO4ToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.EJERCICIO4ToolStripMenuItem.Text = "EJERCICIO 4"
        '
        'EJERCICIO5ToolStripMenuItem
        '
        Me.EJERCICIO5ToolStripMenuItem.Name = "EJERCICIO5ToolStripMenuItem"
        Me.EJERCICIO5ToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.EJERCICIO5ToolStripMenuItem.Text = "EJERCICIO 5"
        '
        'CERRARToolStripMenuItem
        '
        Me.CERRARToolStripMenuItem.Name = "CERRARToolStripMenuItem"
        Me.CERRARToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CERRARToolStripMenuItem.Text = "CERRAR"
        '
        'TB_V
        '
        Me.TB_V.Location = New System.Drawing.Point(325, 67)
        Me.TB_V.Name = "TB_V"
        Me.TB_V.Size = New System.Drawing.Size(100, 23)
        Me.TB_V.TabIndex = 15
        '
        'BT_CARGAR_VECTOR
        '
        Me.BT_CARGAR_VECTOR.Location = New System.Drawing.Point(431, 67)
        Me.BT_CARGAR_VECTOR.Name = "BT_CARGAR_VECTOR"
        Me.BT_CARGAR_VECTOR.Size = New System.Drawing.Size(117, 23)
        Me.BT_CARGAR_VECTOR.TabIndex = 16
        Me.BT_CARGAR_VECTOR.Text = "CARGAR VECTOR"
        Me.BT_CARGAR_VECTOR.UseVisualStyleBackColor = True
        '
        'BT_INVERTIR_VECTOR
        '
        Me.BT_INVERTIR_VECTOR.Location = New System.Drawing.Point(431, 93)
        Me.BT_INVERTIR_VECTOR.Name = "BT_INVERTIR_VECTOR"
        Me.BT_INVERTIR_VECTOR.Size = New System.Drawing.Size(117, 23)
        Me.BT_INVERTIR_VECTOR.TabIndex = 17
        Me.BT_INVERTIR_VECTOR.Text = "INVERTIR VECTOR"
        Me.BT_INVERTIR_VECTOR.UseVisualStyleBackColor = True
        '
        'BT_LIMPIAR
        '
        Me.BT_LIMPIAR.Location = New System.Drawing.Point(713, 415)
        Me.BT_LIMPIAR.Name = "BT_LIMPIAR"
        Me.BT_LIMPIAR.Size = New System.Drawing.Size(75, 23)
        Me.BT_LIMPIAR.TabIndex = 18
        Me.BT_LIMPIAR.Text = "LIMPIAR"
        Me.BT_LIMPIAR.UseVisualStyleBackColor = True
        '
        'FORM_PRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BT_LIMPIAR)
        Me.Controls.Add(Me.BT_INVERTIR_VECTOR)
        Me.Controls.Add(Me.BT_CARGAR_VECTOR)
        Me.Controls.Add(Me.TB_V)
        Me.Controls.Add(Me.TABLA_ARITMETICA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LB_RESULTADOS)
        Me.Controls.Add(Me.OP_EXP_RAIZ)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBR)
        Me.Controls.Add(Me.TB2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OP_ARITMETICAS)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.TB1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FORM_PRINCIPAL"
        Me.Text = "FORMULARIO PRINCIPAL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB1 As TextBox
    Friend WithEvents B1 As Button
    Friend WithEvents OP_ARITMETICAS As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB2 As TextBox
    Friend WithEvents TBR As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OP_EXP_RAIZ As ComboBox
    Friend WithEvents LB_RESULTADOS As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TABLA_ARITMETICA As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EJERCICIO1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUMADEDOSVALORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EJERCICIO2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EJERCICIO3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TB_V As TextBox
    Friend WithEvents BT_CARGAR_VECTOR As Button
    Friend WithEvents BT_INVERTIR_VECTOR As Button
    Friend WithEvents EJERCICIO4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EJERCICIO5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CERRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BT_LIMPIAR As Button
End Class
