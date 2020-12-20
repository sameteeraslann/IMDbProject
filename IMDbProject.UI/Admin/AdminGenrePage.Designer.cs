namespace IMDbProject.UI.Admin
{
    partial class AdminGenrePage
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
            this.grpAddGenre = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateFindbyId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdateGenreName = new System.Windows.Forms.TextBox();
            this.btnFindById = new System.Windows.Forms.Button();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpFindById = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFindByName = new System.Windows.Forms.TextBox();
            this.btnFindByName = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListofGenre = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpAddGenre.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.grpDelete.SuspendLayout();
            this.grpFindById.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddGenre
            // 
            this.grpAddGenre.Controls.Add(this.btnAdd);
            this.grpAddGenre.Controls.Add(this.txtGenreName);
            this.grpAddGenre.Controls.Add(this.label1);
            this.grpAddGenre.Location = new System.Drawing.Point(12, 12);
            this.grpAddGenre.Name = "grpAddGenre";
            this.grpAddGenre.Size = new System.Drawing.Size(282, 173);
            this.grpAddGenre.TabIndex = 0;
            this.grpAddGenre.TabStop = false;
            this.grpAddGenre.Text = "Add";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genre Name :";
            // 
            // txtGenreName
            // 
            this.txtGenreName.Location = new System.Drawing.Point(94, 32);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(150, 20);
            this.txtGenreName.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(169, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(130, 132);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Update";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.btnFindById);
            this.grpUpdate.Controls.Add(this.txtUpdateFindbyId);
            this.grpUpdate.Controls.Add(this.label4);
            this.grpUpdate.Controls.Add(this.label3);
            this.grpUpdate.Controls.Add(this.btnGuncelle);
            this.grpUpdate.Controls.Add(this.txtUpdateGenreName);
            this.grpUpdate.Location = new System.Drawing.Point(310, 12);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(227, 173);
            this.grpUpdate.TabIndex = 1;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Please Type Into Id Info :";
            // 
            // txtUpdateFindbyId
            // 
            this.txtUpdateFindbyId.Location = new System.Drawing.Point(21, 48);
            this.txtUpdateFindbyId.Name = "txtUpdateFindbyId";
            this.txtUpdateFindbyId.Size = new System.Drawing.Size(123, 20);
            this.txtUpdateFindbyId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Genre Name :";
            // 
            // txtUpdateGenreName
            // 
            this.txtUpdateGenreName.Location = new System.Drawing.Point(21, 106);
            this.txtUpdateGenreName.Name = "txtUpdateGenreName";
            this.txtUpdateGenreName.Size = new System.Drawing.Size(184, 20);
            this.txtUpdateGenreName.TabIndex = 1;
            // 
            // btnFindById
            // 
            this.btnFindById.Location = new System.Drawing.Point(150, 46);
            this.btnFindById.Name = "btnFindById";
            this.btnFindById.Size = new System.Drawing.Size(55, 23);
            this.btnFindById.TabIndex = 4;
            this.btnFindById.Text = "Find";
            this.btnFindById.UseVisualStyleBackColor = true;
            this.btnFindById.Click += new System.EventHandler(this.btnFindById_Click);
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.btnDelete);
            this.grpDelete.Controls.Add(this.txtDelete);
            this.grpDelete.Controls.Add(this.label2);
            this.grpDelete.Location = new System.Drawing.Point(544, 13);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(226, 95);
            this.grpDelete.TabIndex = 5;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please Type Into Id Info :";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(6, 45);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(123, 20);
            this.txtDelete.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(135, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpFindById
            // 
            this.grpFindById.Controls.Add(this.btnFindByName);
            this.grpFindById.Controls.Add(this.txtFindByName);
            this.grpFindById.Controls.Add(this.label5);
            this.grpFindById.Location = new System.Drawing.Point(544, 118);
            this.grpFindById.Name = "grpFindById";
            this.grpFindById.Size = new System.Drawing.Size(323, 67);
            this.grpFindById.TabIndex = 6;
            this.grpFindById.TabStop = false;
            this.grpFindById.Text = "Find By Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Genre Name :";
            // 
            // txtFindByName
            // 
            this.txtFindByName.Location = new System.Drawing.Point(11, 41);
            this.txtFindByName.Name = "txtFindByName";
            this.txtFindByName.Size = new System.Drawing.Size(150, 20);
            this.txtFindByName.TabIndex = 1;
            // 
            // btnFindByName
            // 
            this.btnFindByName.Location = new System.Drawing.Point(167, 39);
            this.btnFindByName.Name = "btnFindByName";
            this.btnFindByName.Size = new System.Drawing.Size(82, 23);
            this.btnFindByName.TabIndex = 2;
            this.btnFindByName.Text = "Find By Name";
            this.btnFindByName.UseVisualStyleBackColor = true;
            this.btnFindByName.Click += new System.EventHandler(this.btnFindByName_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListofGenre);
            this.groupBox1.Location = new System.Drawing.Point(776, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of All Genre";
            // 
            // btnListofGenre
            // 
            this.btnListofGenre.Location = new System.Drawing.Point(7, 18);
            this.btnListofGenre.Name = "btnListofGenre";
            this.btnListofGenre.Size = new System.Drawing.Size(75, 76);
            this.btnListofGenre.TabIndex = 0;
            this.btnListofGenre.Text = "List of All Genre";
            this.btnListofGenre.UseVisualStyleBackColor = true;
            this.btnListofGenre.Click += new System.EventHandler(this.btnListofGenre_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 236);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Of Categories";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(833, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // AdminGenrePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFindById);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.grpAddGenre);
            this.Name = "AdminGenrePage";
            this.Text = "AdminGenrePage";
            this.Load += new System.EventHandler(this.AdminGenrePage_Load);
            this.grpAddGenre.ResumeLayout(false);
            this.grpAddGenre.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.grpFindById.ResumeLayout(false);
            this.grpFindById.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddGenre;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Button btnFindById;
        private System.Windows.Forms.TextBox txtUpdateFindbyId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdateGenreName;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpFindById;
        private System.Windows.Forms.Button btnFindByName;
        private System.Windows.Forms.TextBox txtFindByName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListofGenre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}