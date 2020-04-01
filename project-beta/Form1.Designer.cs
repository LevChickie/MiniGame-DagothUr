namespace project_beta
{
    partial class project
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
            this.healthbar = new System.Windows.Forms.ProgressBar();
            this.manabar = new System.Windows.Forms.ProgressBar();
            this.health = new System.Windows.Forms.Label();
            this.mana = new System.Windows.Forms.Label();
            this.saveG = new System.Windows.Forms.Button();
            this.loadG = new System.Windows.Forms.Button();
            this.tutorial = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.background = new System.Windows.Forms.Panel();
            this.potion = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.character = new System.Windows.Forms.PictureBox();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.potion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).BeginInit();
            this.SuspendLayout();
            // 
            // healthbar
            // 
            this.healthbar.Location = new System.Drawing.Point(46, 934);
            this.healthbar.Name = "healthbar";
            this.healthbar.Size = new System.Drawing.Size(276, 23);
            this.healthbar.TabIndex = 0;
            // 
            // manabar
            // 
            this.manabar.Location = new System.Drawing.Point(343, 934);
            this.manabar.Name = "manabar";
            this.manabar.Size = new System.Drawing.Size(283, 23);
            this.manabar.TabIndex = 1;
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.Location = new System.Drawing.Point(54, 910);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(72, 17);
            this.health.TabIndex = 2;
            this.health.Text = "health bar";
            // 
            // mana
            // 
            this.mana.AutoSize = true;
            this.mana.Location = new System.Drawing.Point(340, 910);
            this.mana.Name = "mana";
            this.mana.Size = new System.Drawing.Size(68, 17);
            this.mana.TabIndex = 3;
            this.mana.Text = "mana bar";
            // 
            // saveG
            // 
            this.saveG.Location = new System.Drawing.Point(46, 22);
            this.saveG.Name = "saveG";
            this.saveG.Size = new System.Drawing.Size(75, 23);
            this.saveG.TabIndex = 5;
            this.saveG.Text = "button1";
            this.saveG.UseVisualStyleBackColor = true;
            // 
            // loadG
            // 
            this.loadG.Location = new System.Drawing.Point(141, 22);
            this.loadG.Name = "loadG";
            this.loadG.Size = new System.Drawing.Size(75, 23);
            this.loadG.TabIndex = 6;
            this.loadG.Text = "button1";
            this.loadG.UseVisualStyleBackColor = true;
            // 
            // tutorial
            // 
            this.tutorial.Location = new System.Drawing.Point(239, 22);
            this.tutorial.Name = "tutorial";
            this.tutorial.Size = new System.Drawing.Size(75, 23);
            this.tutorial.TabIndex = 7;
            this.tutorial.Text = "button1";
            this.tutorial.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.SystemColors.ControlDark;
            this.background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.background.Controls.Add(this.potion);
            this.background.Controls.Add(this.enemy1);
            this.background.Controls.Add(this.character);
            this.background.Location = new System.Drawing.Point(46, 57);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1213, 836);
            this.background.TabIndex = 4;
            this.background.Paint += new System.Windows.Forms.PaintEventHandler(this.background_Paint);
            this.background.MouseClick += new System.Windows.Forms.MouseEventHandler(this.background_MouseClick);
            // 
            // potion
            // 
            this.potion.BackColor = System.Drawing.Color.Transparent;
            this.potion.Image = global::project_beta.Properties.Resources.potion;
            this.potion.Location = new System.Drawing.Point(1018, 445);
            this.potion.Name = "potion";
            this.potion.Size = new System.Drawing.Size(100, 152);
            this.potion.TabIndex = 2;
            this.potion.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Image = global::project_beta.Properties.Resources.skeleton;
            this.enemy1.Location = new System.Drawing.Point(615, 175);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(249, 271);
            this.enemy1.TabIndex = 1;
            this.enemy1.TabStop = false;
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.Transparent;
            this.character.Cursor = System.Windows.Forms.Cursors.Default;
            this.character.Image = global::project_beta.Properties.Resources.DagothStep2;
            this.character.Location = new System.Drawing.Point(31, 373);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(280, 417);
            this.character.TabIndex = 0;
            this.character.TabStop = false;
            this.character.MouseClick += new System.Windows.Forms.MouseEventHandler(this.character_MouseClick);
            // 
            // project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1271, 1055);
            this.Controls.Add(this.tutorial);
            this.Controls.Add(this.loadG);
            this.Controls.Add(this.saveG);
            this.Controls.Add(this.background);
            this.Controls.Add(this.mana);
            this.Controls.Add(this.health);
            this.Controls.Add(this.manabar);
            this.Controls.Add(this.healthbar);
            this.KeyPreview = true;
            this.Name = "project";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.project_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.project_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.project_MouseClick);
            this.background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.potion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar healthbar;
        private System.Windows.Forms.ProgressBar manabar;
        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Label mana;
        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.PictureBox character;
        private System.Windows.Forms.Button saveG;
        private System.Windows.Forms.Button loadG;
        private System.Windows.Forms.Button tutorial;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox potion;
    }
}

