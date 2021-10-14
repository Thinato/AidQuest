
namespace AidQuest_Forms
{
    partial class FrmGame
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
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastPoints = new System.Windows.Forms.Label();
            this.picDiff1 = new System.Windows.Forms.PictureBox();
            this.picDiff2 = new System.Windows.Forms.PictureBox();
            this.picDiff3 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pGameOver = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDiff1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiff2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiff3)).BeginInit();
            this.pGameOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPoints
            // 
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPoints.Location = new System.Drawing.Point(39, 9);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(211, 29);
            this.lblPoints.TabIndex = 0;
            this.lblPoints.Text = "Pontos:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQuestion.Location = new System.Drawing.Point(12, 38);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(488, 114);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Pergunta {0}";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAnswer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAnswer2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAnswer3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAnswer4, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 201);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 190);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnswer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAnswer1.FlatAppearance.BorderSize = 0;
            this.btnAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer1.Location = new System.Drawing.Point(3, 3);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(238, 89);
            this.btnAnswer1.TabIndex = 0;
            this.btnAnswer1.Text = "1";
            this.btnAnswer1.UseVisualStyleBackColor = false;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer1_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnswer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAnswer2.FlatAppearance.BorderSize = 0;
            this.btnAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer2.Location = new System.Drawing.Point(247, 3);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(238, 89);
            this.btnAnswer2.TabIndex = 0;
            this.btnAnswer2.Text = "2";
            this.btnAnswer2.UseVisualStyleBackColor = false;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer2_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnswer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAnswer3.FlatAppearance.BorderSize = 0;
            this.btnAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer3.Location = new System.Drawing.Point(3, 98);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(238, 89);
            this.btnAnswer3.TabIndex = 0;
            this.btnAnswer3.Text = "3";
            this.btnAnswer3.UseVisualStyleBackColor = false;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer3_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnswer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAnswer4.FlatAppearance.BorderSize = 0;
            this.btnAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer4.Location = new System.Drawing.Point(247, 98);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(238, 89);
            this.btnAnswer4.TabIndex = 0;
            this.btnAnswer4.Text = "4";
            this.btnAnswer4.UseVisualStyleBackColor = false;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer4_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTime.Location = new System.Drawing.Point(334, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(166, 29);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Tempo: 01:00.0";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(15, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dificuldade:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblLastPoints
            // 
            this.lblLastPoints.AutoSize = true;
            this.lblLastPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblLastPoints.Location = new System.Drawing.Point(256, 22);
            this.lblLastPoints.Name = "lblLastPoints";
            this.lblLastPoints.Size = new System.Drawing.Size(0, 16);
            this.lblLastPoints.TabIndex = 5;
            // 
            // picDiff1
            // 
            this.picDiff1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDiff1.Image = global::AidQuest_Forms.Properties.Resources.star_filled;
            this.picDiff1.Location = new System.Drawing.Point(375, 155);
            this.picDiff1.Name = "picDiff1";
            this.picDiff1.Size = new System.Drawing.Size(40, 40);
            this.picDiff1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiff1.TabIndex = 3;
            this.picDiff1.TabStop = false;
            // 
            // picDiff2
            // 
            this.picDiff2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDiff2.Image = global::AidQuest_Forms.Properties.Resources.star_unfilled;
            this.picDiff2.Location = new System.Drawing.Point(416, 155);
            this.picDiff2.Name = "picDiff2";
            this.picDiff2.Size = new System.Drawing.Size(40, 40);
            this.picDiff2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiff2.TabIndex = 3;
            this.picDiff2.TabStop = false;
            // 
            // picDiff3
            // 
            this.picDiff3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDiff3.Image = global::AidQuest_Forms.Properties.Resources.star_unfilled;
            this.picDiff3.Location = new System.Drawing.Point(457, 155);
            this.picDiff3.Name = "picDiff3";
            this.picDiff3.Size = new System.Drawing.Size(40, 40);
            this.picDiff3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDiff3.TabIndex = 3;
            this.picDiff3.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::AidQuest_Forms.Properties.Resources.go_back_icon;
            this.btnBack.Location = new System.Drawing.Point(3, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 26);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pGameOver
            // 
            this.pGameOver.Controls.Add(this.label2);
            this.pGameOver.Controls.Add(this.btnConfirm);
            this.pGameOver.Controls.Add(this.txtNome);
            this.pGameOver.Location = new System.Drawing.Point(-500, -500);
            this.pGameOver.Name = "pGameOver";
            this.pGameOver.Size = new System.Drawing.Size(421, 125);
            this.pGameOver.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(80, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(253, 19);
            this.txtNome.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Location = new System.Drawing.Point(124, 76);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(164, 28);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seu nome:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(512, 403);
            this.Controls.Add(this.pGameOver);
            this.Controls.Add(this.lblLastPoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDiff1);
            this.Controls.Add(this.picDiff2);
            this.Controls.Add(this.picDiff3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPoints);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGame";
            this.Text = "Game";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDiff1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiff2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiff3)).EndInit();
            this.pGameOver.ResumeLayout(false);
            this.pGameOver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picDiff3;
        private System.Windows.Forms.PictureBox picDiff2;
        private System.Windows.Forms.PictureBox picDiff1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastPoints;
        private System.Windows.Forms.Panel pGameOver;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirm;
    }
}