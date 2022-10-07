
namespace Tarea005
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.pnlBase = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNew = new System.Windows.Forms.Panel();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelQ = new System.Windows.Forms.Button();
            this.btnNewQ = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnlSignatures = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlSignatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.White;
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBase.Location = new System.Drawing.Point(200, 0);
            this.pnlBase.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(600, 450);
            this.pnlBase.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlSignatures);
            this.panel1.Controls.Add(this.pnlNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // pnlNew
            // 
            this.pnlNew.Controls.Add(this.dgvQuestions);
            this.pnlNew.Controls.Add(this.btnConfirm);
            this.pnlNew.Controls.Add(this.panel2);
            this.pnlNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNew.Location = new System.Drawing.Point(0, 0);
            this.pnlNew.Name = "pnlNew";
            this.pnlNew.Size = new System.Drawing.Size(200, 450);
            this.pnlNew.TabIndex = 5;
            this.pnlNew.Visible = false;
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.AllowUserToResizeColumns = false;
            this.dgvQuestions.AllowUserToResizeRows = false;
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestions.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.ColumnHeadersVisible = false;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number});
            this.dgvQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuestions.EnableHeadersVisualStyles = false;
            this.dgvQuestions.Location = new System.Drawing.Point(0, 42);
            this.dgvQuestions.Margin = new System.Windows.Forms.Padding(0);
            this.dgvQuestions.MultiSelect = false;
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.RowHeadersVisible = false;
            this.dgvQuestions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvQuestions.Size = new System.Drawing.Size(200, 366);
            this.dgvQuestions.TabIndex = 2;
            this.dgvQuestions.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestions_CellEnter);
            // 
            // number
            // 
            this.number.HeaderText = "Column1";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(0, 408);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(200, 42);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Crear";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelQ);
            this.panel2.Controls.Add(this.btnNewQ);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 42);
            this.panel2.TabIndex = 0;
            // 
            // btnDelQ
            // 
            this.btnDelQ.BackColor = System.Drawing.Color.Crimson;
            this.btnDelQ.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelQ.FlatAppearance.BorderSize = 0;
            this.btnDelQ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnDelQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnDelQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelQ.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelQ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelQ.Location = new System.Drawing.Point(135, 0);
            this.btnDelQ.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelQ.Name = "btnDelQ";
            this.btnDelQ.Size = new System.Drawing.Size(65, 42);
            this.btnDelQ.TabIndex = 5;
            this.btnDelQ.Text = "-";
            this.btnDelQ.UseVisualStyleBackColor = false;
            this.btnDelQ.Click += new System.EventHandler(this.btnDelQ_Click);
            // 
            // btnNewQ
            // 
            this.btnNewQ.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNewQ.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewQ.FlatAppearance.BorderSize = 0;
            this.btnNewQ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnNewQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnNewQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewQ.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewQ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewQ.Location = new System.Drawing.Point(65, 0);
            this.btnNewQ.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewQ.Name = "btnNewQ";
            this.btnNewQ.Size = new System.Drawing.Size(70, 42);
            this.btnNewQ.TabIndex = 4;
            this.btnNewQ.Text = "+";
            this.btnNewQ.UseVisualStyleBackColor = false;
            this.btnNewQ.Click += new System.EventHandler(this.btnNewQ_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 141);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(200, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Tomato;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(0, 413);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(200, 37);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "Nueva Asignatura";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pnlSignatures
            // 
            this.pnlSignatures.AutoSize = true;
            this.pnlSignatures.BackColor = System.Drawing.Color.White;
            this.pnlSignatures.Controls.Add(this.btnNew);
            this.pnlSignatures.Controls.Add(this.label1);
            this.pnlSignatures.Controls.Add(this.dataGridView1);
            this.pnlSignatures.Controls.Add(this.pictureBox1);
            this.pnlSignatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSignatures.Location = new System.Drawing.Point(0, 0);
            this.pnlSignatures.MaximumSize = new System.Drawing.Size(200, 0);
            this.pnlSignatures.Name = "pnlSignatures";
            this.pnlSignatures.Size = new System.Drawing.Size(200, 450);
            this.pnlSignatures.TabIndex = 8;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.panel1);
            this.Name = "BaseForm";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNew.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlSignatures.ResumeLayout(false);
            this.pnlSignatures.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNew;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelQ;
        private System.Windows.Forms.Button btnNewQ;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlSignatures;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}