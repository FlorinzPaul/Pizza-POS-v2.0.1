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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbCash = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PizzaFlavor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Toppings = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PizzaPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToppingsPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CombinedTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnItalian = New System.Windows.Forms.Button()
        Me.btnVeggie = New System.Windows.Forms.Button()
        Me.btnClassic = New System.Windows.Forms.Button()
        Me.btnBacon = New System.Windows.Forms.Button()
        Me.btnMozzarella = New System.Windows.Forms.Button()
        Me.btnHawaiian = New System.Windows.Forms.Button()
        Me.btnPepperoni = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pnlSelection = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlSelection.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 85)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rage Italic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(216, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 80)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Zlice  `A   Pizza"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Padding = New System.Windows.Forms.Padding(3)
        Me.PictureBox1.Size = New System.Drawing.Size(87, 91)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.tbCash)
        Me.Panel2.Controls.Add(Me.lblChange)
        Me.Panel2.Controls.Add(Me.lblCash)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lblGrandTotal)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 298)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(970, 228)
        Me.Panel2.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(25, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 19)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Enter Cash Amount :"
        '
        'tbCash
        '
        Me.tbCash.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCash.Location = New System.Drawing.Point(226, 188)
        Me.tbCash.Name = "tbCash"
        Me.tbCash.Size = New System.Drawing.Size(121, 27)
        Me.tbCash.TabIndex = 7
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.SystemColors.Control
        Me.lblChange.Location = New System.Drawing.Point(222, 67)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(45, 19)
        Me.lblChange.TabIndex = 6
        Me.lblChange.Text = "00.00"
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCash.Location = New System.Drawing.Point(222, 43)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(45, 19)
        Me.lblCash.TabIndex = 5
        Me.lblCash.Text = "00.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(25, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 19)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Change :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(25, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Cash :"
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.ForeColor = System.Drawing.SystemColors.Control
        Me.lblGrandTotal.Location = New System.Drawing.Point(221, 14)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(62, 26)
        Me.lblGrandTotal.TabIndex = 2
        Me.lblGrandTotal.Text = "00.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(25, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Grand Total :"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel11)
        Me.Panel7.Controls.Add(Me.dgvOrders)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(366, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(604, 228)
        Me.Panel7.TabIndex = 0
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Gray
        Me.Panel11.Controls.Add(Me.btnPrintReceipt)
        Me.Panel11.Controls.Add(Me.btnReset)
        Me.Panel11.Controls.Add(Me.btnDelete)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 173)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(604, 55)
        Me.Panel11.TabIndex = 1
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPrintReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintReceipt.FlatAppearance.BorderSize = 0
        Me.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintReceipt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintReceipt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrintReceipt.Location = New System.Drawing.Point(189, 16)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(109, 28)
        Me.btnPrintReceipt.TabIndex = 2
        Me.btnPrintReceipt.Text = "Print Receipt"
        Me.btnPrintReceipt.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Gainsboro
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReset.Location = New System.Drawing.Point(469, 16)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(109, 28)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDelete.Location = New System.Drawing.Point(329, 16)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(109, 28)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'dgvOrders
        '
        Me.dgvOrders.AllowUserToAddRows = False
        Me.dgvOrders.AllowUserToDeleteRows = False
        Me.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Quantity, Me.PizzaFlavor, Me.Toppings, Me.PizzaPrice, Me.ToppingsPrice, Me.CombinedTotal})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrders.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOrders.Location = New System.Drawing.Point(0, 0)
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.ReadOnly = True
        Me.dgvOrders.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvOrders.RowHeadersVisible = False
        Me.dgvOrders.Size = New System.Drawing.Size(604, 228)
        Me.dgvOrders.TabIndex = 0
        '
        'Quantity
        '
        Me.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 71
        '
        'PizzaFlavor
        '
        Me.PizzaFlavor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PizzaFlavor.HeaderText = "Pizza Flavor"
        Me.PizzaFlavor.Name = "PizzaFlavor"
        Me.PizzaFlavor.ReadOnly = True
        Me.PizzaFlavor.Width = 89
        '
        'Toppings
        '
        Me.Toppings.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Toppings.HeaderText = "Extra Topping/s"
        Me.Toppings.Name = "Toppings"
        Me.Toppings.ReadOnly = True
        Me.Toppings.Width = 108
        '
        'PizzaPrice
        '
        Me.PizzaPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PizzaPrice.HeaderText = "Pizza Price"
        Me.PizzaPrice.Name = "PizzaPrice"
        Me.PizzaPrice.ReadOnly = True
        Me.PizzaPrice.Width = 84
        '
        'ToppingsPrice
        '
        Me.ToppingsPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ToppingsPrice.HeaderText = "Topping/s Price"
        Me.ToppingsPrice.Name = "ToppingsPrice"
        Me.ToppingsPrice.ReadOnly = True
        Me.ToppingsPrice.Width = 108
        '
        'CombinedTotal
        '
        Me.CombinedTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CombinedTotal.HeaderText = "Combined Total"
        Me.CombinedTotal.Name = "CombinedTotal"
        Me.CombinedTotal.ReadOnly = True
        Me.CombinedTotal.Width = 106
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel3.Controls.Add(Me.btnItalian)
        Me.Panel3.Controls.Add(Me.btnVeggie)
        Me.Panel3.Controls.Add(Me.btnClassic)
        Me.Panel3.Controls.Add(Me.btnBacon)
        Me.Panel3.Controls.Add(Me.btnMozzarella)
        Me.Panel3.Controls.Add(Me.btnHawaiian)
        Me.Panel3.Controls.Add(Me.btnPepperoni)
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Panel10)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 85)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(214, 526)
        Me.Panel3.TabIndex = 2
        '
        'btnItalian
        '
        Me.btnItalian.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnItalian.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnItalian.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnItalian.FlatAppearance.BorderSize = 0
        Me.btnItalian.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnItalian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItalian.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItalian.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnItalian.Image = CType(resources.GetObject("btnItalian.Image"), System.Drawing.Image)
        Me.btnItalian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItalian.Location = New System.Drawing.Point(0, 451)
        Me.btnItalian.Name = "btnItalian"
        Me.btnItalian.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnItalian.Size = New System.Drawing.Size(214, 68)
        Me.btnItalian.TabIndex = 8
        Me.btnItalian.Text = "               Italian Style"
        Me.btnItalian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItalian.UseVisualStyleBackColor = False
        '
        'btnVeggie
        '
        Me.btnVeggie.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnVeggie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVeggie.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVeggie.FlatAppearance.BorderSize = 0
        Me.btnVeggie.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnVeggie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVeggie.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeggie.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVeggie.Image = CType(resources.GetObject("btnVeggie.Image"), System.Drawing.Image)
        Me.btnVeggie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVeggie.Location = New System.Drawing.Point(0, 383)
        Me.btnVeggie.Name = "btnVeggie"
        Me.btnVeggie.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnVeggie.Size = New System.Drawing.Size(214, 68)
        Me.btnVeggie.TabIndex = 7
        Me.btnVeggie.Text = "               Vegetarian Pizza"
        Me.btnVeggie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVeggie.UseVisualStyleBackColor = False
        '
        'btnClassic
        '
        Me.btnClassic.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClassic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClassic.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClassic.FlatAppearance.BorderSize = 0
        Me.btnClassic.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnClassic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClassic.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassic.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClassic.Image = CType(resources.GetObject("btnClassic.Image"), System.Drawing.Image)
        Me.btnClassic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClassic.Location = New System.Drawing.Point(0, 315)
        Me.btnClassic.Name = "btnClassic"
        Me.btnClassic.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnClassic.Size = New System.Drawing.Size(214, 68)
        Me.btnClassic.TabIndex = 6
        Me.btnClassic.Text = "               Classic"
        Me.btnClassic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClassic.UseVisualStyleBackColor = False
        '
        'btnBacon
        '
        Me.btnBacon.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBacon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBacon.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBacon.FlatAppearance.BorderSize = 0
        Me.btnBacon.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnBacon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBacon.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBacon.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBacon.Image = CType(resources.GetObject("btnBacon.Image"), System.Drawing.Image)
        Me.btnBacon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBacon.Location = New System.Drawing.Point(0, 247)
        Me.btnBacon.Name = "btnBacon"
        Me.btnBacon.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnBacon.Size = New System.Drawing.Size(214, 68)
        Me.btnBacon.TabIndex = 5
        Me.btnBacon.Text = "               Bacon and Cheese"
        Me.btnBacon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBacon.UseVisualStyleBackColor = False
        '
        'btnMozzarella
        '
        Me.btnMozzarella.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnMozzarella.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMozzarella.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMozzarella.FlatAppearance.BorderSize = 0
        Me.btnMozzarella.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnMozzarella.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMozzarella.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMozzarella.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMozzarella.Image = CType(resources.GetObject("btnMozzarella.Image"), System.Drawing.Image)
        Me.btnMozzarella.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMozzarella.Location = New System.Drawing.Point(0, 179)
        Me.btnMozzarella.Name = "btnMozzarella"
        Me.btnMozzarella.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnMozzarella.Size = New System.Drawing.Size(214, 68)
        Me.btnMozzarella.TabIndex = 4
        Me.btnMozzarella.Text = "               Mozzarella Pizza"
        Me.btnMozzarella.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMozzarella.UseVisualStyleBackColor = False
        '
        'btnHawaiian
        '
        Me.btnHawaiian.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnHawaiian.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHawaiian.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHawaiian.FlatAppearance.BorderSize = 0
        Me.btnHawaiian.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnHawaiian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHawaiian.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHawaiian.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHawaiian.Image = CType(resources.GetObject("btnHawaiian.Image"), System.Drawing.Image)
        Me.btnHawaiian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHawaiian.Location = New System.Drawing.Point(0, 111)
        Me.btnHawaiian.Name = "btnHawaiian"
        Me.btnHawaiian.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnHawaiian.Size = New System.Drawing.Size(214, 68)
        Me.btnHawaiian.TabIndex = 3
        Me.btnHawaiian.Text = "               Hawaiian Pizza"
        Me.btnHawaiian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHawaiian.UseVisualStyleBackColor = False
        '
        'btnPepperoni
        '
        Me.btnPepperoni.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnPepperoni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPepperoni.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPepperoni.FlatAppearance.BorderSize = 0
        Me.btnPepperoni.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnPepperoni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPepperoni.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPepperoni.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPepperoni.Image = CType(resources.GetObject("btnPepperoni.Image"), System.Drawing.Image)
        Me.btnPepperoni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPepperoni.Location = New System.Drawing.Point(0, 43)
        Me.btnPepperoni.Name = "btnPepperoni"
        Me.btnPepperoni.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnPepperoni.Size = New System.Drawing.Size(214, 68)
        Me.btnPepperoni.TabIndex = 0
        Me.btnPepperoni.Text = "               Pepperoni Pizza"
        Me.btnPepperoni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPepperoni.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 33)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(214, 10)
        Me.Panel8.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.Location = New System.Drawing.Point(0, 23)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(214, 10)
        Me.Panel9.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(0, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Pizza Flavors :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Panel6)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(214, 10)
        Me.Panel10.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(0, 23)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(214, 10)
        Me.Panel6.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.pnlSelection)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(214, 85)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(970, 526)
        Me.Panel4.TabIndex = 3
        '
        'pnlSelection
        '
        Me.pnlSelection.Controls.Add(Me.pnlMain)
        Me.pnlSelection.Controls.Add(Me.Panel5)
        Me.pnlSelection.Controls.Add(Me.Label2)
        Me.pnlSelection.Controls.Add(Me.PictureBox2)
        Me.pnlSelection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSelection.Location = New System.Drawing.Point(0, 0)
        Me.pnlSelection.Name = "pnlSelection"
        Me.pnlSelection.Size = New System.Drawing.Size(970, 298)
        Me.pnlSelection.TabIndex = 2
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.Gray
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(970, 298)
        Me.pnlMain.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(29, 92)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 21)
        Me.Panel5.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(153, 75)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(337, 349)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 611)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.pnlSelection.ResumeLayout(False)
        Me.pnlSelection.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnlSelection As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPepperoni As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents btnVeggie As Button
    Friend WithEvents btnClassic As Button
    Friend WithEvents btnBacon As Button
    Friend WithEvents btnMozzarella As Button
    Friend WithEvents btnHawaiian As Button
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents lblCash As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbCash As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPrintReceipt As Button
    Friend WithEvents btnItalian As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents PizzaFlavor As DataGridViewTextBoxColumn
    Friend WithEvents Toppings As DataGridViewTextBoxColumn
    Friend WithEvents PizzaPrice As DataGridViewTextBoxColumn
    Friend WithEvents ToppingsPrice As DataGridViewTextBoxColumn
    Friend WithEvents CombinedTotal As DataGridViewTextBoxColumn
End Class
