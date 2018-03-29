namespace WSR
{
    partial class tmplt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tmplt));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wsrDataSet1 = new WSR.WSRDataSet();
            this.furniterITableAdapter1 = new WSR.WSRDataSetTableAdapters.FurniterITableAdapter();
            this.furnitureTableAdapter1 = new WSR.WSRDataSetTableAdapters.FurnitureTableAdapter();
            this.izdelieTableAdapter1 = new WSR.WSRDataSetTableAdapters.IzdelieTableAdapter();
            this.orderIzdelieTableAdapter1 = new WSR.WSRDataSetTableAdapters.OrderIzdelieTableAdapter();
            this.orderTableAdapter1 = new WSR.WSRDataSetTableAdapters.OrderTableAdapter();
            this.skladFurnitureTableAdapter1 = new WSR.WSRDataSetTableAdapters.SkladFurnitureTableAdapter();
            this.skladTkaniTableAdapter1 = new WSR.WSRDataSetTableAdapters.SkladTkaniTableAdapter();
            this.tkani2_TableAdapter1 = new WSR.WSRDataSetTableAdapters.tkani2_TableAdapter();
            this.tkaniIzdelieTableAdapter1 = new WSR.WSRDataSetTableAdapters.tkaniIzdelieTableAdapter();
            this.tkaniTableAdapter1 = new WSR.WSRDataSetTableAdapters.TkaniTableAdapter();
            this.userTableAdapter1 = new WSR.WSRDataSetTableAdapters.UserTableAdapter();
            this.back = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsrDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel2.Controls.Add(this.logout);
            this.panel2.Controls.Add(this.back);
            this.panel2.Location = new System.Drawing.Point(-2, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1158, 40);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 100);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Учет швейных изделий";
            // 
            // wsrDataSet1
            // 
            this.wsrDataSet1.DataSetName = "WSRDataSet";
            this.wsrDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // furniterITableAdapter1
            // 
            this.furniterITableAdapter1.ClearBeforeFill = true;
            // 
            // furnitureTableAdapter1
            // 
            this.furnitureTableAdapter1.ClearBeforeFill = true;
            // 
            // izdelieTableAdapter1
            // 
            this.izdelieTableAdapter1.ClearBeforeFill = true;
            // 
            // orderIzdelieTableAdapter1
            // 
            this.orderIzdelieTableAdapter1.ClearBeforeFill = true;
            // 
            // orderTableAdapter1
            // 
            this.orderTableAdapter1.ClearBeforeFill = true;
            // 
            // skladFurnitureTableAdapter1
            // 
            this.skladFurnitureTableAdapter1.ClearBeforeFill = true;
            // 
            // skladTkaniTableAdapter1
            // 
            this.skladTkaniTableAdapter1.ClearBeforeFill = true;
            // 
            // tkani2_TableAdapter1
            // 
            this.tkani2_TableAdapter1.ClearBeforeFill = true;
            // 
            // tkaniIzdelieTableAdapter1
            // 
            this.tkaniIzdelieTableAdapter1.ClearBeforeFill = true;
            // 
            // tkaniTableAdapter1
            // 
            this.tkaniTableAdapter1.ClearBeforeFill = true;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(14, 10);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 0;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(1069, 10);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 1;
            this.logout.Text = "Выход";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // tmplt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "tmplt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет швейных изделий";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tmplt_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsrDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        public WSRDataSet wsrDataSet1;
        public WSRDataSetTableAdapters.FurniterITableAdapter furniterITableAdapter1;
        public WSRDataSetTableAdapters.FurnitureTableAdapter furnitureTableAdapter1;
        public WSRDataSetTableAdapters.IzdelieTableAdapter izdelieTableAdapter1;
        public WSRDataSetTableAdapters.OrderIzdelieTableAdapter orderIzdelieTableAdapter1;
        public WSRDataSetTableAdapters.OrderTableAdapter orderTableAdapter1;
        public WSRDataSetTableAdapters.SkladFurnitureTableAdapter skladFurnitureTableAdapter1;
        public WSRDataSetTableAdapters.SkladTkaniTableAdapter skladTkaniTableAdapter1;
        public WSRDataSetTableAdapters.tkani2_TableAdapter tkani2_TableAdapter1;
        public WSRDataSetTableAdapters.tkaniIzdelieTableAdapter tkaniIzdelieTableAdapter1;
        public WSRDataSetTableAdapters.TkaniTableAdapter tkaniTableAdapter1;
        public WSRDataSetTableAdapters.UserTableAdapter userTableAdapter1;
        public System.Windows.Forms.Button logout;
        public System.Windows.Forms.Button back;
    }
}