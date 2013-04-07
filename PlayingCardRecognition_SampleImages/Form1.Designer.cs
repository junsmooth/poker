namespace PlayingCardRecognition_SampleImages
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
            this.pb_loaded = new System.Windows.Forms.PictureBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCards = new System.Windows.Forms.TextBox();
            this.cardImagePanel = new PlayingCardRecognition.ImagePanel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loaded)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loaded Image";
            // 
            // pb_loaded
            // 
            this.pb_loaded.Location = new System.Drawing.Point(12, 25);
            this.pb_loaded.Name = "pb_loaded";
            this.pb_loaded.Size = new System.Drawing.Size(295, 254);
            this.pb_loaded.TabIndex = 3;
            this.pb_loaded.TabStop = false;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(232, 285);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 16;
            this.btn_Next.Text = "Next Image";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(12, 290);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(60, 13);
            this.lbl_FileName.TabIndex = 15;
            this.lbl_FileName.Text = "File Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Card Images";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cards";
            // 
            // txtCards
            // 
            this.txtCards.Location = new System.Drawing.Point(333, 183);
            this.txtCards.Multiline = true;
            this.txtCards.Name = "txtCards";
            this.txtCards.ReadOnly = true;
            this.txtCards.Size = new System.Drawing.Size(270, 96);
            this.txtCards.TabIndex = 21;
            // 
            // cardImagePanel
            // 
            this.cardImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardImagePanel.Gap = 90;
            this.cardImagePanel.Location = new System.Drawing.Point(333, 25);
            this.cardImagePanel.Name = "cardImagePanel";
            this.cardImagePanel.ResizeHeight = 120;
            this.cardImagePanel.ResizeWidth = 80;
            this.cardImagePanel.Size = new System.Drawing.Size(270, 130);
            this.cardImagePanel.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 319);
            this.Controls.Add(this.txtCards);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cardImagePanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.pb_loaded);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Playing Card Recognition System Demo -- Using Sample Images";
            ((System.ComponentModel.ISupportInitialize)(this.pb_loaded)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_loaded;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.Label label2;
        private PlayingCardRecognition.ImagePanel cardImagePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCards;
    }
}

