namespace WFCubeAttack
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbHealth = new System.Windows.Forms.Label();
            this.lbHealthContent = new System.Windows.Forms.Label();
            this.pMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lbHealth
            // 
            this.lbHealth.AutoSize = true;
            this.lbHealth.Location = new System.Drawing.Point(33, 549);
            this.lbHealth.Name = "lbHealth";
            this.lbHealth.Size = new System.Drawing.Size(89, 17);
            this.lbHealth.TabIndex = 2;
            this.lbHealth.Text = "Health = 200";
            // 
            // lbHealthContent
            // 
            this.lbHealthContent.AutoSize = true;
            this.lbHealthContent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbHealthContent.Location = new System.Drawing.Point(62, 576);
            this.lbHealthContent.Name = "lbHealthContent";
            this.lbHealthContent.Size = new System.Drawing.Size(0, 17);
            this.lbHealthContent.TabIndex = 3;
            // 
            // pMenu
            // 
            this.pMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pMenu.BackgroundImage")));
            this.pMenu.Controls.Add(this.button1);
            this.pMenu.Controls.Add(this.label1);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(1082, 613);
            this.pMenu.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Play!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cube Attack";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 613);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.lbHealthContent);
            this.Controls.Add(this.lbHealth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cube Attack";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_PaintPlayer);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PbPlayerKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PbPlayerKeyUp);
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbHealth;
        private System.Windows.Forms.Label lbHealthContent;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

