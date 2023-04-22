namespace Piwo2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Oblicz = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GenderB = new System.Windows.Forms.RadioButton();
            this.BeerB = new System.Windows.Forms.TextBox();
            this.WineB = new System.Windows.Forms.TextBox();
            this.VodkaB = new System.Windows.Forms.TextBox();
            this.BodyMassB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Oblicz
            // 
            this.Oblicz.Location = new System.Drawing.Point(600, 243);
            this.Oblicz.Name = "Oblicz";
            this.Oblicz.Size = new System.Drawing.Size(150, 50);
            this.Oblicz.TabIndex = 0;
            this.Oblicz.Text = "Oblicz\'";
            this.Oblicz.UseVisualStyleBackColor = true;
            this.Oblicz.Click += new System.EventHandler(this.Oblicz_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(338, 435);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(388, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Message";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(397, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Body Mass Kg";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(397, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Promile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(372, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Vodka 40% 30ml";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(372, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Wine 12% 100ml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(388, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Beer 5% 250ml";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(420, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Czy Kobieta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GenderB
            // 
            this.GenderB.AutoSize = true;
            this.GenderB.Location = new System.Drawing.Point(600, 18);
            this.GenderB.Name = "GenderB";
            this.GenderB.Size = new System.Drawing.Size(14, 13);
            this.GenderB.TabIndex = 17;
            this.GenderB.TabStop = true;
            this.GenderB.UseVisualStyleBackColor = true;
            this.GenderB.CheckedChanged += new System.EventHandler(this.GenderB_CheckedChanged);
            // 
            // BeerB
            // 
            this.BeerB.Location = new System.Drawing.Point(600, 57);
            this.BeerB.Name = "BeerB";
            this.BeerB.Size = new System.Drawing.Size(100, 20);
            this.BeerB.TabIndex = 18;
            this.BeerB.Validating += new System.ComponentModel.CancelEventHandler(this.Walidacja);
            // 
            // WineB
            // 
            this.WineB.Location = new System.Drawing.Point(600, 95);
            this.WineB.Name = "WineB";
            this.WineB.Size = new System.Drawing.Size(100, 20);
            this.WineB.TabIndex = 19;
            this.WineB.Validating += new System.ComponentModel.CancelEventHandler(this.Walidacja);
            // 
            // VodkaB
            // 
            this.VodkaB.Location = new System.Drawing.Point(600, 136);
            this.VodkaB.Name = "VodkaB";
            this.VodkaB.Size = new System.Drawing.Size(100, 20);
            this.VodkaB.TabIndex = 20;
            this.VodkaB.Validating += new System.ComponentModel.CancelEventHandler(this.Walidacja);
            // 
            // BodyMassB
            // 
            this.BodyMassB.Location = new System.Drawing.Point(600, 171);
            this.BodyMassB.Name = "BodyMassB";
            this.BodyMassB.Size = new System.Drawing.Size(100, 20);
            this.BodyMassB.TabIndex = 21;
            this.BodyMassB.Validating += new System.ComponentModel.CancelEventHandler(this.Walidacja);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BodyMassB);
            this.Controls.Add(this.VodkaB);
            this.Controls.Add(this.WineB);
            this.Controls.Add(this.BeerB);
            this.Controls.Add(this.GenderB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Oblicz);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Oblicz;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton GenderB;
        private System.Windows.Forms.TextBox BeerB;
        private System.Windows.Forms.TextBox WineB;
        private System.Windows.Forms.TextBox VodkaB;
        private System.Windows.Forms.TextBox BodyMassB;
    }
}