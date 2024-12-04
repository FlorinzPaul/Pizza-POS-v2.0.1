<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserContro_Selection
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblPizzaSelect = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudPizzaQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbFamSize = New System.Windows.Forms.RadioButton()
        Me.rbReg = New System.Windows.Forms.RadioButton()
        Me.rbSolo = New System.Windows.Forms.RadioButton()
        Me.pnlToppings = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbOnion = New System.Windows.Forms.CheckBox()
        Me.cbBacon = New System.Windows.Forms.CheckBox()
        Me.cbHam = New System.Windows.Forms.CheckBox()
        Me.cbMushroom = New System.Windows.Forms.CheckBox()
        Me.cbPineapple = New System.Windows.Forms.CheckBox()
        Me.cbGarlic = New System.Windows.Forms.CheckBox()
        Me.cbExtraCheese = New System.Windows.Forms.CheckBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.rbDeliver = New System.Windows.Forms.RadioButton()
        Me.rbTakeOut = New System.Windows.Forms.RadioButton()
        Me.rbDineIn = New System.Windows.Forms.RadioButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        CType(Me.nudPizzaQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlToppings.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPizzaSelect
        '
        Me.lblPizzaSelect.AutoSize = True
        Me.lblPizzaSelect.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPizzaSelect.Location = New System.Drawing.Point(55, 11)
        Me.lblPizzaSelect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPizzaSelect.Name = "lblPizzaSelect"
        Me.lblPizzaSelect.Size = New System.Drawing.Size(221, 33)
        Me.lblPizzaSelect.TabIndex = 0
        Me.lblPizzaSelect.Text = "Select Pizza Flavor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pizza Size :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Extra Toppings :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Service Type :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Pizza Quantity :"
        '
        'nudPizzaQuantity
        '
        Me.nudPizzaQuantity.Location = New System.Drawing.Point(196, 0)
        Me.nudPizzaQuantity.Name = "nudPizzaQuantity"
        Me.nudPizzaQuantity.Size = New System.Drawing.Size(120, 27)
        Me.nudPizzaQuantity.TabIndex = 5
        Me.nudPizzaQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblPizzaSelect)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(970, 48)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.nudPizzaQuantity)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(970, 44)
        Me.Panel2.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.rbFamSize)
        Me.Panel3.Controls.Add(Me.rbReg)
        Me.Panel3.Controls.Add(Me.rbSolo)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 92)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(970, 53)
        Me.Panel3.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(318, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 14)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "(₱150.00)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(449, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 14)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "(₱200.00)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(208, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 14)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "(₱85.00)"
        '
        'rbFamSize
        '
        Me.rbFamSize.AutoSize = True
        Me.rbFamSize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbFamSize.Location = New System.Drawing.Point(414, -2)
        Me.rbFamSize.Name = "rbFamSize"
        Me.rbFamSize.Size = New System.Drawing.Size(126, 23)
        Me.rbFamSize.TabIndex = 4
        Me.rbFamSize.Text = "Family Size 14''"
        Me.rbFamSize.UseVisualStyleBackColor = True
        '
        'rbReg
        '
        Me.rbReg.AutoSize = True
        Me.rbReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbReg.Location = New System.Drawing.Point(290, -2)
        Me.rbReg.Name = "rbReg"
        Me.rbReg.Size = New System.Drawing.Size(105, 23)
        Me.rbReg.TabIndex = 3
        Me.rbReg.Text = "Regular 10''"
        Me.rbReg.UseVisualStyleBackColor = True
        '
        'rbSolo
        '
        Me.rbSolo.AutoSize = True
        Me.rbSolo.Checked = True
        Me.rbSolo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbSolo.Location = New System.Drawing.Point(196, -2)
        Me.rbSolo.Name = "rbSolo"
        Me.rbSolo.Size = New System.Drawing.Size(74, 23)
        Me.rbSolo.TabIndex = 2
        Me.rbSolo.TabStop = True
        Me.rbSolo.Text = "Solo 7''"
        Me.rbSolo.UseVisualStyleBackColor = True
        '
        'pnlToppings
        '
        Me.pnlToppings.Controls.Add(Me.Label14)
        Me.pnlToppings.Controls.Add(Me.Label13)
        Me.pnlToppings.Controls.Add(Me.Label12)
        Me.pnlToppings.Controls.Add(Me.Label11)
        Me.pnlToppings.Controls.Add(Me.Label10)
        Me.pnlToppings.Controls.Add(Me.Label9)
        Me.pnlToppings.Controls.Add(Me.Label8)
        Me.pnlToppings.Controls.Add(Me.cbOnion)
        Me.pnlToppings.Controls.Add(Me.cbBacon)
        Me.pnlToppings.Controls.Add(Me.cbHam)
        Me.pnlToppings.Controls.Add(Me.cbMushroom)
        Me.pnlToppings.Controls.Add(Me.cbPineapple)
        Me.pnlToppings.Controls.Add(Me.cbGarlic)
        Me.pnlToppings.Controls.Add(Me.cbExtraCheese)
        Me.pnlToppings.Controls.Add(Me.Label2)
        Me.pnlToppings.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToppings.Location = New System.Drawing.Point(0, 145)
        Me.pnlToppings.Name = "pnlToppings"
        Me.pnlToppings.Size = New System.Drawing.Size(970, 68)
        Me.pnlToppings.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(585, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 14)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "(₱40.00)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(409, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 14)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "(₱30.00)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(780, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 14)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "(₱35.00)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(585, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 14)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "(₱40.00)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(409, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 14)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "(₱30.00)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(258, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 14)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "(₱50.00)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(258, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 14)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "(₱50.00)"
        '
        'cbOnion
        '
        Me.cbOnion.AutoSize = True
        Me.cbOnion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbOnion.Location = New System.Drawing.Point(337, 28)
        Me.cbOnion.Name = "cbOnion"
        Me.cbOnion.Size = New System.Drawing.Size(67, 23)
        Me.cbOnion.TabIndex = 9
        Me.cbOnion.Text = "Onion"
        Me.cbOnion.UseVisualStyleBackColor = True
        '
        'cbBacon
        '
        Me.cbBacon.AutoSize = True
        Me.cbBacon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbBacon.Location = New System.Drawing.Point(196, -1)
        Me.cbBacon.Name = "cbBacon"
        Me.cbBacon.Size = New System.Drawing.Size(68, 23)
        Me.cbBacon.TabIndex = 8
        Me.cbBacon.Text = "Bacon"
        Me.cbBacon.UseVisualStyleBackColor = True
        '
        'cbHam
        '
        Me.cbHam.AutoSize = True
        Me.cbHam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbHam.Location = New System.Drawing.Point(196, 28)
        Me.cbHam.Name = "cbHam"
        Me.cbHam.Size = New System.Drawing.Size(58, 23)
        Me.cbHam.TabIndex = 7
        Me.cbHam.Text = "Ham"
        Me.cbHam.UseVisualStyleBackColor = True
        '
        'cbMushroom
        '
        Me.cbMushroom.AutoSize = True
        Me.cbMushroom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbMushroom.Location = New System.Drawing.Point(487, 28)
        Me.cbMushroom.Name = "cbMushroom"
        Me.cbMushroom.Size = New System.Drawing.Size(97, 23)
        Me.cbMushroom.TabIndex = 6
        Me.cbMushroom.Text = "Mushroom"
        Me.cbMushroom.UseVisualStyleBackColor = True
        '
        'cbPineapple
        '
        Me.cbPineapple.AutoSize = True
        Me.cbPineapple.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbPineapple.Location = New System.Drawing.Point(487, -1)
        Me.cbPineapple.Name = "cbPineapple"
        Me.cbPineapple.Size = New System.Drawing.Size(92, 23)
        Me.cbPineapple.TabIndex = 5
        Me.cbPineapple.Text = "Pineapple"
        Me.cbPineapple.UseVisualStyleBackColor = True
        '
        'cbGarlic
        '
        Me.cbGarlic.AutoSize = True
        Me.cbGarlic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbGarlic.Location = New System.Drawing.Point(337, -2)
        Me.cbGarlic.Name = "cbGarlic"
        Me.cbGarlic.Size = New System.Drawing.Size(66, 23)
        Me.cbGarlic.TabIndex = 4
        Me.cbGarlic.Text = "Garlic"
        Me.cbGarlic.UseVisualStyleBackColor = True
        '
        'cbExtraCheese
        '
        Me.cbExtraCheese.AutoSize = True
        Me.cbExtraCheese.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbExtraCheese.Location = New System.Drawing.Point(661, -1)
        Me.cbExtraCheese.Name = "cbExtraCheese"
        Me.cbExtraCheese.Size = New System.Drawing.Size(113, 23)
        Me.cbExtraCheese.TabIndex = 3
        Me.cbExtraCheese.Text = "Extra Cheese"
        Me.cbExtraCheese.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.rbDeliver)
        Me.Panel5.Controls.Add(Me.rbTakeOut)
        Me.Panel5.Controls.Add(Me.rbDineIn)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 213)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(970, 40)
        Me.Panel5.TabIndex = 10
        '
        'rbDeliver
        '
        Me.rbDeliver.AutoSize = True
        Me.rbDeliver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbDeliver.Location = New System.Drawing.Point(414, -2)
        Me.rbDeliver.Name = "rbDeliver"
        Me.rbDeliver.Size = New System.Drawing.Size(73, 23)
        Me.rbDeliver.TabIndex = 6
        Me.rbDeliver.Text = "Deliver"
        Me.rbDeliver.UseVisualStyleBackColor = True
        '
        'rbTakeOut
        '
        Me.rbTakeOut.AutoSize = True
        Me.rbTakeOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbTakeOut.Location = New System.Drawing.Point(290, -2)
        Me.rbTakeOut.Name = "rbTakeOut"
        Me.rbTakeOut.Size = New System.Drawing.Size(84, 23)
        Me.rbTakeOut.TabIndex = 5
        Me.rbTakeOut.Text = "Take Out"
        Me.rbTakeOut.UseVisualStyleBackColor = True
        '
        'rbDineIn
        '
        Me.rbDineIn.AutoSize = True
        Me.rbDineIn.Checked = True
        Me.rbDineIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbDineIn.Location = New System.Drawing.Point(196, -2)
        Me.rbDineIn.Name = "rbDineIn"
        Me.rbDineIn.Size = New System.Drawing.Size(73, 23)
        Me.rbDineIn.TabIndex = 4
        Me.rbDineIn.TabStop = True
        Me.rbDineIn.Text = "Dine In"
        Me.rbDineIn.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnAddOrder)
        Me.Panel6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 253)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(970, 72)
        Me.Panel6.TabIndex = 11
        '
        'btnAddOrder
        '
        Me.btnAddOrder.BackColor = System.Drawing.Color.Gainsboro
        Me.btnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddOrder.FlatAppearance.BorderSize = 0
        Me.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddOrder.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddOrder.Location = New System.Drawing.Point(835, 8)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(109, 28)
        Me.btnAddOrder.TabIndex = 0
        Me.btnAddOrder.Text = "Add Order"
        Me.btnAddOrder.UseVisualStyleBackColor = False
        '
        'UserContro_Selection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.Gray
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.pnlToppings)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UserContro_Selection"
        Me.Size = New System.Drawing.Size(970, 325)
        CType(Me.nudPizzaQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlToppings.ResumeLayout(False)
        Me.pnlToppings.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPizzaSelect As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nudPizzaQuantity As NumericUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnlToppings As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents rbFamSize As RadioButton
    Friend WithEvents rbReg As RadioButton
    Friend WithEvents rbSolo As RadioButton
    Friend WithEvents rbDeliver As RadioButton
    Friend WithEvents rbTakeOut As RadioButton
    Friend WithEvents rbDineIn As RadioButton
    Friend WithEvents cbHam As CheckBox
    Friend WithEvents cbMushroom As CheckBox
    Friend WithEvents cbPineapple As CheckBox
    Friend WithEvents cbGarlic As CheckBox
    Friend WithEvents cbExtraCheese As CheckBox
    Friend WithEvents cbOnion As CheckBox
    Friend WithEvents cbBacon As CheckBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
End Class
