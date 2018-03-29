namespace WSR
{
    partial class manager
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
            this.newOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsrDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.Text = "Меню менеджера";
            // 
            // back
            // 
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // listIzd
            // 
            this.listIzd.Location = new System.Drawing.Point(341, 153);
            this.listIzd.Name = "listIzd";
            this.listIzd.Size = new System.Drawing.Size(242, 66);
            this.listIzd.TabIndex = 6;
            this.listIzd.Text = "Список изделий";
            this.listIzd.UseVisualStyleBackColor = true;
            this.listIzd.Click += new System.EventHandler(this.listIzd_Click);
            // 
            // furnOst
            // 
            this.furnOst.Location = new System.Drawing.Point(589, 153);
            this.furnOst.Name = "furnOst";
            this.furnOst.Size = new System.Drawing.Size(242, 66);
            this.furnOst.TabIndex = 9;
            this.furnOst.Text = "Остаток фурнитуры на складе";
            this.furnOst.UseVisualStyleBackColor = true;
            this.furnOst.Click += new System.EventHandler(this.furnOst_Click);
            // 
            // tkanOst
            // 
            this.tkanOst.Location = new System.Drawing.Point(589, 225);
            this.tkanOst.Name = "tkanOst";
            this.tkanOst.Size = new System.Drawing.Size(242, 66);
            this.tkanOst.TabIndex = 8;
            this.tkanOst.Text = "Остаток тканей на складе";
            this.tkanOst.UseVisualStyleBackColor = true;
            this.tkanOst.Click += new System.EventHandler(this.tkanOst_Click);
            // 
            // newOrder
            // 
            this.newOrder.Location = new System.Drawing.Point(341, 225);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(242, 66);
            this.newOrder.TabIndex = 10;
            this.newOrder.Text = "Оформить заказ";
            this.newOrder.UseVisualStyleBackColor = true;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 66);
            this.button1.TabIndex = 11;
            this.button1.Text = "Список заказов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1154, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.furnOst);
            this.Controls.Add(this.tkanOst);
            this.Controls.Add(this.listIzd);
            this.Name = "manager";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.listIzd, 0);
            this.Controls.SetChildIndex(this.tkanOst, 0);
            this.Controls.SetChildIndex(this.furnOst, 0);
            this.Controls.SetChildIndex(this.newOrder, 0);
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
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.Button button1;
    }
}
