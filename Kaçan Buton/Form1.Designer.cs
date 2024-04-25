namespace Kaçan_Buton
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
            this.btnyok = new MaterialSkin.Controls.MaterialButton();
            this.btnevet = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnyok
            // 
            this.btnyok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnyok.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnyok.Depth = 0;
            this.btnyok.HighEmphasis = true;
            this.btnyok.Icon = null;
            this.btnyok.Location = new System.Drawing.Point(476, 344);
            this.btnyok.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnyok.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnyok.Name = "btnyok";
            this.btnyok.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnyok.Size = new System.Drawing.Size(97, 36);
            this.btnyok.TabIndex = 6;
            this.btnyok.Text = "Yookkkkk";
            this.btnyok.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnyok.UseAccentColor = false;
            this.btnyok.UseVisualStyleBackColor = true;
            this.btnyok.Click += new System.EventHandler(this.btnyok_Click);
            this.btnyok.MouseEnter += new System.EventHandler(this.btnyok_MouseEnter);
            this.btnyok.MouseHover += new System.EventHandler(this.btnyok_MouseHover);
            // 
            // btnevet
            // 
            this.btnevet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnevet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnevet.Depth = 0;
            this.btnevet.HighEmphasis = true;
            this.btnevet.Icon = null;
            this.btnevet.Location = new System.Drawing.Point(264, 344);
            this.btnevet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnevet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnevet.Name = "btnevet";
            this.btnevet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnevet.Size = new System.Drawing.Size(74, 36);
            this.btnevet.TabIndex = 5;
            this.btnevet.Text = "Evettt";
            this.btnevet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnevet.UseAccentColor = false;
            this.btnevet.UseVisualStyleBackColor = true;
            this.btnevet.Click += new System.EventHandler(this.btnevet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 650);
            this.Controls.Add(this.btnyok);
            this.Controls.Add(this.btnevet);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kaçma Buton!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnyok;
        private MaterialSkin.Controls.MaterialButton btnevet;
    }
}

