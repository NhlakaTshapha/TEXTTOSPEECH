namespace TextToSpeech
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
            this.cmdSelectVoice = new System.Windows.Forms.ComboBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnresume = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.btnspeak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Voice";
            // 
            // cmdSelectVoice
            // 
            this.cmdSelectVoice.FormattingEnabled = true;
            this.cmdSelectVoice.Items.AddRange(new object[] {
            "NotSet",
            "Male",
            "Female",
            "Other"});
            this.cmdSelectVoice.Location = new System.Drawing.Point(150, 40);
            this.cmdSelectVoice.Name = "cmdSelectVoice";
            this.cmdSelectVoice.Size = new System.Drawing.Size(193, 21);
            this.cmdSelectVoice.TabIndex = 1;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(30, 99);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(704, 291);
            this.txtContent.TabIndex = 2;
            this.txtContent.Tag = "txtContent";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(659, 415);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnresume
            // 
            this.btnresume.Location = new System.Drawing.Point(562, 415);
            this.btnresume.Name = "btnresume";
            this.btnresume.Size = new System.Drawing.Size(75, 23);
            this.btnresume.TabIndex = 4;
            this.btnresume.Text = "Resume";
            this.btnresume.UseVisualStyleBackColor = true;
            this.btnresume.Click += new System.EventHandler(this.btnresume_Click);
            // 
            // btnpause
            // 
            this.btnpause.Location = new System.Drawing.Point(453, 415);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(75, 23);
            this.btnpause.TabIndex = 5;
            this.btnpause.Text = "Pause";
            this.btnpause.UseVisualStyleBackColor = true;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // btnspeak
            // 
            this.btnspeak.Location = new System.Drawing.Point(334, 415);
            this.btnspeak.Name = "btnspeak";
            this.btnspeak.Size = new System.Drawing.Size(75, 23);
            this.btnspeak.TabIndex = 6;
            this.btnspeak.Text = "Speak";
            this.btnspeak.UseVisualStyleBackColor = true;
            this.btnspeak.Click += new System.EventHandler(this.btnspeak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnspeak);
            this.Controls.Add(this.btnpause);
            this.Controls.Add(this.btnresume);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.cmdSelectVoice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdSelectVoice;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnresume;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.Button btnspeak;
    }
}

