namespace SocketApp3
{
    partial class FormEdit1
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
            this.txt0 = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt0
            // 
            this.txt0.Location = new System.Drawing.Point(11, 24);
            this.txt0.Name = "txt0";
            this.txt0.Size = new System.Drawing.Size(186, 20);
            this.txt0.TabIndex = 0;
            this.txt0.Text = "000.000.000.000.000.000.000.000";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(8, 8);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(148, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Вкажіть параметри датчика";
            // 
            // btnOk
            // 
            this.btnOk.Image = global::SocketApp3.res.Ok1;
            this.btnOk.Location = new System.Drawing.Point(203, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(40, 40);
            this.btnOk.TabIndex = 2;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::SocketApp3.res.Cancel1;
            this.btnCancel.Location = new System.Drawing.Point(249, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(40, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormEdit1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 53);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txt0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEdit1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагування";
            this.Load += new System.EventHandler(this.FormEdit1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt0;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}