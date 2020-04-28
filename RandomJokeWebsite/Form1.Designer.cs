namespace RandomJokeWebsite
{
    partial class FrmFunnyJokes
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
            this.BtnRandJoke = new System.Windows.Forms.Button();
            this.CmbxCategories = new System.Windows.Forms.ComboBox();
            this.TxtJoke = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRandJoke
            // 
            this.BtnRandJoke.Location = new System.Drawing.Point(314, 178);
            this.BtnRandJoke.Name = "BtnRandJoke";
            this.BtnRandJoke.Size = new System.Drawing.Size(145, 59);
            this.BtnRandJoke.TabIndex = 0;
            this.BtnRandJoke.Text = "Random Joke";
            this.BtnRandJoke.UseVisualStyleBackColor = true;
            this.BtnRandJoke.Click += new System.EventHandler(this.BtnRandJoke_ClickAsync);
            // 
            // CmbxCategories
            // 
            this.CmbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbxCategories.FormattingEnabled = true;
            this.CmbxCategories.Location = new System.Drawing.Point(13, 13);
            this.CmbxCategories.Name = "CmbxCategories";
            this.CmbxCategories.Size = new System.Drawing.Size(121, 21);
            this.CmbxCategories.TabIndex = 1;
            // 
            // TxtJoke
            // 
            this.TxtJoke.AutoSize = true;
            this.TxtJoke.Location = new System.Drawing.Point(40, 348);
            this.TxtJoke.Name = "TxtJoke";
            this.TxtJoke.Size = new System.Drawing.Size(0, 13);
            this.TxtJoke.TabIndex = 2;
            // 
            // FrmFunnyJokes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtJoke);
            this.Controls.Add(this.CmbxCategories);
            this.Controls.Add(this.BtnRandJoke);
            this.Name = "FrmFunnyJokes";
            this.Text = "Funny Jokes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRandJoke;
        private System.Windows.Forms.ComboBox CmbxCategories;
        private System.Windows.Forms.Label TxtJoke;
    }
}

