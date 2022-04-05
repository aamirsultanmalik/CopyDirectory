
namespace CopyDirectory
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
            this.btnSource = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_source = new System.Windows.Forms.TextBox();
            this.txt_destination = new System.Windows.Forms.TextBox();
            this.btn_destination = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.current_copy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(384, 14);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(131, 23);
            this.btnSource.TabIndex = 0;
            this.btnSource.Text = "Browse Source";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // txt_source
            // 
            this.txt_source.Location = new System.Drawing.Point(12, 14);
            this.txt_source.Name = "txt_source";
            this.txt_source.ReadOnly = true;
            this.txt_source.Size = new System.Drawing.Size(349, 20);
            this.txt_source.TabIndex = 1;
            // 
            // txt_destination
            // 
            this.txt_destination.Location = new System.Drawing.Point(12, 67);
            this.txt_destination.Name = "txt_destination";
            this.txt_destination.ReadOnly = true;
            this.txt_destination.Size = new System.Drawing.Size(349, 20);
            this.txt_destination.TabIndex = 3;
            // 
            // btn_destination
            // 
            this.btn_destination.Location = new System.Drawing.Point(384, 67);
            this.btn_destination.Name = "btn_destination";
            this.btn_destination.Size = new System.Drawing.Size(131, 23);
            this.btn_destination.TabIndex = 2;
            this.btn_destination.Text = "Browse Destination";
            this.btn_destination.UseVisualStyleBackColor = true;
            this.btn_destination.Click += new System.EventHandler(this.btn_destination_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // current_copy
            // 
            this.current_copy.AutoSize = true;
            this.current_copy.Location = new System.Drawing.Point(235, 191);
            this.current_copy.Name = "current_copy";
            this.current_copy.Size = new System.Drawing.Size(10, 13);
            this.current_copy.TabIndex = 5;
            this.current_copy.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.current_copy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_destination);
            this.Controls.Add(this.btn_destination);
            this.Controls.Add(this.txt_source);
            this.Controls.Add(this.btnSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txt_source;
        private System.Windows.Forms.TextBox txt_destination;
        private System.Windows.Forms.Button btn_destination;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label current_copy;
    }
}

