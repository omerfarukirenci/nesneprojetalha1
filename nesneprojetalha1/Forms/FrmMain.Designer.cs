namespace nesneprojetalha1.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            panel1 = new Panel();
            lbTitle = new Label();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            btnBlock = new ToolStripButton();
            btnCarPark = new ToolStripButton();
            btnDoorman = new ToolStripButton();
            btnExit = new ToolStripButton();
            panel2 = new Panel();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(lbTitle);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 161);
            panel1.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(12, 125);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(71, 20);
            lbTitle.TabIndex = 2;
            lbTitle.Text = "Alt Başlık";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(594, 62);
            label1.TabIndex = 1;
            label1.Text = "Apartman Yönetim Sistemi";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnBlock, btnCarPark, btnDoorman, btnExit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(878, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnBlock
            // 
            btnBlock.Image = (Image)resources.GetObject("btnBlock.Image");
            btnBlock.ImageTransparentColor = Color.Magenta;
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new Size(79, 24);
            btnBlock.Text = "Bloklar";
            btnBlock.Click += btnBlock_Click;
            // 
            // btnCarPark
            // 
            btnCarPark.Image = (Image)resources.GetObject("btnCarPark.Image");
            btnCarPark.ImageTransparentColor = Color.Magenta;
            btnCarPark.Name = "btnCarPark";
            btnCarPark.Size = new Size(87, 24);
            btnCarPark.Text = "Otopark";
            btnCarPark.Click += btnCarPark_Click;
            // 
            // btnDoorman
            // 
            btnDoorman.Image = (Image)resources.GetObject("btnDoorman.Image");
            btnDoorman.ImageTransparentColor = Color.Magenta;
            btnDoorman.Name = "btnDoorman";
            btnDoorman.Size = new Size(74, 24);
            btnDoorman.Text = "Kapıcı";
            btnDoorman.Click += btnDoorman_Click;
            // 
            // btnExit
            // 
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(63, 24);
            btnExit.Text = "Çıkış";
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(878, 337);
            panel2.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 498);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMain";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ToolStrip toolStrip1;
        private ToolStripButton btnBlock;
        private ToolStripButton btnCarPark;
        private ToolStripButton btnDoorman;
        private ToolStripButton btnExit;
        private Label lbTitle;
        private Label label1;
    }
}