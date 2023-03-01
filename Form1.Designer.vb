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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPayrollCalculator = New System.Windows.Forms.Label()
        Me.lblPaycheck = New System.Windows.Forms.Label()
        Me.lblCalculation = New System.Windows.Forms.Label()
        Me.lblamount = New System.Windows.Forms.Label()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.btnComputeTax = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblfica = New System.Windows.Forms.Label()
        Me.decFederal = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Payroll_Calculator.My.Resources.Resources.payroll
        Me.PictureBox1.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(413, 274)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblPayrollCalculator
        '
        Me.lblPayrollCalculator.AutoSize = True
        Me.lblPayrollCalculator.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayrollCalculator.Location = New System.Drawing.Point(424, 58)
        Me.lblPayrollCalculator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPayrollCalculator.Name = "lblPayrollCalculator"
        Me.lblPayrollCalculator.Size = New System.Drawing.Size(420, 54)
        Me.lblPayrollCalculator.TabIndex = 1
        Me.lblPayrollCalculator.Text = "Payroll Calculator "
        '
        'lblPaycheck
        '
        Me.lblPaycheck.AutoSize = True
        Me.lblPaycheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaycheck.Location = New System.Drawing.Point(607, 138)
        Me.lblPaycheck.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPaycheck.Name = "lblPaycheck"
        Me.lblPaycheck.Size = New System.Drawing.Size(183, 39)
        Me.lblPaycheck.TabIndex = 2
        Me.lblPaycheck.Text = "Paycheck "
        '
        'lblCalculation
        '
        Me.lblCalculation.AutoSize = True
        Me.lblCalculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculation.Location = New System.Drawing.Point(592, 196)
        Me.lblCalculation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCalculation.Name = "lblCalculation"
        Me.lblCalculation.Size = New System.Drawing.Size(198, 39)
        Me.lblCalculation.TabIndex = 3
        Me.lblCalculation.Text = "Calculation"
        '
        'lblamount
        '
        Me.lblamount.AutoSize = True
        Me.lblamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamount.Location = New System.Drawing.Point(308, 311)
        Me.lblamount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblamount.Name = "lblamount"
        Me.lblamount.Size = New System.Drawing.Size(237, 31)
        Me.lblamount.TabIndex = 4
        Me.lblamount.Text = "Enter Gross Pay:"
        '
        'txtPay
        '
        Me.txtPay.Location = New System.Drawing.Point(615, 318)
        Me.txtPay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(115, 22)
        Me.txtPay.TabIndex = 5
        '
        'btnComputeTax
        '
        Me.btnComputeTax.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnComputeTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeTax.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnComputeTax.Location = New System.Drawing.Point(211, 373)
        Me.btnComputeTax.Margin = New System.Windows.Forms.Padding(4)
        Me.btnComputeTax.Name = "btnComputeTax"
        Me.btnComputeTax.Size = New System.Drawing.Size(151, 54)
        Me.btnComputeTax.TabIndex = 6
        Me.btnComputeTax.Text = "Compute Taxes"
        Me.btnComputeTax.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClear.Location = New System.Drawing.Point(433, 373)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(151, 54)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.Location = New System.Drawing.Point(655, 373)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(151, 54)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblfica
        '
        Me.lblfica.AutoSize = True
        Me.lblfica.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfica.Location = New System.Drawing.Point(249, 455)
        Me.lblfica.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfica.Name = "lblfica"
        Me.lblfica.Size = New System.Drawing.Size(62, 24)
        Me.lblfica.TabIndex = 9
        Me.lblfica.Text = "FICA:"
        '
        'decFederal
        '
        Me.decFederal.AutoSize = True
        Me.decFederal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decFederal.Location = New System.Drawing.Point(459, 455)
        Me.decFederal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.decFederal.Name = "decFederal"
        Me.decFederal.Size = New System.Drawing.Size(129, 24)
        Me.decFederal.TabIndex = 10
        Me.decFederal.Text = "Federal Tax:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(660, 455)
        Me.lblState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(103, 24)
        Me.lblState.TabIndex = 11
        Me.lblState.Text = "State Tax:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(308, 512)
        Me.lblTotalCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(307, 31)
        Me.lblTotalCost.TabIndex = 12
        Me.lblTotalCost.Text = "Net Paycheck Income:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.decFederal)
        Me.Controls.Add(Me.lblfica)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnComputeTax)
        Me.Controls.Add(Me.txtPay)
        Me.Controls.Add(Me.lblamount)
        Me.Controls.Add(Me.lblCalculation)
        Me.Controls.Add(Me.lblPaycheck)
        Me.Controls.Add(Me.lblPayrollCalculator)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPayrollCalculator As Label
    Friend WithEvents lblPaycheck As Label
    Friend WithEvents lblCalculation As Label
    Friend WithEvents lblamount As Label
    Friend WithEvents txtPay As TextBox
    Friend WithEvents btnComputeTax As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblfica As Label
    Friend WithEvents decFederal As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblTotalCost As Label
End Class
