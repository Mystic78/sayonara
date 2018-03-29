namespace WSR
{
    partial class Director
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
            this.listIzd = new System.Windows.Forms.Button();
            this.furnOst = new System.Windows.Forms.Button();
            this.tkanOst = new System.Windows.Forms.Button();
            this.moveMaterials = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsrDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.Text = "Меню руководителя";
            // 
            // back
            // 
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // listIzd
            // 
            this.listIzd.Location = new System.Drawing.Point(591, 166);
            this.listIzd.Name = "listIzd";
            this.listIzd.Size = new System.Drawing.Size(242, 66);
            this.listIzd.TabIndex = 7;
            this.listIzd.Text = "Список изделий";
            this.listIzd.UseVisualStyleBackColor = true;
            this.listIzd.Click += new System.EventHandler(this.listIzd_Click);
            // 
            // furnOst
            // 
            this.furnOst.Location = new System.Drawing.Point(343, 238);
            this.furnOst.Name = "furnOst";
            this.furnOst.Size = new System.Drawing.Size(242, 66);
            this.furnOst.TabIndex = 9;
            this.furnOst.Text = "Остаток фурнитуры на складе";
            this.furnOst.UseVisualStyleBackColor = true;
            this.furnOst.Click += new System.EventHandler(this.furnOst_Click);
            // 
            // tkanOst
            // 
            this.tkanOst.Location = new System.Drawing.Point(343, 166);
            this.tkanOst.Name = "tkanOst";
            this.tkanOst.Size = new System.Drawing.Size(242, 66);
            this.tkanOst.TabIndex = 8;
            this.tkanOst.Text = "Остаток тканей на складе";
            this.tkanOst.UseVisualStyleBackColor = true;
            this.tkanOst.Click += new System.EventHandler(this.tkanOst_Click);
            // 
            // moveMaterials
            // 
            this.moveMaterials.Location = new System.Drawing.Point(591, 238);
            this.moveMaterials.Name = "moveMaterials";
            this.moveMaterials.Size = new System.Drawing.Size(242, 66);
            this.moveMaterials.TabIndex = 10;
            this.moveMaterials.Text = "Движение материалов на складе";
            this.moveMaterials.UseVisualStyleBackColor = true;
            this.moveMaterials.Click += new System.EventHandler(this.moveMaterials_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 66);
            this.button1.TabIndex = 11;
            this.button1.Text = "Список заказов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Director
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1154, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moveMaterials);
            this.Controls.Add(this.furnOst);
            this.Controls.Add(this.tkanOst);
            this.Controls.Add(this.listIzd);
            this.Name = "Director";
            this.Load += new System.EventHandler(this.Director_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.listIzd, 0);
            this.Controls.SetChildIndex(this.tkanOst, 0);
            this.Controls.SetChildIndex(this.furnOst, 0);
            this.Controls.SetChildIndex(this.moveMaterials, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsrDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listIzd;
        private System.Windows.Forms.Button furnOst;
        private System.Windows.Forms.Button tkanOst;
        private System.Windows.Forms.Button moveMaterials;
        private System.Windows.Forms.Button button1;
    }
}
