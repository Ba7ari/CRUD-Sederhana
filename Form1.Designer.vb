<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tvData = New System.Windows.Forms.TreeView
        Me.Cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HapusNIK = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateNIK = New System.Windows.Forms.ToolStripMenuItem
        Me.imgLst = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTelp = New System.Windows.Forms.TextBox
        Me.txtAlamat = New System.Windows.Forms.TextBox
        Me.txtNama = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdTambah = New System.Windows.Forms.Button
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdBatal = New System.Windows.Forms.Button
        Me.Cms.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tvData
        '
        Me.tvData.ContextMenuStrip = Me.Cms
        Me.tvData.ImageIndex = 1
        Me.tvData.ImageList = Me.imgLst
        Me.tvData.Location = New System.Drawing.Point(12, 12)
        Me.tvData.Name = "tvData"
        Me.tvData.SelectedImageIndex = 0
        Me.tvData.Size = New System.Drawing.Size(175, 238)
        Me.tvData.TabIndex = 0
        '
        'Cms
        '
        Me.Cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HapusNIK, Me.UpdateNIK})
        Me.Cms.Name = "Cms"
        Me.Cms.Size = New System.Drawing.Size(113, 48)
        '
        'HapusNIK
        '
        Me.HapusNIK.Name = "HapusNIK"
        Me.HapusNIK.Size = New System.Drawing.Size(112, 22)
        Me.HapusNIK.Text = "Hapus"
        '
        'UpdateNIK
        '
        Me.UpdateNIK.Name = "UpdateNIK"
        Me.UpdateNIK.Size = New System.Drawing.Size(112, 22)
        Me.UpdateNIK.Text = "Update"
        '
        'imgLst
        '
        Me.imgLst.ImageStream = CType(resources.GetObject("imgLst.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgLst.TransparentColor = System.Drawing.Color.Transparent
        Me.imgLst.Images.SetKeyName(0, "Dir.ico")
        Me.imgLst.Images.SetKeyName(1, "folder_classic_stuffed.png")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTelp)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(208, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 132)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Pegawai"
        '
        'txtTelp
        '
        Me.txtTelp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtTelp.Enabled = False
        Me.txtTelp.Location = New System.Drawing.Point(68, 80)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(230, 20)
        Me.txtTelp.TabIndex = 5
        '
        'txtAlamat
        '
        Me.txtAlamat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtAlamat.Enabled = False
        Me.txtAlamat.Location = New System.Drawing.Point(68, 54)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(230, 20)
        Me.txtAlamat.TabIndex = 4
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNama.Enabled = False
        Me.txtNama.Location = New System.Drawing.Point(68, 28)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(230, 20)
        Me.txtNama.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Telp :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Alamat :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama : "
        '
        'cmdTambah
        '
        Me.cmdTambah.Location = New System.Drawing.Point(208, 159)
        Me.cmdTambah.Name = "cmdTambah"
        Me.cmdTambah.Size = New System.Drawing.Size(66, 28)
        Me.cmdTambah.TabIndex = 2
        Me.cmdTambah.Text = "Tambah"
        Me.cmdTambah.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Enabled = False
        Me.cmdUpdate.Location = New System.Drawing.Point(280, 159)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(66, 28)
        Me.cmdUpdate.TabIndex = 3
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(209, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Klik kanan pada treeview untuk menampilkan menu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(195, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "*)"
        '
        'cmdBatal
        '
        Me.cmdBatal.Location = New System.Drawing.Point(352, 159)
        Me.cmdBatal.Name = "cmdBatal"
        Me.cmdBatal.Size = New System.Drawing.Size(66, 28)
        Me.cmdBatal.TabIndex = 6
        Me.cmdBatal.Text = "Batal"
        Me.cmdBatal.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 272)
        Me.Controls.Add(Me.cmdBatal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdTambah)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tvData)
        Me.Name = "frmMain"
        Me.Text = "CRUD Sederhana"
        Me.Cms.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tvData As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents imgLst As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HapusNIK As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtTelp As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents cmdTambah As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents UpdateNIK As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdBatal As System.Windows.Forms.Button

End Class
