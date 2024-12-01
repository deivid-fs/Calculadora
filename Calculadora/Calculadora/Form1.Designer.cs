namespace Calculadora
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnN8 = new Button();
            btnN7 = new Button();
            btnClear = new Button();
            btnCalc = new Button();
            btnN4 = new Button();
            btnDiv = new Button();
            btnN9 = new Button();
            btnN5 = new Button();
            btnN6 = new Button();
            btnMult = new Button();
            btnSub = new Button();
            btnAdic = new Button();
            btnN3 = new Button();
            btnN2 = new Button();
            btnN1 = new Button();
            btnN0 = new Button();
            lblRes = new Label();
            btnPorcentagem = new Button();
            btnQuadrado = new Button();
            btnVirgula = new Button();
            SuspendLayout();
            // 
            // btnN8
            // 
            btnN8.BackColor = SystemColors.ControlLight;
            btnN8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnN8.Location = new Point(80, 180);
            btnN8.Name = "btnN8";
            btnN8.Size = new Size(75, 47);
            btnN8.TabIndex = 9;
            btnN8.Text = "8";
            btnN8.UseVisualStyleBackColor = false;
            // 
            // btnN7
            // 
            btnN7.BackColor = SystemColors.ControlLight;
            btnN7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnN7.Location = new Point(2, 180);
            btnN7.Name = "btnN7";
            btnN7.Size = new Size(75, 47);
            btnN7.TabIndex = 10;
            btnN7.Text = "7";
            btnN7.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveBorder;
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(161, 339);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 47);
            btnClear.TabIndex = 12;
            btnClear.Text = "&C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCalc
            // 
            btnCalc.BackColor = Color.RoyalBlue;
            btnCalc.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalc.ForeColor = SystemColors.ActiveCaptionText;
            btnCalc.ImageAlign = ContentAlignment.BottomCenter;
            btnCalc.Location = new Point(242, 339);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(77, 47);
            btnCalc.TabIndex = 11;
            btnCalc.Text = "&=";
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnN4
            // 
            btnN4.BackColor = SystemColors.ControlLight;
            btnN4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnN4.Location = new Point(2, 233);
            btnN4.Name = "btnN4";
            btnN4.Size = new Size(75, 47);
            btnN4.TabIndex = 14;
            btnN4.Text = "4";
            btnN4.UseVisualStyleBackColor = false;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.ActiveCaption;
            btnDiv.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(242, 127);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 47);
            btnDiv.TabIndex = 13;
            btnDiv.Text = "&/";
            btnDiv.UseVisualStyleBackColor = false;
            // 
            // btnN9
            // 
            btnN9.BackColor = SystemColors.ControlLight;
            btnN9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnN9.Location = new Point(164, 180);
            btnN9.Name = "btnN9";
            btnN9.Size = new Size(75, 47);
            btnN9.TabIndex = 15;
            btnN9.Text = "9";
            btnN9.UseVisualStyleBackColor = false;
            // 
            // btnN5
            // 
            btnN5.BackColor = SystemColors.ControlLight;
            btnN5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnN5.Location = new Point(83, 233);
            btnN5.Name = "btnN5";
            btnN5.Size = new Size(75, 47);
            btnN5.TabIndex = 17;
            btnN5.Text = "5";
            btnN5.UseVisualStyleBackColor = false;
            // 
            // btnN6
            // 
            btnN6.BackColor = SystemColors.ControlLight;
            btnN6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnN6.Location = new Point(164, 233);
            btnN6.Name = "btnN6";
            btnN6.Size = new Size(75, 47);
            btnN6.TabIndex = 19;
            btnN6.Text = "6";
            btnN6.UseVisualStyleBackColor = false;
            // 
            // btnMult
            // 
            btnMult.BackColor = SystemColors.ActiveCaption;
            btnMult.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMult.Location = new Point(242, 180);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(75, 47);
            btnMult.TabIndex = 18;
            btnMult.Text = "&X";
            btnMult.UseVisualStyleBackColor = false;
            // 
            // btnSub
            // 
            btnSub.BackColor = SystemColors.ActiveCaption;
            btnSub.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSub.Location = new Point(242, 233);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 47);
            btnSub.TabIndex = 23;
            btnSub.Text = "&-";
            btnSub.UseVisualStyleBackColor = false;
            // 
            // btnAdic
            // 
            btnAdic.BackColor = SystemColors.ActiveCaption;
            btnAdic.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdic.Location = new Point(242, 286);
            btnAdic.Name = "btnAdic";
            btnAdic.Size = new Size(75, 47);
            btnAdic.TabIndex = 22;
            btnAdic.Text = "&+";
            btnAdic.UseVisualStyleBackColor = false;
            // 
            // btnN3
            // 
            btnN3.BackColor = SystemColors.ControlLight;
            btnN3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnN3.Location = new Point(161, 286);
            btnN3.Name = "btnN3";
            btnN3.Size = new Size(75, 47);
            btnN3.TabIndex = 25;
            btnN3.Text = "3";
            btnN3.UseVisualStyleBackColor = false;
            // 
            // btnN2
            // 
            btnN2.BackColor = SystemColors.ControlLight;
            btnN2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnN2.Location = new Point(80, 286);
            btnN2.Name = "btnN2";
            btnN2.Size = new Size(75, 47);
            btnN2.TabIndex = 24;
            btnN2.Text = "2";
            btnN2.UseVisualStyleBackColor = false;
            // 
            // btnN1
            // 
            btnN1.BackColor = SystemColors.ControlLight;
            btnN1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnN1.Location = new Point(2, 286);
            btnN1.Name = "btnN1";
            btnN1.Size = new Size(75, 47);
            btnN1.TabIndex = 26;
            btnN1.Text = "1";
            btnN1.UseVisualStyleBackColor = false;
            // 
            // btnN0
            // 
            btnN0.BackColor = SystemColors.ControlLight;
            btnN0.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnN0.Location = new Point(2, 339);
            btnN0.Name = "btnN0";
            btnN0.Size = new Size(75, 47);
            btnN0.TabIndex = 27;
            btnN0.Text = "0";
            btnN0.UseVisualStyleBackColor = false;
            // 
            // lblRes
            // 
            lblRes.AutoSize = true;
            lblRes.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRes.Location = new Point(224, 61);
            lblRes.Margin = new Padding(3);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(0, 37);
            lblRes.TabIndex = 28;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.BackColor = SystemColors.ActiveCaption;
            btnPorcentagem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPorcentagem.Location = new Point(161, 127);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(75, 47);
            btnPorcentagem.TabIndex = 29;
            btnPorcentagem.Text = "&%";
            btnPorcentagem.UseVisualStyleBackColor = false;
            // 
            // btnQuadrado
            // 
            btnQuadrado.BackColor = SystemColors.ActiveCaption;
            btnQuadrado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuadrado.Location = new Point(80, 127);
            btnQuadrado.Name = "btnQuadrado";
            btnQuadrado.Size = new Size(75, 47);
            btnQuadrado.TabIndex = 30;
            btnQuadrado.Text = "&√x";
            btnQuadrado.UseVisualStyleBackColor = false;
            btnQuadrado.Click += btnRaizQuadrada_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = SystemColors.ControlLight;
            btnVirgula.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVirgula.Location = new Point(80, 339);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(75, 47);
            btnVirgula.TabIndex = 31;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 387);
            Controls.Add(btnVirgula);
            Controls.Add(btnQuadrado);
            Controls.Add(btnPorcentagem);
            Controls.Add(lblRes);
            Controls.Add(btnN0);
            Controls.Add(btnN1);
            Controls.Add(btnN3);
            Controls.Add(btnN2);
            Controls.Add(btnSub);
            Controls.Add(btnAdic);
            Controls.Add(btnN6);
            Controls.Add(btnMult);
            Controls.Add(btnN5);
            Controls.Add(btnN9);
            Controls.Add(btnN4);
            Controls.Add(btnDiv);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(btnN7);
            Controls.Add(btnN8);
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnN8;
        private Button btn7;
        private Button btnClear;
        private Button btnCalc;
        private Button btnN4;
        private Button btnDiv;
        private Button btnN9;
        private Button btnN6;
        private Button btn6;
        private Button btnMult;
        private Button btnSub;
        private Button btnAdic;
        private Button btnN3;
        private Button btnN2;
        private Button btnN1;
        private Button btnN0;
        private Button btnN5;
        private Button btnN7;
        private Label lblRes;
        private Button btnPorcentagem;
        private Button btnQuadrado;
        private Button btnVirgula;
    }
}
