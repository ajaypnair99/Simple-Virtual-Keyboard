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
            this.Copybutton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.WinTabbutton = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.Selectallbutton = new System.Windows.Forms.Button();
            this.alttabbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Copybutton
            // 
            this.Copybutton.BackColor = System.Drawing.Color.Transparent;
            this.Copybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copybutton.Location = new System.Drawing.Point(12, 121);
            this.Copybutton.Name = "Copybutton";
            this.Copybutton.Size = new System.Drawing.Size(152, 103);
            this.Copybutton.TabIndex = 1;
            this.Copybutton.Text = "COPY";
            this.Copybutton.UseVisualStyleBackColor = false;
            this.Copybutton.Click += new System.EventHandler(this.Copy_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.BackColor = System.Drawing.Color.Transparent;
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasteButton.Location = new System.Drawing.Point(170, 121);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(152, 103);
            this.PasteButton.TabIndex = 2;
            this.PasteButton.Text = "PASTE";
            this.PasteButton.UseVisualStyleBackColor = false;
            this.PasteButton.Click += new System.EventHandler(this.Paste_Click);
            // 
            // WinTabbutton
            // 
            this.WinTabbutton.BackColor = System.Drawing.Color.Transparent;
            this.WinTabbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WinTabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinTabbutton.Location = new System.Drawing.Point(12, 12);
            this.WinTabbutton.Name = "WinTabbutton";
            this.WinTabbutton.Size = new System.Drawing.Size(152, 103);
            this.WinTabbutton.TabIndex = 4;
            this.WinTabbutton.Text = "Win + Tab";
            this.WinTabbutton.UseVisualStyleBackColor = false;
            this.WinTabbutton.Click += new System.EventHandler(this.WinTabbutton_Click);
            // 
            // undo
            // 
            this.undo.BackColor = System.Drawing.Color.Transparent;
            this.undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undo.Location = new System.Drawing.Point(12, 230);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(152, 103);
            this.undo.TabIndex = 6;
            this.undo.Text = "ctrl + z";
            this.undo.UseVisualStyleBackColor = false;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // Selectallbutton
            // 
            this.Selectallbutton.BackColor = System.Drawing.Color.Transparent;
            this.Selectallbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selectallbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selectallbutton.Location = new System.Drawing.Point(170, 230);
            this.Selectallbutton.Name = "Selectallbutton";
            this.Selectallbutton.Size = new System.Drawing.Size(152, 103);
            this.Selectallbutton.TabIndex = 3;
            this.Selectallbutton.Text = "Select All";
            this.Selectallbutton.UseVisualStyleBackColor = false;
            this.Selectallbutton.Click += new System.EventHandler(this.Selectallbutton_Click);
            // 
            // alttabbutton
            // 
            this.alttabbutton.BackColor = System.Drawing.Color.Transparent;
            this.alttabbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alttabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alttabbutton.Location = new System.Drawing.Point(170, 12);
            this.alttabbutton.Name = "alttabbutton";
            this.alttabbutton.Size = new System.Drawing.Size(152, 103);
            this.alttabbutton.TabIndex = 5;
            this.alttabbutton.Text = "Alt + Tab";
            this.alttabbutton.UseVisualStyleBackColor = false;
            this.alttabbutton.Click += new System.EventHandler(this.alttabbutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Virtual_Keyboard.Properties.Resources.Mountain_VK3;
            this.ClientSize = new System.Drawing.Size(329, 348);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.alttabbutton);
            this.Controls.Add(this.WinTabbutton);
            this.Controls.Add(this.Selectallbutton);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.Copybutton);
            this.Name = "Form3";
            this.Text = "Power User Pannel";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Copybutton;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.Button WinTabbutton;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Button Selectallbutton;
        private System.Windows.Forms.Button alttabbutton;
    }
}