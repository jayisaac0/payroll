Public Class Form1
    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        If MsgBox("Pleas confirm you want to exit") = MsgBoxResult.Ok Then
            Close()
        End If
    End Sub

    Private Sub lblCompute_Click(sender As Object, e As EventArgs) Handles lblCompute.Click
        Dim noOfChildren As Integer
        Dim yearsWorked As Integer
        Dim maritalStatus As String
        Dim startingSalary As Double
        Dim basicSalary As Double
        Dim grossSalary As Double
        Dim netSalary As Double
        Dim longServeBonus As Double
        Dim familyAllowance As Double
        Dim totalAllowance As Double
        Dim paye As Double
        Dim nssf As Double
        Dim totalDeduct As Double

        noOfChildren = Val(txtNoOfChildren.Text)
        yearsWorked = Val(txtYearsWorked.Text)
        maritalStatus = Val(cboMaritalStatus.Text)
        startingSalary = Val(txtStartingSalary.Text)
        basicSalary = Val(txtBasicSalary.Text)
        grossSalary = Val(txtGrossSalary.Text)
        netSalary = Val(txtNetSalary.Text)
        longServeBonus = Val(txtLongServeBonus.Text)
        familyAllowance = Val(txtFamilyAllowance.Text)
        totalAllowance = Val(txtTotalAllowances.Text)
        paye = Val(txtPaye.Text)
        nssf = Val(txtNssf.Text)
        totalDeduct = Val(txtTotalDeduction.Text)

        basicSalary = startingSalary + (500 * yearsWorked)
        txtBasicSalary.Text = basicSalary

        If yearsWorked > 15 Then longServeBonus = 2000
        txtLongServeBonus.Text = longServeBonus

        If cboMaritalStatus.SelectedItem = "Married" Then familyAllowance = (400 * noOfChildren)
        txtFamilyAllowance.Text = familyAllowance

        grossSalary = (basicSalary + longServeBonus + familyAllowance)
        txtGrossSalary.Text = grossSalary

        paye = (0.15 * grossSalary)
        txtPaye.Text = paye

        nssf = 0.05 * (grossSalary - paye)
        txtNssf.Text = nssf

        totalDeduct = (paye + nssf)
        txtTotalDeduction.Text = totalDeduct

        netSalary = (grossSalary - totalDeduct)
        txtNetSalary.Text = netSalary

        totalAllowance = (familyAllowance + longServeBonus)
        txtTotalAllowances.Text = totalAllowance

    End Sub
End Class
