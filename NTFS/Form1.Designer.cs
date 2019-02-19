namespace NTFS
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VBRText = new System.Windows.Forms.TextBox();
            this.SectorText = new System.Windows.Forms.TextBox();
            this.nextNTFSText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PartitionTableText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "VBR";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "계산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "섹터개수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "다음 NTFS 섹터";
            // 
            // VBRText
            // 
            this.VBRText.Location = new System.Drawing.Point(154, 60);
            this.VBRText.Name = "VBRText";
            this.VBRText.Size = new System.Drawing.Size(164, 25);
            this.VBRText.TabIndex = 4;
            // 
            // SectorText
            // 
            this.SectorText.Location = new System.Drawing.Point(154, 91);
            this.SectorText.Name = "SectorText";
            this.SectorText.Size = new System.Drawing.Size(164, 25);
            this.SectorText.TabIndex = 5;
            // 
            // nextNTFSText
            // 
            this.nextNTFSText.Location = new System.Drawing.Point(154, 177);
            this.nextNTFSText.Name = "nextNTFSText";
            this.nextNTFSText.Size = new System.Drawing.Size(164, 25);
            this.nextNTFSText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "파티션테이블[Boot]";
            // 
            // PartitionTableText
            // 
            this.PartitionTableText.Location = new System.Drawing.Point(154, 213);
            this.PartitionTableText.Name = "PartitionTableText";
            this.PartitionTableText.Size = new System.Drawing.Size(331, 25);
            this.PartitionTableText.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 257);
            this.Controls.Add(this.PartitionTableText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nextNTFSText);
            this.Controls.Add(this.SectorText);
            this.Controls.Add(this.VBRText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "NTFS 계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VBRText;
        private System.Windows.Forms.TextBox SectorText;
        private System.Windows.Forms.TextBox nextNTFSText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PartitionTableText;
    }
}

