namespace JuegoGuerraCartas
{
    partial class WinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinForm));
            btnBarajear = new Button();
            btnRepartir = new Button();
            btnJugar = new Button();
            btnCalculaG = new Button();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblImgJ1 = new Label();
            lblImgJ2 = new Label();
            lblImgJ3 = new Label();
            lblCartaJ1 = new Label();
            lblCartaJ2 = new Label();
            lblCartaJ3 = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lblNumJ1 = new Label();
            lblNumJ2 = new Label();
            lblNumJ3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBarajear
            // 
            btnBarajear.ImageAlign = ContentAlignment.MiddleLeft;
            btnBarajear.Location = new Point(31, 325);
            btnBarajear.Name = "btnBarajear";
            btnBarajear.Size = new Size(91, 29);
            btnBarajear.TabIndex = 0;
            btnBarajear.Text = "BARAJEAR";
            btnBarajear.UseVisualStyleBackColor = true;
            btnBarajear.Click += btnBarajear_Click;
            // 
            // btnRepartir
            // 
            btnRepartir.Location = new Point(176, 325);
            btnRepartir.Name = "btnRepartir";
            btnRepartir.Size = new Size(91, 29);
            btnRepartir.TabIndex = 1;
            btnRepartir.Text = "REPARTIR";
            btnRepartir.UseVisualStyleBackColor = true;
            btnRepartir.Click += btnRepartir_Click;
            // 
            // btnJugar
            // 
            btnJugar.Location = new Point(331, 210);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(91, 29);
            btnJugar.TabIndex = 2;
            btnJugar.Text = "JUGAR";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // btnCalculaG
            // 
            btnCalculaG.Location = new Point(549, 210);
            btnCalculaG.Name = "btnCalculaG";
            btnCalculaG.Size = new Size(91, 49);
            btnCalculaG.TabIndex = 3;
            btnCalculaG.Text = "CALCULAR GANADOR";
            btnCalculaG.UseVisualStyleBackColor = true;
            btnCalculaG.Click += btnCalculaG_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 301);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reglas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 247);
            label5.Name = "label5";
            label5.Size = new Size(249, 60);
            label5.TabIndex = 4;
            label5.Text = "- Finalmente, puedes calcular el ganador en\r\n   cualquier momento utilizando el boton\r\n   \"Calcular Ganador\"(esto finalizara la partida)\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(0, 142);
            label4.Name = "label4";
            label4.Size = new Size(274, 105);
            label4.TabIndex = 3;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(2, 97);
            label3.Name = "label3";
            label3.Size = new Size(278, 45);
            label3.TabIndex = 2;
            label3.Text = "- Ahora puedes jugar haciendo click en el boton\r\n   \"Jugar\", el cual tomara una carta de cada jugador \r\n    y la comparara utilizando las siguientes reglas:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 49);
            label2.Name = "label2";
            label2.Size = new Size(267, 60);
            label2.TabIndex = 1;
            label2.Text = "- Luego debes utilizar el boton \"Repartir\" para dar\r\n   5 de las cartas previamente obtenidas a cada \r\n   jugador.\r\n\r\n";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(2, 19);
            label1.Name = "label1";
            label1.Size = new Size(265, 30);
            label1.TabIndex = 0;
            label1.Text = "- Primero debes usar el boton \"Barajear\" para \r\n   obtener 15 cartas de una baraja aleatoriamente.";
            // 
            // lblImgJ1
            // 
            lblImgJ1.AutoSize = true;
            lblImgJ1.Image = (Image)resources.GetObject("lblImgJ1.Image");
            lblImgJ1.Location = new Point(320, 34);
            lblImgJ1.Name = "lblImgJ1";
            lblImgJ1.Size = new Size(115, 120);
            lblImgJ1.TabIndex = 5;
            lblImgJ1.Text = "                                    \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // lblImgJ2
            // 
            lblImgJ2.AutoSize = true;
            lblImgJ2.Image = (Image)resources.GetObject("lblImgJ2.Image");
            lblImgJ2.Location = new Point(537, 34);
            lblImgJ2.Name = "lblImgJ2";
            lblImgJ2.Size = new Size(115, 120);
            lblImgJ2.TabIndex = 6;
            lblImgJ2.Text = "                                    \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // lblImgJ3
            // 
            lblImgJ3.AutoSize = true;
            lblImgJ3.Image = (Image)resources.GetObject("lblImgJ3.Image");
            lblImgJ3.Location = new Point(428, 170);
            lblImgJ3.Name = "lblImgJ3";
            lblImgJ3.Size = new Size(115, 120);
            lblImgJ3.TabIndex = 7;
            lblImgJ3.Text = "                                    \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // lblCartaJ1
            // 
            lblCartaJ1.AutoSize = true;
            lblCartaJ1.Image = (Image)resources.GetObject("lblCartaJ1.Image");
            lblCartaJ1.Location = new Point(320, 34);
            lblCartaJ1.Name = "lblCartaJ1";
            lblCartaJ1.Size = new Size(115, 120);
            lblCartaJ1.TabIndex = 8;
            lblCartaJ1.Text = "                                    \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            lblCartaJ1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblCartaJ2
            // 
            lblCartaJ2.AutoSize = true;
            lblCartaJ2.Image = (Image)resources.GetObject("lblCartaJ2.Image");
            lblCartaJ2.Location = new Point(536, 34);
            lblCartaJ2.Name = "lblCartaJ2";
            lblCartaJ2.Size = new Size(115, 120);
            lblCartaJ2.TabIndex = 9;
            lblCartaJ2.Text = "                                    \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // lblCartaJ3
            // 
            lblCartaJ3.AutoSize = true;
            lblCartaJ3.Image = (Image)resources.GetObject("lblCartaJ3.Image");
            lblCartaJ3.Location = new Point(428, 170);
            lblCartaJ3.Name = "lblCartaJ3";
            lblCartaJ3.Size = new Size(115, 120);
            lblCartaJ3.TabIndex = 10;
            lblCartaJ3.Text = "                                    \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(343, 9);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(79, 21);
            lbl1.TabIndex = 11;
            lbl1.Text = "Jugador 1";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.Location = new Point(549, 9);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(79, 21);
            lbl2.TabIndex = 12;
            lbl2.Text = "Jugador 2";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3.Location = new Point(446, 298);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(79, 21);
            lbl3.TabIndex = 13;
            lbl3.Text = "Jugador 3";
            // 
            // lblNumJ1
            // 
            lblNumJ1.AutoSize = true;
            lblNumJ1.BackColor = Color.White;
            lblNumJ1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumJ1.Location = new Point(352, 61);
            lblNumJ1.Name = "lblNumJ1";
            lblNumJ1.Size = new Size(46, 54);
            lblNumJ1.TabIndex = 14;
            lblNumJ1.Text = "1";
            // 
            // lblNumJ2
            // 
            lblNumJ2.AutoSize = true;
            lblNumJ2.BackColor = Color.White;
            lblNumJ2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumJ2.Location = new Point(565, 67);
            lblNumJ2.Name = "lblNumJ2";
            lblNumJ2.Size = new Size(46, 54);
            lblNumJ2.TabIndex = 15;
            lblNumJ2.Text = "1";
            // 
            // lblNumJ3
            // 
            lblNumJ3.AutoSize = true;
            lblNumJ3.BackColor = Color.White;
            lblNumJ3.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumJ3.Location = new Point(455, 205);
            lblNumJ3.Name = "lblNumJ3";
            lblNumJ3.Size = new Size(46, 54);
            lblNumJ3.TabIndex = 16;
            lblNumJ3.Text = "1";
            // 
            // WinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(663, 366);
            Controls.Add(lblNumJ3);
            Controls.Add(lblNumJ2);
            Controls.Add(lblNumJ1);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(lblCartaJ3);
            Controls.Add(lblCartaJ2);
            Controls.Add(lblCartaJ1);
            Controls.Add(lblImgJ3);
            Controls.Add(lblImgJ2);
            Controls.Add(lblImgJ1);
            Controls.Add(groupBox1);
            Controls.Add(btnCalculaG);
            Controls.Add(btnJugar);
            Controls.Add(btnRepartir);
            Controls.Add(btnBarajear);
            Name = "WinForm";
            Text = "WinForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBarajear;
        private Button btnRepartir;
        private Button btnJugar;
        private Button btnCalculaG;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblImgJ1;
        private Label lblImgJ2;
        private Label lblImgJ3;
        private Label lblCartaJ1;
        private Label lblCartaJ2;
        private Label lblCartaJ3;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lblNumJ1;
        private Label lblNumJ2;
        private Label lblNumJ3;
    }
}