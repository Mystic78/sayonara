namespace WSR
{
    partial class zakazchikcs
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
            this.constructor = new System.Windows.Forms.Button();
            this.newOrder = new System.Windows.Forms.Button();
            this.listOrders = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsrDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.Text = "Меню заказчика";
            // 
            // back
            // 
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // constructor
            // 
            this.constructor.Location = new System.Drawing.Point(447, 160);
            this.constructor.Name = "constructor";
            this.constructor.Size = new System.Drawing.Size(242, 66);
            this.constructor.TabIndex = 8;
            this.constructor.Text = "Конструктор изделий";
            this.constructor.UseVisualStyleBackColor = true;
            this.constructor.Click += new System.EventHandler(this.constructor_Click);
            // 
            // newOrder
            // 
            this.newOrder.Location = new System.Drawing.Point(447, 232);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(242, 66);
            this.newOrder.TabIndex = 9;
            this.newOrder.Text = "Оформить заказ";
            this.newOrder.UseVisualStyleBackColor = true;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // listOrders
            // 
            this.listOrders.Location = new System.Drawing.Point(447, 304);
            this.listOrders.Name = "listOrders";
            this.listOrders.Size = new System.Drawing.Size(242, 66);
            this.listOrders.TabIndex = 10;
            this.listOrders.Text = "Список заказов";
            this.listOrders.UseVisualStyleBackColor = true;
            this.listOrders.Click += new System.EventHandler(this.listOrders_Click);
            // 
            // zakazchikcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1154, 536);
            this.Controls.Add(this.listOrders);
            this.Controls.Add(this.newOrder);
            this.Controls.Add(this.constructor);
            this.Name = "zakazchikcs";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.constructor, 0);
            this.Controls.SetChildIndex(this.newOrder, 0);
            this.Controls.SetChildIndex(this.listOrders, 0);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsrDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button constructor;
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.Button listOrders;
    }
}
