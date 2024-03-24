Public Class FormMain
    'Project: PUOFoodOrder
    'Date: 25/3/2020
    'Programmer:
    '       1) Adib Nawfal Bin Yazid                    (01DDT18F1162)
    '       2) Muhammad Adib Mahzuz Bin Mat Shahri      (01DDT18F1167)
    '       3) Muhammad Iqhwan Haikal Bin Jamal Rodzi   (01DDT18F1176)
    '
    'Description: PUO food order windows app for project assignment.
    'Folder: PUOFoodOrder-DEEP

    ' Declare variables
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Dim custname As String
    Dim gender As String
    Dim address As String
    Dim state As String
    Dim city As String
    Dim phone As String

    Dim orderBurger As Integer
    Dim orderChicken As Integer
    Dim orderLasagna As Integer
    Dim orderMilo As Integer
    Dim orderTotal As Integer

    Dim priceBurger As Integer
    Dim priceChicken As Integer
    Dim priceLasagna As Integer
    Dim priceMilo As Integer
    Dim totalPrice As Integer

    ' Array
    Dim orderQty() As Integer = {0, 0, 0, 0}
    Dim qty() As Integer = {0, 0, 0, 0}

    ' Constant
    Const PRICE_BURGER As Integer = 5
    Const PRICE_CHICKEN As Integer = 8
    Const PRICE_LASAGNA As Integer = 6
    Const PRICE_MILO As Integer = 3

    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        PanelButtonHome.Visible = True
        PanelButtonMenu.Visible = False
        PanelButtonOrder.Visible = False
        PanelButtonTracking.Visible = False
        PanelButtonContactUs.Visible = False

        PanelHome.Visible = True
        PanelMenu.Visible = False
        PanelOrder.Visible = False
        PanelTracking.Visible = False
        PanelContactUs.Visible = False
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        PanelButtonHome.Visible = False
        PanelButtonMenu.Visible = True
        PanelButtonOrder.Visible = False
        PanelButtonTracking.Visible = False
        PanelButtonContactUs.Visible = False

        PanelHome.Visible = False
        PanelMenu.Visible = True
        PanelOrder.Visible = False
        PanelTracking.Visible = False
        PanelContactUs.Visible = False
    End Sub

    Private Sub ButtonOrder_Click(sender As Object, e As EventArgs) Handles ButtonOrder.Click
        PanelButtonHome.Visible = False
        PanelButtonMenu.Visible = False
        PanelButtonOrder.Visible = True
        PanelButtonTracking.Visible = False
        PanelButtonContactUs.Visible = False

        PanelHome.Visible = False
        PanelMenu.Visible = False
        PanelOrder.Visible = True
        PanelTracking.Visible = False
        PanelContactUs.Visible = False
    End Sub

    Private Sub ButtonTracking_Click(sender As Object, e As EventArgs) Handles ButtonTracking.Click
        PanelButtonHome.Visible = False
        PanelButtonMenu.Visible = False
        PanelButtonOrder.Visible = False
        PanelButtonTracking.Visible = True
        PanelButtonContactUs.Visible = False

        PanelHome.Visible = False
        PanelMenu.Visible = False
        PanelOrder.Visible = False
        PanelTracking.Visible = True
        PanelContactUs.Visible = False
    End Sub

    Private Sub ButtonContactUs_Click(sender As Object, e As EventArgs) Handles ButtonContactUs.Click
        PanelButtonHome.Visible = False
        PanelButtonMenu.Visible = False
        PanelButtonOrder.Visible = False
        PanelButtonTracking.Visible = False
        PanelButtonContactUs.Visible = True

        PanelHome.Visible = False
        PanelMenu.Visible = False
        PanelOrder.Visible = False
        PanelTracking.Visible = False
        PanelContactUs.Visible = True
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        ' Close windows
        Me.Close()
    End Sub

    Private Sub picMin_Click(sender As Object, e As EventArgs) Handles picMin.Click
        ' Minimized windows
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub PanelTop_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseDown
        ' Make top panel draggable
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PanelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mouseX
            Me.Top = Cursor.Position.Y - mouseY
        End If
    End Sub

    Private Sub PanelTop_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseUp
        drag = False
    End Sub

    Private Sub PanelLeft_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelLeft.MouseDown
        ' Make left panel draggable
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PanelLeft_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelLeft.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mouseX
            Me.Top = Cursor.Position.Y - mouseY
        End If
    End Sub

    Private Sub PanelLeft_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelLeft.MouseUp
        drag = False
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Keep data in variables
        custname = txtOrderName.Text
        phone = txtOrderPhone.Text
        address = txtOrderAddress.Text
        state = txtOrderState.Text
        city = txtOrderCity.Text

        ' Convert input values to numeric variables
        qty(0) = Integer.Parse(cbQtyBurger.Text)
        qty(1) = Integer.Parse(cbQtyChicken.Text)
        qty(2) = Integer.Parse(cbQtyLasagna.Text)
        qty(3) = Integer.Parse(cbQtyMilo.Text)

        If rbOrderMale.Checked Then
            gender = "Male"
        ElseIf rbOrderFemale.Checked Then
            gender = "Female"
        End If

        ' User should give address and total can't be zero
        If txtOrderAddress.Text = "" Then
            MessageBox.Show("You need to give your address before submit the order!", "PUO Makan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf qty(0) = 0 And qty(1) = 0 And qty(2) = 0 And qty(3) = 0 Then
            MessageBox.Show("Please choose your food before submit the order!", "PUO Makan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Exception handling
            Try
                priceBurger = PRICE_BURGER * qty(0)
                priceChicken = PRICE_CHICKEN * qty(1)
                priceLasagna = PRICE_LASAGNA * qty(2)
                priceMilo = PRICE_MILO * qty(3)

                totalPrice = priceBurger + priceChicken + priceLasagna + priceMilo

                ' Text label in panel tracking not change if user not give the data
                If txtOrderName.Text = "" Then
                    lblNameShow.Text = "Name"
                Else
                    lblNameShow.Text = custname
                End If

                If txtOrderPhone.Text = "" Then
                    lblPhoneShow.Text = "Phone Number"
                Else
                    lblPhoneShow.Text = phone
                End If

                If txtOrderState.Text = "" Then
                    lblStateShow.Text = "State"
                Else
                    lblStateShow.Text = state
                End If

                If txtOrderCity.Text = "" Then
                    lblCityShow.Text = "City"
                Else
                    lblCityShow.Text = city
                End If

                lblGenderShow.Text = gender
                lblAddressShow.Text = address

                lblQtyBurgerShow.Text = qty(0)
                lblQtyChickenShow.Text = qty(1)
                lblQtyLasagnaShow.Text = qty(2)
                lblQtyMiloShow.Text = qty(3)

                lblPriceBurgerShow.Text = priceBurger
                lblPriceChickenShow.Text = priceChicken
                lblPriceLasagnaShow.Text = priceLasagna
                lblPriceMiloShow.Text = priceMilo

                lblTotalPriceShow.Text = "RM " & totalPrice
                lblStatusShow.Text = "In Delivery"

                MessageBox.Show("Your order has been submitted, thank you!", "PUO Makan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Invalid data type, try again!", "PUO Makan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            ' Clear the form after submit
            txtOrderName.Clear()
            rbOrderMale.Checked = True
            rbOrderFemale.Checked = False
            txtOrderAddress.Clear()
            txtOrderState.Clear()
            txtOrderCity.Clear()
            txtOrderPhone.Clear()
            cbQtyBurger.Text = 0
            cbQtyChicken.Text = 0
            cbQtyLasagna.Text = 0
            cbQtyMilo.Text = 0
            lblOrderShowTotal.Text = "RM 0"
            txtOrderName.Focus()
        End If
    End Sub

    Private Sub btnReceived_Click(sender As Object, e As EventArgs) Handles btnReceived.Click
        ' Clear tracking after user received the order
        lblNameShow.Text = "Name"
        lblGenderShow.Text = "Gender"
        lblPhoneShow.Text = "Phone Number"
        lblAddressShow.Text = "Address"
        lblStateShow.Text = "State"
        lblCityShow.Text = "City"

        lblQtyBurgerShow.Text = "0"
        lblQtyChickenShow.Text = "0"
        lblQtyLasagnaShow.Text = "0"
        lblQtyMiloShow.Text = "0"

        lblPriceBurgerShow.Text = "0"
        lblPriceChickenShow.Text = "0"
        lblPriceLasagnaShow.Text = "0"
        lblPriceMiloShow.Text = "0"

        lblTotalPriceShow.Text = "RM 0"
        lblStatusShow.Text = "Waiting"
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Convert input values to numeric variables.
        orderQty(0) = Integer.Parse(cbQtyBurger.Text)
        orderQty(1) = Integer.Parse(cbQtyChicken.Text)
        orderQty(2) = Integer.Parse(cbQtyLasagna.Text)
        orderQty(3) = Integer.Parse(cbQtyMilo.Text)

        ' Exception handling
        Try
            orderBurger = PRICE_BURGER * orderQty(0)
            orderChicken = PRICE_CHICKEN * orderQty(1)
            orderLasagna = PRICE_LASAGNA * orderQty(2)
            orderMilo = PRICE_MILO * orderQty(3)

            orderTotal = orderBurger + orderChicken + orderLasagna + orderMilo

            lblOrderShowTotal.Text = "RM " & orderTotal
        Catch ex As Exception
            MessageBox.Show("Invalid data type, try again!", "PUO Makan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub StoreBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StoreBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PUODatabaseDataSet)

    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PUODatabaseDataSet.Store' table. You can move, or remove it, as needed.
        Me.StoreTableAdapter.Fill(Me.PUODatabaseDataSet.Store)

    End Sub
End Class
