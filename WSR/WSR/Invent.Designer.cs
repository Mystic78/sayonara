namespace WSR
{
    partial class Invent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invent));
            this.label2 = new System.Windows.Forms.Label();
            this.browse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.load = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsrDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.Text = "Инвентаризация";
            // 
            // back
            // 
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1108, 36);
            this.label2.TabIndex = 22;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(711, 173);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(75, 23);
            this.browse.TabIndex = 23;
            this.browse.Text = "Просмотр";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(459, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 24;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(459, 213);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 25;
            this.load.Text = "Загрузить";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Выбрать файл";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(619, 213);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 27;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(275, 277);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(596, 181);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "";
            // 
            // Invent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1154, 536);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.load);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.label2);
            this.Name = "Invent";
            this.Load += new System.EventHandler(this.Invent_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.browse, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.load, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cancel, 0);
            this.Controls.SetChildIndex(this.richTextBox1, 0);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsrDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
