namespace AutoUpdate
{
    partial class Form1
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
            this.txt_rfid = new System.Windows.Forms.TextBox();
            this.txt_EmpName = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.brn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_EmpName = new System.Windows.Forms.Label();
            this.lbl_rfid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_rfid
            // 
            this.txt_rfid.Location = new System.Drawing.Point(74, 55);
            this.txt_rfid.Name = "txt_rfid";
            this.txt_rfid.Size = new System.Drawing.Size(100, 20);
            this.txt_rfid.TabIndex = 0;
            // 
            // txt_EmpName
            // 
            this.txt_EmpName.Location = new System.Drawing.Point(74, 29);
            this.txt_EmpName.Name = "txt_EmpName";
            this.txt_EmpName.Size = new System.Drawing.Size(100, 20);
            this.txt_EmpName.TabIndex = 1;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(74, 3);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 2;
            // 
            // brn_Insert
            // 
            this.brn_Insert.Location = new System.Drawing.Point(15, 81);
            this.brn_Insert.Name = "brn_Insert";
            this.brn_Insert.Size = new System.Drawing.Size(75, 23);
            this.brn_Insert.TabIndex = 3;
            this.brn_Insert.Text = "Insert";
            this.brn_Insert.UseVisualStyleBackColor = true;
            this.brn_Insert.Click += new System.EventHandler(this.brn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(96, 81);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(177, 81);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(50, 9);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 6;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_EmpName
            // 
            this.lbl_EmpName.AutoSize = true;
            this.lbl_EmpName.Location = new System.Drawing.Point(12, 29);
            this.lbl_EmpName.Name = "lbl_EmpName";
            this.lbl_EmpName.Size = new System.Drawing.Size(56, 13);
            this.lbl_EmpName.TabIndex = 7;
            this.lbl_EmpName.Text = "EmpName";
            // 
            // lbl_rfid
            // 
            this.lbl_rfid.AutoSize = true;
            this.lbl_rfid.Location = new System.Drawing.Point(47, 58);
            this.lbl_rfid.Name = "lbl_rfid";
            this.lbl_rfid.Size = new System.Drawing.Size(21, 13);
            this.lbl_rfid.TabIndex = 8;
            this.lbl_rfid.Text = "rfid";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(299, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "GridView Control";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(320, 171);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(75, 23);
            this.btn_Show.TabIndex = 11;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 333);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_rfid);
            this.Controls.Add(this.lbl_EmpName);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.brn_Insert);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_EmpName);
            this.Controls.Add(this.txt_rfid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_rfid;
        private System.Windows.Forms.TextBox txt_EmpName;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button brn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_EmpName;
        private System.Windows.Forms.Label lbl_rfid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Show;
    }
}

