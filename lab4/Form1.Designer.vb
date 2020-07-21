<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.components = New System.ComponentModel.Container()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.cbMake = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.ckCondition = New System.Windows.Forms.CheckBox()
        Me.lvCarDisplay = New System.Windows.Forms.ListView()
        Me.colCondition = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.numYear = New System.Windows.Forms.NumericUpDown()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.ToolTipCar = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(36, 22)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(100, 23)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make :"
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(36, 56)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(100, 23)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "M&odel:"
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(36, 90)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(100, 23)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(36, 124)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price:"
        '
        'cbMake
        '
        Me.cbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMake.FormattingEnabled = True
        Me.cbMake.Items.AddRange(New Object() {"Toyota", "Tesla", "Honda", "Nissan", "BMW", "Hyundai", "General Motors", "Ford", "Volkswagen"})
        Me.cbMake.Location = New System.Drawing.Point(97, 19)
        Me.cbMake.Name = "cbMake"
        Me.cbMake.Size = New System.Drawing.Size(121, 21)
        Me.cbMake.TabIndex = 1
        Me.ToolTipCar.SetToolTip(Me.cbMake, "Select the Manufacturer of the Car")
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(97, 55)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(121, 20)
        Me.txtModel.TabIndex = 3
        Me.ToolTipCar.SetToolTip(Me.txtModel, "Enter the model of the car")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(97, 126)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 7
        Me.ToolTipCar.SetToolTip(Me.txtPrice, "Enter the Price of the Car")
        '
        'lblNew
        '
        Me.lblNew.AutoSize = True
        Me.lblNew.Location = New System.Drawing.Point(35, 158)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(32, 13)
        Me.lblNew.TabIndex = 8
        Me.lblNew.Text = "&New:"
        '
        'ckCondition
        '
        Me.ckCondition.AutoSize = True
        Me.ckCondition.Location = New System.Drawing.Point(97, 160)
        Me.ckCondition.Name = "ckCondition"
        Me.ckCondition.Size = New System.Drawing.Size(15, 14)
        Me.ckCondition.TabIndex = 9
        Me.ToolTipCar.SetToolTip(Me.ckCondition, "Select If it is new or used.")
        Me.ckCondition.UseVisualStyleBackColor = True
        '
        'lvCarDisplay
        '
        Me.lvCarDisplay.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCondition, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvCarDisplay.FullRowSelect = True
        Me.lvCarDisplay.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvCarDisplay.HideSelection = False
        Me.lvCarDisplay.Location = New System.Drawing.Point(12, 178)
        Me.lvCarDisplay.MultiSelect = False
        Me.lvCarDisplay.Name = "lvCarDisplay"
        Me.lvCarDisplay.Size = New System.Drawing.Size(474, 170)
        Me.lvCarDisplay.TabIndex = 10
        Me.ToolTipCar.SetToolTip(Me.lvCarDisplay, "Current Car List")
        Me.lvCarDisplay.UseCompatibleStateImageBehavior = False
        Me.lvCarDisplay.View = System.Windows.Forms.View.Details
        '
        'colCondition
        '
        Me.colCondition.Text = "New"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 81
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 154
        '
        'btnEnter
        '
        Me.btnEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnter.Location = New System.Drawing.Point(231, 474)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.ToolTipCar.SetToolTip(Me.btnEnter, "Click here to enter the record")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(318, 474)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.ToolTipCar.SetToolTip(Me.btnReset, "Click to reset the fields.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(404, 475)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.ToolTipCar.SetToolTip(Me.btnExit, "Click to exit the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'numYear
        '
        Me.numYear.Location = New System.Drawing.Point(97, 92)
        Me.numYear.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.numYear.Minimum = New Decimal(New Integer() {1920, 0, 0, 0})
        Me.numYear.Name = "numYear"
        Me.numYear.Size = New System.Drawing.Size(120, 20)
        Me.numYear.TabIndex = 5
        Me.ToolTipCar.SetToolTip(Me.numYear, "Select the Year")
        Me.numYear.Value = New Decimal(New Integer() {2020, 0, 0, 0})
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(12, 356)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(474, 97)
        Me.txtOutput.TabIndex = 11
        Me.ToolTipCar.SetToolTip(Me.txtOutput, "Error Details")
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(498, 505)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.numYear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lvCarDisplay)
        Me.Controls.Add(Me.ckCondition)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cbMake)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory "
        CType(Me.numYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents cbMake As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblNew As Label
    Friend WithEvents ckCondition As CheckBox
    Friend WithEvents lvCarDisplay As ListView
    Friend WithEvents colCondition As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents numYear As NumericUpDown
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents ToolTipCar As ToolTip
End Class
