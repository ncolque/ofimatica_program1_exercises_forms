Public Class FORM_PRINCIPAL
    Dim V1(100) As Integer
    Dim V2(100) As Integer
    Dim V3(100) As Integer
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Dim N As Integer
        N = CInt(TB1.Text)
        Select Case N
            Case 1
                MsgBox("El dia es Lunes!")
                Label1.Text = "El valor " + CStr(N) + " es igual a Lunes."
                'Label1.Text = "El valor " & CStr(N) & " es igual a Lunes."
            Case 7
                MsgBox("El dia es Domingo!")
            Case Else
                MsgBox("El dia NO existe!")
        End Select

        'Dim A, B, suma As Integer
        'A = Val(TextBox1.Text)
        'B = Val(TextBox2.Text)
        'suma = A + B
        'TextBox3.Text = CStr(suma)

        'A Mod 2
        'Val, CStr -> Ing Gloria
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OP_ARITMETICAS.SelectedIndexChanged
        Dim A, B As Integer
        Dim R As Double
        A = CInt(TB1.Text)
        B = CInt(TB2.Text)
        Select Case OP_ARITMETICAS.SelectedIndex
            Case 0
                R = A + B
                TBR.Text = "SUMA-->" & R
            Case 3
                R = A / B
                MsgBox("DIVISIÓN-->" & R)
        End Select
    End Sub

    Private Sub OP_EXP_RAIZ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OP_EXP_RAIZ.SelectedIndexChanged
        Dim NRO As Integer
        Dim R As Double
        NRO = CInt(TB1.Text)
        Select Case OP_EXP_RAIZ.SelectedIndex
            Case 0
                R = NRO ^ 2
                TBR.Text = "CUADRADO ES: " & R
            Case 1
                R = NRO ^ 3
                TBR.Text = "CUBO ES: " & R
            Case 2
                R = Math.Sqrt(NRO)
                TBR.Text = "LA RAIZ ES: " & R
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles TABLA_ARITMETICA.SelectedIndexChanged
        Dim N, L, I, R As Integer
        N = CInt(TB1.Text)
        L = CInt(TB2.Text)
        LB_RESULTADOS.Items.Clear()
        Select Case TABLA_ARITMETICA.SelectedIndex
            Case 0
                For I = 1 To L
                    R = N + I
                    LB_RESULTADOS.Items.Add(N & "+" & I & "=" & R)
                Next
            Case 1
                For I = 1 To L
                    R = N * I
                    LB_RESULTADOS.Items.Add(N & "*" & I & "=" & R)
                Next
        End Select
    End Sub

    Private Sub SUMADEDOSVALORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUMADEDOSVALORESToolStripMenuItem.Click
        Dim fsuma As New Form3
        fsuma.ShowDialog()
        'Form3.ShowDialog()
    End Sub

    Private Sub BT_CARGAR_VECTOR_Click(sender As Object, e As EventArgs) Handles BT_CARGAR_VECTOR.Click
        Dim I, N As Integer
        N = CInt(TB_V.Text)
        For I = 1 To N
            'V1(I) = InputBox("VALOR", "CARGA", "")
            V1(I) = InputBox("")
            LB_RESULTADOS.Items.Add("V1(" & I & ")=" & V1(I))
        Next
    End Sub

    Private Sub BT_INVERTIR_VECTOR_Click(sender As Object, e As EventArgs) Handles BT_INVERTIR_VECTOR.Click
        Dim N, C As Integer
        N = CInt(TB_V.Text)
        C = 1
        While N >= 1
            V2(C) = V1(N)
            LB_RESULTADOS.Items.Add("V2(" & C & ")=" & V2(C))
            N = N - 1
            C = C + 1
        End While

        'SUMA DE DIAGONALES PRIN Y SEC
        'Dim I, J, SP, SS, AUX As Integer
        'SP = 0
        'AUX = N
        'For I = 1 To N
        '    For J = 1 To M
        '        If I = J Then
        '            SP = SP + MT(I, J)

        '        End If
        '    Next
        'Next
        'SS = 0
        'For I = 1 To N
        '    M = AUX
        '    While M >= 1
        '        SS = SS + MT(I, M)
        '        M = M - 1
        '    End While
        'Next
        'MsgBox("DIAGONAL PRINCIPAL ES: " & SP & " Y LA SECUNDARIA ES: " & SS)

        'SUMA ESPECIAL 1 COL Y ULT FIL
        'Dim I, J, S1, S2, CO, UL, ST As Integer
        'CO = 1
        'UL = N
        'S1 = 0
        'S2 = 0
        'ST = 0
        'If N = M Then
        '    For I = 1 To N
        '        For J = 1 To M
        '            If J = CO Then
        '                S1 = S1 + MT(I, J)
        '            End If
        '            If I = UL Then
        '                S2 = S2 + MT(I, J)
        '            End If
        '        Next
        '    Next
        '    ST = S1 + S2 - MT(UL, CO)
        '    MsgBox("LA SUMA TOTAL ES: " & ST)
        'Else
        '    MsgBox("LA MATRIZ NO CUMPLE CON LA CONDICIÓN")
        'End If
    End Sub

    Private Sub CERRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CERRARToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub BT_LIMPIAR_Click(sender As Object, e As EventArgs) Handles BT_LIMPIAR.Click
        TB1.Clear()
        TB2.Clear()
        TBR.Clear()
        TB_V.Clear()
        OP_ARITMETICAS.Text = "SELECCIONAR OPERACIÓN"
        OP_EXP_RAIZ.Text = "SELECCIONAR EXP O RAIZ"
        LB_RESULTADOS.Items.Clear()
    End Sub

    Private Sub TB1_TextChanged(sender As Object, e As EventArgs) Handles TB1.TextChanged

    End Sub

    Private Sub TB1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB1.KeyPress, TB2.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
