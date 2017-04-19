namespace WindowsFormsApplication1
{
    partial class Pager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pager));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRows = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPageCurrent = new System.Windows.Forms.TextBox();
            this.txtPageTotal = new System.Windows.Forms.TextBox();
            this.btnPageLast = new System.Windows.Forms.Button();
            this.btnPageNext = new System.Windows.Forms.Button();
            this.btnPageFirst = new System.Windows.Forms.Button();
            this.btnPagePrevious = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Filas:";
            // 
            // cmbRows
            // 
            this.cmbRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRows.FormattingEnabled = true;
            this.cmbRows.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "50",
            "100"});
            this.cmbRows.Location = new System.Drawing.Point(277, 3);
            this.cmbRows.Name = "cmbRows";
            this.cmbRows.Size = new System.Drawing.Size(45, 21);
            this.cmbRows.TabIndex = 16;
            this.cmbRows.SelectedIndexChanged += new System.EventHandler(this.cmbRows_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "de";
            // 
            // txtPageCurrent
            // 
            this.txtPageCurrent.BackColor = System.Drawing.Color.White;
            this.txtPageCurrent.Location = new System.Drawing.Point(75, 3);
            this.txtPageCurrent.MaxLength = 4;
            this.txtPageCurrent.Name = "txtPageCurrent";
            this.txtPageCurrent.Size = new System.Drawing.Size(32, 20);
            this.txtPageCurrent.TabIndex = 14;
            this.txtPageCurrent.Text = "1";
            this.txtPageCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPageCurrent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPageCurrent_KeyPress);
            this.txtPageCurrent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPageCurrent_KeyUp);
            // 
            // txtPageTotal
            // 
            this.txtPageTotal.BackColor = System.Drawing.Color.White;
            this.txtPageTotal.Location = new System.Drawing.Point(132, 3);
            this.txtPageTotal.Name = "txtPageTotal";
            this.txtPageTotal.ReadOnly = true;
            this.txtPageTotal.Size = new System.Drawing.Size(32, 20);
            this.txtPageTotal.TabIndex = 13;
            this.txtPageTotal.Text = "1";
            this.txtPageTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPageLast
            // 
            this.btnPageLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPageLast.Image = ((System.Drawing.Image)(resources.GetObject("btnPageLast.Image")));
            this.btnPageLast.Location = new System.Drawing.Point(205, 3);
            this.btnPageLast.Name = "btnPageLast";
            this.btnPageLast.Size = new System.Drawing.Size(29, 20);
            this.btnPageLast.TabIndex = 11;
            this.btnPageLast.UseVisualStyleBackColor = true;
            this.btnPageLast.Click += new System.EventHandler(this.btnPageLast_Click);
            // 
            // btnPageNext
            // 
            this.btnPageNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPageNext.Image = ((System.Drawing.Image)(resources.GetObject("btnPageNext.Image")));
            this.btnPageNext.Location = new System.Drawing.Point(170, 3);
            this.btnPageNext.Name = "btnPageNext";
            this.btnPageNext.Size = new System.Drawing.Size(29, 20);
            this.btnPageNext.TabIndex = 12;
            this.btnPageNext.UseVisualStyleBackColor = true;
            this.btnPageNext.Click += new System.EventHandler(this.btnPageNext_Click);
            // 
            // btnPageFirst
            // 
            this.btnPageFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPageFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnPageFirst.Image")));
            this.btnPageFirst.Location = new System.Drawing.Point(5, 3);
            this.btnPageFirst.Name = "btnPageFirst";
            this.btnPageFirst.Size = new System.Drawing.Size(29, 20);
            this.btnPageFirst.TabIndex = 10;
            this.btnPageFirst.UseVisualStyleBackColor = true;
            this.btnPageFirst.Click += new System.EventHandler(this.btnPageFirst_Click);
            // 
            // btnPagePrevious
            // 
            this.btnPagePrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagePrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPagePrevious.Image")));
            this.btnPagePrevious.Location = new System.Drawing.Point(40, 3);
            this.btnPagePrevious.Name = "btnPagePrevious";
            this.btnPagePrevious.Size = new System.Drawing.Size(29, 20);
            this.btnPagePrevious.TabIndex = 9;
            this.btnPagePrevious.UseVisualStyleBackColor = true;
            this.btnPagePrevious.Click += new System.EventHandler(this.btnPagePrevious_Click);
            // 
            // Pager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPageCurrent);
            this.Controls.Add(this.txtPageTotal);
            this.Controls.Add(this.btnPageLast);
            this.Controls.Add(this.btnPageNext);
            this.Controls.Add(this.btnPageFirst);
            this.Controls.Add(this.btnPagePrevious);
            this.Name = "Pager";
            this.Size = new System.Drawing.Size(329, 28);
            this.Load += new System.EventHandler(this.Pager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPageCurrent;
        private System.Windows.Forms.TextBox txtPageTotal;
        private System.Windows.Forms.Button btnPageLast;
        private System.Windows.Forms.Button btnPageNext;
        private System.Windows.Forms.Button btnPageFirst;
        private System.Windows.Forms.Button btnPagePrevious;
    }
}
