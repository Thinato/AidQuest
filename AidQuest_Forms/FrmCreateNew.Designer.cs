
namespace AidQuest_Forms
{
    partial class FrmCreateNew
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
            this.listQuestions = new System.Windows.Forms.ListBox();
            this.txtQuestion = new System.Windows.Forms.RichTextBox();
            this.txtAnswerA = new System.Windows.Forms.TextBox();
            this.lblAnswerA = new System.Windows.Forms.Label();
            this.lblAnswerB = new System.Windows.Forms.Label();
            this.txtAnswerB = new System.Windows.Forms.TextBox();
            this.txtAnswerC = new System.Windows.Forms.TextBox();
            this.txtAnswerD = new System.Windows.Forms.TextBox();
            this.lblAnswerC = new System.Windows.Forms.Label();
            this.lblAnswerD = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEraseQuestion = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSaveCurrent = new System.Windows.Forms.Button();
            this.picDiff3 = new System.Windows.Forms.PictureBox();
            this.picDiff2 = new System.Windows.Forms.PictureBox();
            this.picDiff1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDiff3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiff2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiff1)).BeginInit();
            this.SuspendLayout();
            // 
            // listQuestions
            // 
            this.listQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listQuestions.ForeColor = System.Drawing.Color.White;
            this.listQuestions.FormattingEnabled = true;
            this.listQuestions.ItemHeight = 16;
            this.listQuestions.Location = new System.Drawing.Point(12, 44);
            this.listQuestions.Name = "listQuestions";
            this.listQuestions.Size = new System.Drawing.Size(180, 352);
            this.listQuestions.TabIndex = 0;
            this.listQuestions.SelectedIndexChanged += new System.EventHandler(this.listQuestions_SelectedIndexChanged);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestion.ForeColor = System.Drawing.Color.White;
            this.txtQuestion.Location = new System.Drawing.Point(214, 42);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(374, 158);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.Text = "";
            // 
            // txtAnswerA
            // 
            this.txtAnswerA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnswerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.txtAnswerA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswerA.ForeColor = System.Drawing.Color.White;
            this.txtAnswerA.Location = new System.Drawing.Point(237, 210);
            this.txtAnswerA.Name = "txtAnswerA";
            this.txtAnswerA.Size = new System.Drawing.Size(351, 16);
            this.txtAnswerA.TabIndex = 1;
            // 
            // lblAnswerA
            // 
            this.lblAnswerA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerA.ForeColor = System.Drawing.Color.Gold;
            this.lblAnswerA.Location = new System.Drawing.Point(211, 210);
            this.lblAnswerA.Name = "lblAnswerA";
            this.lblAnswerA.Size = new System.Drawing.Size(20, 20);
            this.lblAnswerA.TabIndex = 3;
            this.lblAnswerA.Text = "A";
            // 
            // lblAnswerB
            // 
            this.lblAnswerB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerB.Location = new System.Drawing.Point(211, 235);
            this.lblAnswerB.Name = "lblAnswerB";
            this.lblAnswerB.Size = new System.Drawing.Size(20, 20);
            this.lblAnswerB.TabIndex = 3;
            this.lblAnswerB.Text = "B";
            // 
            // txtAnswerB
            // 
            this.txtAnswerB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnswerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAnswerB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswerB.ForeColor = System.Drawing.Color.White;
            this.txtAnswerB.Location = new System.Drawing.Point(237, 235);
            this.txtAnswerB.Name = "txtAnswerB";
            this.txtAnswerB.Size = new System.Drawing.Size(351, 16);
            this.txtAnswerB.TabIndex = 2;
            this.txtAnswerB.Text = "none";
            this.txtAnswerB.Enter += new System.EventHandler(this.txtAnswerB_Enter);
            this.txtAnswerB.Leave += new System.EventHandler(this.txtAnswerB_Leave);
            // 
            // txtAnswerC
            // 
            this.txtAnswerC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnswerC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAnswerC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswerC.ForeColor = System.Drawing.Color.White;
            this.txtAnswerC.Location = new System.Drawing.Point(237, 262);
            this.txtAnswerC.Name = "txtAnswerC";
            this.txtAnswerC.Size = new System.Drawing.Size(351, 16);
            this.txtAnswerC.TabIndex = 3;
            this.txtAnswerC.Text = "none";
            this.txtAnswerC.Enter += new System.EventHandler(this.txtAnswerC_Enter);
            this.txtAnswerC.Leave += new System.EventHandler(this.txtAnswerC_Leave);
            // 
            // txtAnswerD
            // 
            this.txtAnswerD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnswerD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtAnswerD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswerD.ForeColor = System.Drawing.Color.White;
            this.txtAnswerD.Location = new System.Drawing.Point(237, 289);
            this.txtAnswerD.Name = "txtAnswerD";
            this.txtAnswerD.Size = new System.Drawing.Size(351, 16);
            this.txtAnswerD.TabIndex = 4;
            this.txtAnswerD.Text = "none";
            this.txtAnswerD.Enter += new System.EventHandler(this.txtAnswerD_Enter);
            this.txtAnswerD.Leave += new System.EventHandler(this.txtAnswerD_Leave);
            // 
            // lblAnswerC
            // 
            this.lblAnswerC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerC.Location = new System.Drawing.Point(211, 262);
            this.lblAnswerC.Name = "lblAnswerC";
            this.lblAnswerC.Size = new System.Drawing.Size(20, 20);
            this.lblAnswerC.TabIndex = 3;
            this.lblAnswerC.Text = "C";
            // 
            // lblAnswerD
            // 
            this.lblAnswerD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswerD.Location = new System.Drawing.Point(211, 289);
            this.lblAnswerD.Name = "lblAnswerD";
            this.lblAnswerD.Size = new System.Drawing.Size(20, 20);
            this.lblAnswerD.TabIndex = 3;
            this.lblAnswerD.Text = "D";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pergunta:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(425, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Criar Nova";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // btnEraseQuestion
            // 
            this.btnEraseQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEraseQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnEraseQuestion.FlatAppearance.BorderSize = 0;
            this.btnEraseQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraseQuestion.Location = new System.Drawing.Point(12, 402);
            this.btnEraseQuestion.Name = "btnEraseQuestion";
            this.btnEraseQuestion.Size = new System.Drawing.Size(180, 27);
            this.btnEraseQuestion.TabIndex = 5;
            this.btnEraseQuestion.Text = "Apagar Selecionada";
            this.btnEraseQuestion.UseVisualStyleBackColor = false;
            this.btnEraseQuestion.Click += new System.EventHandler(this.btnEraseQuestion_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(295, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Resposta Correta:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCorrectAnswer
            // 
            this.cmbCorrectAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCorrectAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCorrectAnswer.FormattingEnabled = true;
            this.cmbCorrectAnswer.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbCorrectAnswer.Location = new System.Drawing.Point(512, 317);
            this.cmbCorrectAnswer.Name = "cmbCorrectAnswer";
            this.cmbCorrectAnswer.Size = new System.Drawing.Size(76, 24);
            this.cmbCorrectAnswer.TabIndex = 5;
            this.cmbCorrectAnswer.SelectedIndexChanged += new System.EventHandler(this.cmbCorrectAnswer_SelectedIndexChanged);
            // 
            // linkHelp
            // 
            this.linkHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkHelp.AutoSize = true;
            this.linkHelp.LinkColor = System.Drawing.Color.Aqua;
            this.linkHelp.Location = new System.Drawing.Point(237, 312);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(44, 17);
            this.linkHelp.TabIndex = 8;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "Ajuda";
            this.linkHelp.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::AidQuest_Forms.Properties.Resources.go_back_icon;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 27);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Voltar";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSaveCurrent
            // 
            this.btnSaveCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSaveCurrent.FlatAppearance.BorderSize = 0;
            this.btnSaveCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCurrent.Location = new System.Drawing.Point(214, 402);
            this.btnSaveCurrent.Name = "btnSaveCurrent";
            this.btnSaveCurrent.Size = new System.Drawing.Size(205, 25);
            this.btnSaveCurrent.TabIndex = 7;
            this.btnSaveCurrent.Text = "Salvar Pergunta Selecionada";
            this.btnSaveCurrent.UseVisualStyleBackColor = false;
            this.btnSaveCurrent.Click += new System.EventHandler(this.btnSaveCurrent_Click);
            // 
            // picDiff3
            // 
            this.picDiff3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDiff3.Image = global::AidQuest_Forms.Properties.Resources.star_unfilled;
            this.picDiff3.Location = new System.Drawing.Point(548, 347);
            this.picDiff3.Name = "picDiff3";
            this.picDiff3.Size = new System.Drawing.Size(40, 40);
            this.picDiff3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiff3.TabIndex = 10;
            this.picDiff3.TabStop = false;
            this.picDiff3.Click += new System.EventHandler(this.picDiff3_Click);
            // 
            // picDiff2
            // 
            this.picDiff2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDiff2.Image = global::AidQuest_Forms.Properties.Resources.star_unfilled;
            this.picDiff2.Location = new System.Drawing.Point(507, 347);
            this.picDiff2.Name = "picDiff2";
            this.picDiff2.Size = new System.Drawing.Size(40, 40);
            this.picDiff2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiff2.TabIndex = 10;
            this.picDiff2.TabStop = false;
            this.picDiff2.Click += new System.EventHandler(this.picDiff2_Click);
            // 
            // picDiff1
            // 
            this.picDiff1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDiff1.Image = global::AidQuest_Forms.Properties.Resources.star_filled;
            this.picDiff1.Location = new System.Drawing.Point(466, 347);
            this.picDiff1.Name = "picDiff1";
            this.picDiff1.Size = new System.Drawing.Size(40, 40);
            this.picDiff1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiff1.TabIndex = 10;
            this.picDiff1.TabStop = false;
            this.picDiff1.Click += new System.EventHandler(this.picDiff1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(310, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dificuldade:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmCreateNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(608, 439);
            this.Controls.Add(this.picDiff1);
            this.Controls.Add(this.picDiff2);
            this.Controls.Add(this.picDiff3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.linkHelp);
            this.Controls.Add(this.cmbCorrectAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEraseQuestion);
            this.Controls.Add(this.btnSaveCurrent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAnswerD);
            this.Controls.Add(this.lblAnswerC);
            this.Controls.Add(this.lblAnswerB);
            this.Controls.Add(this.txtAnswerD);
            this.Controls.Add(this.lblAnswerA);
            this.Controls.Add(this.txtAnswerC);
            this.Controls.Add(this.txtAnswerB);
            this.Controls.Add(this.txtAnswerA);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.listQuestions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCreateNew";
            this.Text = "FrmCreateNew";
            ((System.ComponentModel.ISupportInitialize)(this.picDiff3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiff2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiff1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listQuestions;
        private System.Windows.Forms.RichTextBox txtQuestion;
        private System.Windows.Forms.TextBox txtAnswerA;
        private System.Windows.Forms.Label lblAnswerA;
        private System.Windows.Forms.Label lblAnswerB;
        private System.Windows.Forms.TextBox txtAnswerB;
        private System.Windows.Forms.TextBox txtAnswerC;
        private System.Windows.Forms.TextBox txtAnswerD;
        private System.Windows.Forms.Label lblAnswerC;
        private System.Windows.Forms.Label lblAnswerD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEraseQuestion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCorrectAnswer;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSaveCurrent;
        private System.Windows.Forms.PictureBox picDiff3;
        private System.Windows.Forms.PictureBox picDiff2;
        private System.Windows.Forms.PictureBox picDiff1;
        private System.Windows.Forms.Label label1;
    }
}