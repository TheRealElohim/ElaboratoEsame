namespace AAS
{
    partial class Scope
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Distance = new System.Windows.Forms.TextBox();
            this.btn_Set = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_Shell = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ObjM = new System.Windows.Forms.TextBox();
            this.txt_Y = new System.Windows.Forms.TextBox();
            this.txt_X = new System.Windows.Forms.TextBox();
            this.btn_Shoot = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cScope = new AAS.CarthesianPlaneScope();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Friction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(657, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ang (Deg)";
            // 
            // txt_Distance
            // 
            this.txt_Distance.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Distance.Location = new System.Drawing.Point(661, 195);
            this.txt_Distance.Name = "txt_Distance";
            this.txt_Distance.Size = new System.Drawing.Size(179, 19);
            this.txt_Distance.TabIndex = 29;
            this.txt_Distance.Text = "12";
            // 
            // btn_Set
            // 
            this.btn_Set.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Set.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Set.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Set.Location = new System.Drawing.Point(659, 233);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(182, 40);
            this.btn_Set.TabIndex = 28;
            this.btn_Set.Text = "SET";
            this.btn_Set.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(342, -32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Coordinates";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(658, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "Muzzle Velocity";
            // 
            // cbb_Shell
            // 
            this.cbb_Shell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbb_Shell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Shell.FormattingEnabled = true;
            this.cbb_Shell.Items.AddRange(new object[] {
            "5 m/s",
            "10 m/s",
            "20 m/s",
            "50 m/s"});
            this.cbb_Shell.Location = new System.Drawing.Point(661, 421);
            this.cbb_Shell.Name = "cbb_Shell";
            this.cbb_Shell.Size = new System.Drawing.Size(180, 21);
            this.cbb_Shell.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "Object Mass (Kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(658, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "Y Axis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(658, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "X Axis";
            // 
            // txt_ObjM
            // 
            this.txt_ObjM.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ObjM.Location = new System.Drawing.Point(661, 380);
            this.txt_ObjM.Name = "txt_ObjM";
            this.txt_ObjM.Size = new System.Drawing.Size(180, 19);
            this.txt_ObjM.TabIndex = 20;
            this.txt_ObjM.Text = "4";
            // 
            // txt_Y
            // 
            this.txt_Y.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Y.Location = new System.Drawing.Point(661, 146);
            this.txt_Y.Name = "txt_Y";
            this.txt_Y.Size = new System.Drawing.Size(180, 19);
            this.txt_Y.TabIndex = 19;
            this.txt_Y.Text = "2";
            // 
            // txt_X
            // 
            this.txt_X.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_X.Location = new System.Drawing.Point(661, 91);
            this.txt_X.Name = "txt_X";
            this.txt_X.Size = new System.Drawing.Size(180, 19);
            this.txt_X.TabIndex = 18;
            this.txt_X.Text = "1";
            // 
            // btn_Shoot
            // 
            this.btn_Shoot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Shoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Shoot.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shoot.Location = new System.Drawing.Point(661, 463);
            this.btn_Shoot.Name = "btn_Shoot";
            this.btn_Shoot.Size = new System.Drawing.Size(180, 40);
            this.btn_Shoot.TabIndex = 17;
            this.btn_Shoot.Text = "SHOOT";
            this.btn_Shoot.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "Automatic Aiming System";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(687, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Coordinates";
            // 
            // cScope
            // 
            this.cScope.ColorAssi = System.Drawing.Color.Black;
            this.cScope.ColorExtra = System.Drawing.Color.LightGray;
            this.cScope.ColorLine = System.Drawing.Color.Red;
            this.cScope.ColorPoint = System.Drawing.Color.Red;
            this.cScope.K = 20;
            this.cScope.Location = new System.Drawing.Point(12, 61);
            this.cScope.MainColor = System.Drawing.Color.DarkBlue;
            this.cScope.Name = "cScope";
            this.cScope.Size = new System.Drawing.Size(526, 490);
            this.cScope.TabIndex = 33;
            this.cScope.Text = "carthesianPlaneScope1";
            this.cScope.XC = 263;
            this.cScope.YC = 245;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(658, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 12);
            this.label9.TabIndex = 35;
            this.label9.Text = "Friction";
            // 
            // txt_Friction
            // 
            this.txt_Friction.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Friction.Location = new System.Drawing.Point(661, 343);
            this.txt_Friction.Name = "txt_Friction";
            this.txt_Friction.Size = new System.Drawing.Size(180, 19);
            this.txt_Friction.TabIndex = 34;
            this.txt_Friction.Text = "1.01";
            // 
            // Scope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 561);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Friction);
            this.Controls.Add(this.cScope);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Distance);
            this.Controls.Add(this.btn_Set);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_Shell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ObjM);
            this.Controls.Add(this.txt_Y);
            this.Controls.Add(this.txt_X);
            this.Controls.Add(this.btn_Shoot);
            this.Name = "Scope";
            this.Text = "Scope";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Distance;
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_Shell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ObjM;
        private System.Windows.Forms.TextBox txt_Y;
        private System.Windows.Forms.TextBox txt_X;
        private System.Windows.Forms.Button btn_Shoot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private CarthesianPlaneScope cScope;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Friction;
    }
}

