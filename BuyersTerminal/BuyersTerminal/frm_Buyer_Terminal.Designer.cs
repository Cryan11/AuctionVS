namespace BuyersTerminal
{
    partial class frm_Buyer_Terminal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Buyer_Number = new System.Windows.Forms.TextBox();
            this.txt_Cut_Number = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.cmd_Clear = new System.Windows.Forms.Button();
            this.chk_Summary_Only = new System.Windows.Forms.CheckBox();
            this.cmd_Print_WC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "View/Print Working Copies of Invoices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buyer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // txt_Buyer_Number
            // 
            this.txt_Buyer_Number.Location = new System.Drawing.Point(282, 126);
            this.txt_Buyer_Number.Name = "txt_Buyer_Number";
            this.txt_Buyer_Number.Size = new System.Drawing.Size(131, 22);
            this.txt_Buyer_Number.TabIndex = 4;
            // 
            // txt_Cut_Number
            // 
            this.txt_Cut_Number.Location = new System.Drawing.Point(282, 168);
            this.txt_Cut_Number.Name = "txt_Cut_Number";
            this.txt_Cut_Number.Size = new System.Drawing.Size(131, 22);
            this.txt_Cut_Number.TabIndex = 5;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(282, 220);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(131, 22);
            this.txt_Password.TabIndex = 6;
            // 
            // cmd_Clear
            // 
            this.cmd_Clear.Location = new System.Drawing.Point(323, 291);
            this.cmd_Clear.Name = "cmd_Clear";
            this.cmd_Clear.Size = new System.Drawing.Size(125, 61);
            this.cmd_Clear.TabIndex = 8;
            this.cmd_Clear.Text = "Clear";
            this.cmd_Clear.UseVisualStyleBackColor = true;
            this.cmd_Clear.Click += new System.EventHandler(this.cmd_Clear_Click);
            // 
            // chk_Summary_Only
            // 
            this.chk_Summary_Only.AutoSize = true;
            this.chk_Summary_Only.Location = new System.Drawing.Point(282, 256);
            this.chk_Summary_Only.Name = "chk_Summary_Only";
            this.chk_Summary_Only.Size = new System.Drawing.Size(122, 21);
            this.chk_Summary_Only.TabIndex = 9;
            this.chk_Summary_Only.Text = "Summary Only";
            this.chk_Summary_Only.UseVisualStyleBackColor = true;
            // 
            // cmd_Print_WC
            // 
            this.cmd_Print_WC.Location = new System.Drawing.Point(180, 291);
            this.cmd_Print_WC.Name = "cmd_Print_WC";
            this.cmd_Print_WC.Size = new System.Drawing.Size(125, 61);
            this.cmd_Print_WC.TabIndex = 10;
            this.cmd_Print_WC.Text = "View/Print Working Copy";
            this.cmd_Print_WC.UseVisualStyleBackColor = true;
            this.cmd_Print_WC.Click += new System.EventHandler(this.cmd_Print_WC_Click);
            // 
            // frm_Buyer_Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.cmd_Print_WC);
            this.Controls.Add(this.chk_Summary_Only);
            this.Controls.Add(this.cmd_Clear);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Cut_Number);
            this.Controls.Add(this.txt_Buyer_Number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Buyer_Terminal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Buyer_Number;
        private System.Windows.Forms.TextBox txt_Cut_Number;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button cmd_Clear;
        private System.Windows.Forms.CheckBox chk_Summary_Only;
        private System.Windows.Forms.Button cmd_Print_WC;
    }
}

