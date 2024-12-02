namespace JunproRama_492727
{
    partial class JunproHR
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
            this.lbl_karyawan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_departemen = new System.Windows.Forms.Label();
            this.cb_departemen = new System.Windows.Forms.ComboBox();
            this.tb_karyawan = new System.Windows.Forms.TextBox();
            this.gb_iddept = new System.Windows.Forms.GroupBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btn_load = new System.Windows.Forms.Button();
            this.lbl_idkaryawan = new System.Windows.Forms.Label();
            this.tb_idkaryawan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_karyawan
            // 
            this.lbl_karyawan.AutoSize = true;
            this.lbl_karyawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_karyawan.Location = new System.Drawing.Point(12, 115);
            this.lbl_karyawan.Name = "lbl_karyawan";
            this.lbl_karyawan.Size = new System.Drawing.Size(141, 20);
            this.lbl_karyawan.TabIndex = 0;
            this.lbl_karyawan.Text = "Nama Karyawan :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 66);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_departemen
            // 
            this.lbl_departemen.AutoSize = true;
            this.lbl_departemen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_departemen.Location = new System.Drawing.Point(12, 152);
            this.lbl_departemen.Name = "lbl_departemen";
            this.lbl_departemen.Size = new System.Drawing.Size(142, 20);
            this.lbl_departemen.TabIndex = 2;
            this.lbl_departemen.Text = "Dep. Karyawan   :";
            // 
            // cb_departemen
            // 
            this.cb_departemen.FormattingEnabled = true;
            this.cb_departemen.Items.AddRange(new object[] {
            "HR",
            "ENG",
            "DEV",
            "PM",
            "FIN"});
            this.cb_departemen.Location = new System.Drawing.Point(159, 151);
            this.cb_departemen.Name = "cb_departemen";
            this.cb_departemen.Size = new System.Drawing.Size(251, 21);
            this.cb_departemen.TabIndex = 3;
            // 
            // tb_karyawan
            // 
            this.tb_karyawan.Location = new System.Drawing.Point(159, 117);
            this.tb_karyawan.Name = "tb_karyawan";
            this.tb_karyawan.Size = new System.Drawing.Size(251, 20);
            this.tb_karyawan.TabIndex = 4;
            // 
            // gb_iddept
            // 
            this.gb_iddept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_iddept.Location = new System.Drawing.Point(435, 28);
            this.gb_iddept.Name = "gb_iddept";
            this.gb_iddept.Size = new System.Drawing.Size(353, 131);
            this.gb_iddept.TabIndex = 5;
            this.gb_iddept.TabStop = false;
            this.gb_iddept.Text = "ID Departemen";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(100, 38);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(97, 20);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "Aplikasi HR";
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(16, 175);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(124, 32);
            this.btn_insert.TabIndex = 7;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(338, 175);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(124, 32);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(664, 175);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(124, 32);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(16, 213);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(772, 187);
            this.dgvData.TabIndex = 10;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(664, 406);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(124, 32);
            this.btn_load.TabIndex = 11;
            this.btn_load.Text = "Load Data";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lbl_idkaryawan
            // 
            this.lbl_idkaryawan.AutoSize = true;
            this.lbl_idkaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idkaryawan.Location = new System.Drawing.Point(12, 81);
            this.lbl_idkaryawan.Name = "lbl_idkaryawan";
            this.lbl_idkaryawan.Size = new System.Drawing.Size(140, 20);
            this.lbl_idkaryawan.TabIndex = 12;
            this.lbl_idkaryawan.Text = "Id Karyawan       :";
            this.lbl_idkaryawan.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_idkaryawan
            // 
            this.tb_idkaryawan.Location = new System.Drawing.Point(159, 83);
            this.tb_idkaryawan.Name = "tb_idkaryawan";
            this.tb_idkaryawan.Size = new System.Drawing.Size(251, 20);
            this.tb_idkaryawan.TabIndex = 13;
            // 
            // JunproHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_idkaryawan);
            this.Controls.Add(this.lbl_idkaryawan);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.gb_iddept);
            this.Controls.Add(this.tb_karyawan);
            this.Controls.Add(this.cb_departemen);
            this.Controls.Add(this.lbl_departemen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_karyawan);
            this.Name = "JunproHR";
            this.Text = "Aplikasi HR";
            this.Load += new System.EventHandler(this.JunproHR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_karyawan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_departemen;
        private System.Windows.Forms.ComboBox cb_departemen;
        private System.Windows.Forms.TextBox tb_karyawan;
        private System.Windows.Forms.GroupBox gb_iddept;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label lbl_idkaryawan;
        private System.Windows.Forms.TextBox tb_idkaryawan;
    }
}

