namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btOne = new System.Windows.Forms.Button();
            this.txtTitleStartSeite = new System.Windows.Forms.Label();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btStartGame = new System.Windows.Forms.Button();
            this.gameNormalSpeed = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btOne
            // 
            this.btOne.BackColor = System.Drawing.Color.White;
            this.btOne.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btOne.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btOne.FlatAppearance.BorderSize = 0;
            this.btOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btOne.Location = new System.Drawing.Point(45, 360);
            this.btOne.Name = "btOne";
            this.btOne.Size = new System.Drawing.Size(75, 23);
            this.btOne.TabIndex = 0;
            this.btOne.UseVisualStyleBackColor = false;
            this.btOne.Click += new System.EventHandler(this.btOne_Click);
            // 
            // txtTitleStartSeite
            // 
            this.txtTitleStartSeite.AutoSize = true;
            this.txtTitleStartSeite.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleStartSeite.Location = new System.Drawing.Point(190, 43);
            this.txtTitleStartSeite.Name = "txtTitleStartSeite";
            this.txtTitleStartSeite.Size = new System.Drawing.Size(398, 37);
            this.txtTitleStartSeite.TabIndex = 1;
            this.txtTitleStartSeite.Text = "Hier Könnte ein Title sein";
            this.txtTitleStartSeite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTitleStartSeite.Click += new System.EventHandler(this.txtAusgabe_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(636, 372);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 3;
            this.btSubmit.Text = "OK";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btStartGame
            // 
            this.btStartGame.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStartGame.Location = new System.Drawing.Point(344, 153);
            this.btStartGame.Name = "btStartGame";
            this.btStartGame.Size = new System.Drawing.Size(87, 40);
            this.btStartGame.TabIndex = 4;
            this.btStartGame.Text = "Start";
            this.btStartGame.UseVisualStyleBackColor = true;
            this.btStartGame.Click += new System.EventHandler(this.btStartGame_Click);
            // 
            // gameNormalSpeed
            // 
            this.gameNormalSpeed.Enabled = true;
            this.gameNormalSpeed.Interval = 30;
            this.gameNormalSpeed.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btStartGame);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.txtTitleStartSeite);
            this.Controls.Add(this.btOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOne;
        private System.Windows.Forms.Label txtTitleStartSeite;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btStartGame;
        private System.Windows.Forms.Timer gameNormalSpeed;
    }
}

