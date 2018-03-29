namespace WSR
{
    partial class kladovschik
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
            this.listTkan = new System.Windows.Forms.Button();
            this.listFurn = new System.Windows.Forms.Button();
            this.tkanOst = new System.Windows.Forms.Button();
            this.furnOst = new System.Windows.Forms.Button();
            this.invent = new System.Windows.Forms.Button();
            this.addMaterials = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsrDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.Text = "Меню кладовщика";
            // 
            // back
            // 
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // listTkan
            // 
            this.listTkan.Location = new System.Drawing.Point(336, 157);
            this.listTkan.Name = "listTkan";
            this.listTkan.Size = new System.Drawing.Size(242, 66);
            this.listTkan.TabIndex = 4;
            this.listTkan.Text = "Список тканей";
            this.listTkan.UseVisualStyleBackColor = true;
            this.listTkan.Click += new System.EventHandler(this.listTkan_Click);
            // 
            // listFurn
            // 
            this.listFurn.Location = new System.Drawing.Point(336, 229);
            this.listFurn.Name = "listFurn";
            this.listFurn.Size = new System.Drawing.Size(242, 66);
            this.listFurn.TabIndex = 5;
            this.listFurn.Text = "Список фурнитуры";
            this.listFurn.UseVisualStyleBackColor = true;
            this.listFurn.Click += new System.EventHandler(this.listFurn_Click);
            // 
            // tkanOst
            // 
            this.tkanOst.Location = new System.Drawing.Point(584, 157);
            this.tkanOst.Name = "tkanOst";
            this.tkanOst.Size = new System.Drawing.Size(242, 66);
            this.tkanOst.TabIndex = 6;
            this.tkanOst.Text = "Остаток тканей на складе";
            this.tkanOst.UseVisualStyleBackColor = true;
            this.tkanOst.Click += new System.EventHandler(this.tkanOst_Click);
            // 
            // furnOst
            // 
            this.furnOst.Location = new System.Drawing.Point(584, 229);
            this.furnOst.Name = "furnOst";
            this.furnOst.Size = new System.Drawing.Size(242, 66);
            this.furnOst.TabIndex = 7;
            this.furnOst.Text = "Остаток фурнитуры на складе";
            this.furnOst.UseVisualStyleBackColor = true;
            this.furnOst.Click += new System.EventHandler(this.furnOst_Click);
            // 
            // invent
            // 
            this.invent.Location = new System.Drawing.Point(336, 301);
            this.invent.Name = "invent";
            this.invent.Size = new System.Drawing.Size(242, 66);
            this.invent.TabIndex = 8;
            this.invent.Text = "Инвентаризация";
            this.invent.UseVisualStyleBackColor = true;
            this.invent.Click += new System.EventHandler(this.invent_Click);
            // 
            // addMaterials
            // 
            this.addMaterials.Location = new System.Drawing.Point(584, 301);
            this.addMaterials.Name = "addMaterials";
            this.addMaterials.Size = new System.Drawing.Size(242, 66);
            this.addMaterials.TabIndex = 9;
            this.addMaterials.Text = "Поступление материалов";
            this.addMaterials.UseVisualStyleBackColor = true;
            // 
            // kladovschik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1154, 536);
            this.Controls.Add(this.addMaterials);
            this.Controls.Add(this.invent);
            this.Controls.Add(this.furnOst);
            this.Controls.Add(this.tkanOst);
            this.Controls.Add(this.listFurn);
            this.Controls.Add(this.listTkan);
            this.Name = "kladovschik";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.listTkan, 0);
            this.Controls.SetChildIndex(this.listFurn, 0);
            this.Controls.SetChildIndex(this.tkanOst, 0);
            this.Controls.SetChildIndex(this.furnOst, 0);
            this.Controls.SetChildIndex(this.invent, 0);
            this.Controls.SetChildIndex(this.addMaterials, 0);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsrDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listTkan;
        private System.Windows.Forms.Button listFurn;
        private System.Windows.Forms.Button tkanOst;
        private System.Windows.Forms.Button furnOst;
        private System.Windows.Forms.Button invent;
        private System.Windows.Forms.Button addMaterials;
    }
}
