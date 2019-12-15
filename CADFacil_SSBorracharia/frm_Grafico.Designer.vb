<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Grafico
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.dgvVenda = New System.Windows.Forms.DataGridView()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.chrColuna = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chrPizza = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chrLinha = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnPizza = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnColuna = New System.Windows.Forms.Button()
        Me.btnLinha = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrColuna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrLinha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvVenda
        '
        Me.dgvVenda.AllowUserToAddRows = False
        Me.dgvVenda.AllowUserToDeleteRows = False
        Me.dgvVenda.AllowUserToResizeColumns = False
        Me.dgvVenda.AllowUserToResizeRows = False
        Me.dgvVenda.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvVenda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVenda.Location = New System.Drawing.Point(6, 232)
        Me.dgvVenda.MultiSelect = False
        Me.dgvVenda.Name = "dgvVenda"
        Me.dgvVenda.ReadOnly = True
        Me.dgvVenda.RowHeadersVisible = False
        Me.dgvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVenda.Size = New System.Drawing.Size(530, 201)
        Me.dgvVenda.TabIndex = 8
        '
        'btnFechar
        '
        Me.btnFechar.AutoSize = True
        Me.btnFechar.Location = New System.Drawing.Point(450, 203)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 23)
        Me.btnFechar.TabIndex = 9
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'chrColuna
        '
        ChartArea1.Name = "ChartArea1"
        Me.chrColuna.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chrColuna.Legends.Add(Legend1)
        Me.chrColuna.Location = New System.Drawing.Point(6, 27)
        Me.chrColuna.Name = "chrColuna"
        Me.chrColuna.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Vendas"
        Me.chrColuna.Series.Add(Series1)
        Me.chrColuna.Size = New System.Drawing.Size(429, 199)
        Me.chrColuna.TabIndex = 12
        Me.chrColuna.Text = "Chart1"
        '
        'chrPizza
        '
        ChartArea2.Name = "ChartArea1"
        Me.chrPizza.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chrPizza.Legends.Add(Legend2)
        Me.chrPizza.Location = New System.Drawing.Point(6, 27)
        Me.chrPizza.Name = "chrPizza"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.IsValueShownAsLabel = True
        Series2.Legend = "Legend1"
        Series2.Name = "MESES"
        Series2.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.Empty
        Series2.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Diamond
        Series2.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Empty
        Series2.YValuesPerPoint = 2
        Me.chrPizza.Series.Add(Series2)
        Me.chrPizza.Size = New System.Drawing.Size(429, 199)
        Me.chrPizza.TabIndex = 13
        Me.chrPizza.Visible = False
        '
        'chrLinha
        '
        ChartArea3.Name = "ChartArea1"
        Me.chrLinha.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chrLinha.Legends.Add(Legend3)
        Me.chrLinha.Location = New System.Drawing.Point(6, 27)
        Me.chrLinha.Name = "chrLinha"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Legend = "Legend1"
        Series3.Name = "Total Venda"
        Me.chrLinha.Series.Add(Series3)
        Me.chrLinha.Size = New System.Drawing.Size(429, 199)
        Me.chrLinha.TabIndex = 14
        Me.chrLinha.Text = "Chart3"
        Me.chrLinha.Visible = False
        '
        'btnPizza
        '
        Me.btnPizza.Location = New System.Drawing.Point(11, 19)
        Me.btnPizza.Name = "btnPizza"
        Me.btnPizza.Size = New System.Drawing.Size(75, 23)
        Me.btnPizza.TabIndex = 15
        Me.btnPizza.Text = "Pizza"
        Me.btnPizza.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.btnColuna)
        Me.GroupBox1.Controls.Add(Me.btnLinha)
        Me.GroupBox1.Controls.Add(Me.btnPizza)
        Me.GroupBox1.Location = New System.Drawing.Point(439, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(97, 111)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gráficos"
        '
        'btnColuna
        '
        Me.btnColuna.Location = New System.Drawing.Point(11, 77)
        Me.btnColuna.Name = "btnColuna"
        Me.btnColuna.Size = New System.Drawing.Size(75, 23)
        Me.btnColuna.TabIndex = 17
        Me.btnColuna.Text = "Coluna"
        Me.btnColuna.UseVisualStyleBackColor = True
        '
        'btnLinha
        '
        Me.btnLinha.Location = New System.Drawing.Point(11, 48)
        Me.btnLinha.Name = "btnLinha"
        Me.btnLinha.Size = New System.Drawing.Size(75, 23)
        Me.btnLinha.TabIndex = 16
        Me.btnLinha.Text = "Linha"
        Me.btnLinha.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Gráficos de Vendas"
        '
        'frm_Grafico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(542, 439)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chrColuna)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chrLinha)
        Me.Controls.Add(Me.chrPizza)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.dgvVenda)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Grafico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Histórico de Vendas"
        CType(Me.dgvVenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrColuna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrPizza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrLinha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvVenda As System.Windows.Forms.DataGridView
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents chrColuna As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents chrPizza As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents chrLinha As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnPizza As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnColuna As System.Windows.Forms.Button
    Friend WithEvents btnLinha As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
