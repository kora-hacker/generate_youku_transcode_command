namespace generate_youku_transcode_command
{
    partial class Form1
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
            this.ui_textbox_src = new System.Windows.Forms.TextBox();
            this.ui_button_select = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ui_textbox_des = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ui_msg_out = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "src";
            // 
            // ui_textbox_src
            // 
            this.ui_textbox_src.Location = new System.Drawing.Point(41, 6);
            this.ui_textbox_src.Name = "ui_textbox_src";
            this.ui_textbox_src.Size = new System.Drawing.Size(692, 21);
            this.ui_textbox_src.TabIndex = 1;
            // 
            // ui_button_select
            // 
            this.ui_button_select.Location = new System.Drawing.Point(739, 4);
            this.ui_button_select.Name = "ui_button_select";
            this.ui_button_select.Size = new System.Drawing.Size(75, 23);
            this.ui_button_select.TabIndex = 2;
            this.ui_button_select.Text = "选择";
            this.ui_button_select.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "des";
            // 
            // ui_textbox_des
            // 
            this.ui_textbox_des.Location = new System.Drawing.Point(41, 38);
            this.ui_textbox_des.Name = "ui_textbox_des";
            this.ui_textbox_des.Size = new System.Drawing.Size(692, 21);
            this.ui_textbox_des.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(739, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ui_msg_out
            // 
            this.ui_msg_out.Location = new System.Drawing.Point(14, 75);
            this.ui_msg_out.Multiline = true;
            this.ui_msg_out.Name = "ui_msg_out";
            this.ui_msg_out.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ui_msg_out.Size = new System.Drawing.Size(800, 451);
            this.ui_msg_out.TabIndex = 6;
            this.ui_msg_out.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 538);
            this.Controls.Add(this.ui_msg_out);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ui_textbox_des);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ui_button_select);
            this.Controls.Add(this.ui_textbox_src);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ui_textbox_src;
        private System.Windows.Forms.Button ui_button_select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ui_textbox_des;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ui_msg_out;
    }
}

