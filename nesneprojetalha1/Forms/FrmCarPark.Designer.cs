namespace nesneprojetalha1
{
    partial class FrmCarPark
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtAmount = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtSuitNo = new TextBox();
            label5 = new Label();
            cbBlocksId = new ComboBox();
            cbType = new ComboBox();
            label6 = new Label();
            dgCarPark = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dtDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgCarPark).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 351);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Plaka No";
            // 
            // txtId
            // 
            txtId.Location = new Point(326, 348);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 348);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Giriş Tarihi";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(326, 406);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 406);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 5;
            label3.Text = "Araç Sayısı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(499, 406);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 6;
            label4.Text = "Daire No";
            // 
            // txtSuitNo
            // 
            txtSuitNo.Location = new Point(591, 406);
            txtSuitNo.Name = "txtSuitNo";
            txtSuitNo.Size = new Size(125, 27);
            txtSuitNo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(256, 464);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 8;
            label5.Text = "Blok";
            // 
            // cbBlocksId
            // 
            cbBlocksId.FormattingEnabled = true;
            cbBlocksId.Location = new Point(326, 461);
            cbBlocksId.Name = "cbBlocksId";
            cbBlocksId.Size = new Size(125, 28);
            cbBlocksId.TabIndex = 9;
            cbBlocksId.SelectedIndexChanged += cbBlock_SelectedIndexChanged;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(591, 464);
            cbType.Name = "cbType";
            cbType.Size = new Size(125, 28);
            cbType.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(521, 467);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 11;
            label6.Text = "Kat";
            // 
            // dgCarPark
            // 
            dgCarPark.AllowUserToAddRows = false;
            dgCarPark.AllowUserToDeleteRows = false;
            dgCarPark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCarPark.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgCarPark.Location = new Point(305, 12);
            dgCarPark.Name = "dgCarPark";
            dgCarPark.ReadOnly = true;
            dgCarPark.RowHeadersWidth = 51;
            dgCarPark.RowTemplate.Height = 29;
            dgCarPark.Size = new Size(536, 314);
            dgCarPark.TabIndex = 12;
            dgCarPark.CellDoubleClick += dgCarPark_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Giriş Tarihi";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Araç Sayısı";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Daire No";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Blok ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Plaka No";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Visible = false;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Kat";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Visible = false;
            Column6.Width = 125;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(441, 527);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 13;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(591, 527);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(524, 566);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(591, 343);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(250, 27);
            dtDate.TabIndex = 16;
            // 
            // FrmCarPark
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1202, 660);
            Controls.Add(dtDate);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dgCarPark);
            Controls.Add(label6);
            Controls.Add(cbType);
            Controls.Add(cbBlocksId);
            Controls.Add(label5);
            Controls.Add(txtSuitNo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "FrmCarPark";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCarPark";
            WindowState = FormWindowState.Maximized;
            Load += FrmCarPark_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgCarPark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtAmount;
        private Label label3;
        private Label label4;
        private TextBox txtSuitNo;
        private Label label5;
        private ComboBox cbBlocksId;
        private ComboBox cbType;
        private Label label6;
        private DataGridView dgCarPark;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DateTimePicker dtDate;
    }
}
