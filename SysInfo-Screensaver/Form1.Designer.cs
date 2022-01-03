namespace SysInfo_Screensaver
{
    partial class mainForm
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
            this.CPUtextbox = new System.Windows.Forms.TextBox();
            this.CPUlabel = new System.Windows.Forms.Label();
            this.RAMlabel = new System.Windows.Forms.Label();
            this.RAMtextbox = new System.Windows.Forms.TextBox();
            this.HDDlabel = new System.Windows.Forms.Label();
            this.HDDtextbox = new System.Windows.Forms.TextBox();
            this.GPUlabel = new System.Windows.Forms.Label();
            this.GPUtextbox = new System.Windows.Forms.TextBox();
            this.getInfoButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CPUtextbox
            // 
            this.CPUtextbox.Location = new System.Drawing.Point(372, 37);
            this.CPUtextbox.Name = "CPUtextbox";
            this.CPUtextbox.Size = new System.Drawing.Size(200, 20);
            this.CPUtextbox.TabIndex = 0;
            // 
            // CPUlabel
            // 
            this.CPUlabel.AutoSize = true;
            this.CPUlabel.Location = new System.Drawing.Point(369, 21);
            this.CPUlabel.Name = "CPUlabel";
            this.CPUlabel.Size = new System.Drawing.Size(32, 13);
            this.CPUlabel.TabIndex = 1;
            this.CPUlabel.Text = "CPU:";
            this.CPUlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RAMlabel
            // 
            this.RAMlabel.AutoSize = true;
            this.RAMlabel.Location = new System.Drawing.Point(369, 67);
            this.RAMlabel.Name = "RAMlabel";
            this.RAMlabel.Size = new System.Drawing.Size(34, 13);
            this.RAMlabel.TabIndex = 2;
            this.RAMlabel.Text = "RAM:";
            this.RAMlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // RAMtextbox
            // 
            this.RAMtextbox.Location = new System.Drawing.Point(372, 84);
            this.RAMtextbox.Name = "RAMtextbox";
            this.RAMtextbox.Size = new System.Drawing.Size(200, 20);
            this.RAMtextbox.TabIndex = 3;
            // 
            // HDDlabel
            // 
            this.HDDlabel.AutoSize = true;
            this.HDDlabel.Location = new System.Drawing.Point(369, 113);
            this.HDDlabel.Name = "HDDlabel";
            this.HDDlabel.Size = new System.Drawing.Size(88, 13);
            this.HDDlabel.TabIndex = 4;
            this.HDDlabel.Text = "Almacenamiento:";
            this.HDDlabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // HDDtextbox
            // 
            this.HDDtextbox.Location = new System.Drawing.Point(372, 131);
            this.HDDtextbox.Name = "HDDtextbox";
            this.HDDtextbox.Size = new System.Drawing.Size(200, 20);
            this.HDDtextbox.TabIndex = 5;
            // 
            // GPUlabel
            // 
            this.GPUlabel.AutoSize = true;
            this.GPUlabel.Location = new System.Drawing.Point(369, 162);
            this.GPUlabel.Name = "GPUlabel";
            this.GPUlabel.Size = new System.Drawing.Size(33, 13);
            this.GPUlabel.TabIndex = 6;
            this.GPUlabel.Text = "GPU:";
            this.GPUlabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // GPUtextbox
            // 
            this.GPUtextbox.Location = new System.Drawing.Point(372, 179);
            this.GPUtextbox.Name = "GPUtextbox";
            this.GPUtextbox.Size = new System.Drawing.Size(200, 20);
            this.GPUtextbox.TabIndex = 7;
            // 
            // getInfoButton
            // 
            this.getInfoButton.Location = new System.Drawing.Point(372, 225);
            this.getInfoButton.Name = "getInfoButton";
            this.getInfoButton.Size = new System.Drawing.Size(75, 23);
            this.getInfoButton.TabIndex = 8;
            this.getInfoButton.Text = "Get Info";
            this.getInfoButton.UseVisualStyleBackColor = true;
            this.getInfoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(497, 225);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 267);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.getInfoButton);
            this.Controls.Add(this.GPUtextbox);
            this.Controls.Add(this.GPUlabel);
            this.Controls.Add(this.HDDtextbox);
            this.Controls.Add(this.HDDlabel);
            this.Controls.Add(this.RAMtextbox);
            this.Controls.Add(this.RAMlabel);
            this.Controls.Add(this.CPUlabel);
            this.Controls.Add(this.CPUtextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(606, 306);
            this.MinimumSize = new System.Drawing.Size(606, 306);
            this.Name = "mainForm";
            this.Text = "Editor de Informacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CPUtextbox;
        private System.Windows.Forms.Label CPUlabel;
        private System.Windows.Forms.Label RAMlabel;
        private System.Windows.Forms.TextBox RAMtextbox;
        private System.Windows.Forms.Label HDDlabel;
        private System.Windows.Forms.TextBox HDDtextbox;
        private System.Windows.Forms.Label GPUlabel;
        private System.Windows.Forms.TextBox GPUtextbox;
        private System.Windows.Forms.Button getInfoButton;
        private System.Windows.Forms.Button clearButton;
    }
}

