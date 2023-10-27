namespace SQLconnectCS
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.refesh_btn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.Khoa_txt = new System.Windows.Forms.TextBox();
            this.msv_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(750, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // refesh_btn
            // 
            this.refesh_btn.Location = new System.Drawing.Point(12, 12);
            this.refesh_btn.Name = "refesh_btn";
            this.refesh_btn.Size = new System.Drawing.Size(75, 23);
            this.refesh_btn.TabIndex = 13;
            this.refesh_btn.Click += new System.EventHandler(this.refesh_btn_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(144, 71);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 16);
            this.id.TabIndex = 2;
            this.id.Text = "id";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(144, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(443, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "MSV";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(267, 64);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 22);
            this.id_txt.TabIndex = 6;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(267, 127);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 22);
            this.name_txt.TabIndex = 7;
            // 
            // Khoa_txt
            // 
            this.Khoa_txt.Location = new System.Drawing.Point(538, 127);
            this.Khoa_txt.Name = "Khoa_txt";
            this.Khoa_txt.Size = new System.Drawing.Size(100, 22);
            this.Khoa_txt.TabIndex = 8;
            // 
            // msv_txt
            // 
            this.msv_txt.Location = new System.Drawing.Point(538, 64);
            this.msv_txt.Name = "msv_txt";
            this.msv_txt.Size = new System.Drawing.Size(100, 22);
            this.msv_txt.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 157);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 495);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.msv_txt);
            this.Controls.Add(this.Khoa_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.refesh_btn);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refesh_btn;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox Khoa_txt;
        private System.Windows.Forms.TextBox msv_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}