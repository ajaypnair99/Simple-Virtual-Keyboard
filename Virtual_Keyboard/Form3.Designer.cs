namespace Virtual_Keyboard
{
    partial class Form3
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
            this.ctrlaltdelbutton = new System.Windows.Forms.Button();
            this.Copybutton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.Selectallbutton = new System.Windows.Forms.Button();
            this.WinTabbutton = new System.Windows.Forms.Button();
            this.alttabbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlaltdelbutton
            // 
            this.ctrlaltdelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlaltdelbutton.Location = new System.Drawing.Point(12, 12);
            this.ctrlaltdelbutton.Name = "ctrlaltdelbutton";
            this.ctrlaltdelbutton.Size = new System.Drawing.Size(152, 103);
            this.ctrlaltdelbutton.TabIndex = 0;
            this.ctrlaltdelbutton.Text = "Control Alt Delete";
            this.ctrlaltdelbutton.UseVisualStyleBackColor = true;
            this.ctrlaltdelbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Copybutton
            // 
            this.Copybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copybutton.Location = new System.Drawing.Point(12, 121);
            this.Copybutton.Name = "Copybutton";
            this.Copybutton.Size = new System.Drawing.Size(152, 103);
            this.Copybutton.TabIndex = 1;
            this.Copybutton.Text = "COPY";
            this.Copybutton.UseVisualStyleBackColor = true;
            this.Copybutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasteButton.Location = new System.Drawing.Point(12, 230);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(152, 103);
            this.PasteButton.TabIndex = 2;
            this.PasteButton.Text = "PASTE";
            this.PasteButton.UseVisualStyleBackColor = true;
            this.PasteButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Selectallbutton
            // 
            this.Selectallbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selectallbutton.Location = new System.Drawing.Point(12, 339);
            this.Selectallbutton.Name = "Selectallbutton";
            this.Selectallbutton.Size = new System.Drawing.Size(152, 103);
            this.Selectallbutton.TabIndex = 3;
            this.Selectallbutton.Text = "Select All";
            this.Selectallbutton.UseVisualStyleBackColor = true;
            // 
            // WinTabbutton
            // 
            this.WinTabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinTabbutton.Location = new System.Drawing.Point(170, 12);
            this.WinTabbutton.Name = "WinTabbutton";
            this.WinTabbutton.Size = new System.Drawing.Size(152, 103);
            this.WinTabbutton.TabIndex = 4;
            this.WinTabbutton.Text = "Win + Tab";
            this.WinTabbutton.UseVisualStyleBackColor = true;
            this.WinTabbutton.Click += new System.EventHandler(this.WinTabbutton_Click);
            // 
            // alttabbutton
            // 
            this.alttabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alttabbutton.Location = new System.Drawing.Point(170, 121);
            this.alttabbutton.Name = "alttabbutton";
            this.alttabbutton.Size = new System.Drawing.Size(152, 103);
            this.alttabbutton.TabIndex = 5;
            this.alttabbutton.Text = "Alt + Tab";
            this.alttabbutton.UseVisualStyleBackColor = true;
            this.alttabbutton.Click += new System.EventHandler(this.alttabbutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Virtual_Keyboard.Properties.Resources.Mountain_VK3;
            this.ClientSize = new System.Drawing.Size(329, 448);
            this.Controls.Add(this.alttabbutton);
            this.Controls.Add(this.WinTabbutton);
            this.Controls.Add(this.Selectallbutton);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.Copybutton);
            this.Controls.Add(this.ctrlaltdelbutton);
            this.Name = "Form3";
            this.Text = "Power User Pannel";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ctrlaltdelbutton;
        private System.Windows.Forms.Button Copybutton;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.Button Selectallbutton;
        private System.Windows.Forms.Button WinTabbutton;
        private System.Windows.Forms.Button alttabbutton;
    }
}