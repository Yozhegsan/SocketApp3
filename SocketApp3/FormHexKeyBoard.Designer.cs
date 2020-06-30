namespace SocketApp3
{
    partial class FormHexKeyBoard
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
            this.lblKeyboard = new System.Windows.Forms.Label();
            this.txtHEX = new System.Windows.Forms.TextBox();
            this.btnBS = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKeyboard
            // 
            this.lblKeyboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblKeyboard.Location = new System.Drawing.Point(10, 64);
            this.lblKeyboard.Name = "lblKeyboard";
            this.lblKeyboard.Size = new System.Drawing.Size(480, 480);
            this.lblKeyboard.TabIndex = 0;
            this.lblKeyboard.Text = "HEX keyboard";
            this.lblKeyboard.Visible = false;
            // 
            // txtHEX
            // 
            this.txtHEX.Location = new System.Drawing.Point(12, 23);
            this.txtHEX.Name = "txtHEX";
            this.txtHEX.Size = new System.Drawing.Size(340, 20);
            this.txtHEX.TabIndex = 2;
            // 
            // btnBS
            // 
            this.btnBS.Image = global::SocketApp3.res.BackSpace_1;
            this.btnBS.Location = new System.Drawing.Point(358, 12);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(40, 40);
            this.btnBS.TabIndex = 1;
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // btnOk
            // 
            this.btnOk.Image = global::SocketApp3.res.Ok1;
            this.btnOk.Location = new System.Drawing.Point(404, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(40, 40);
            this.btnOk.TabIndex = 1;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::SocketApp3.res.Cancel1;
            this.btnCancel.Location = new System.Drawing.Point(450, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(40, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormHexKeyBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 555);
            this.Controls.Add(this.txtHEX);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblKeyboard);
            this.Name = "FormHexKeyBoard";
            this.Text = "HEX клавіатура";
            this.Load += new System.EventHandler(this.FormHexKeyBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeyboard;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtHEX;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnBS;
    }
}