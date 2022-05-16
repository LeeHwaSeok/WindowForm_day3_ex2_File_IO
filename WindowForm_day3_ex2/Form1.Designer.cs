namespace WindowForm_day3_ex2
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
            this.lb_text = new System.Windows.Forms.ListBox();
            this.b_fcopy = new System.Windows.Forms.Button();
            this.b_finfo = new System.Windows.Forms.Button();
            this.b_alphawrite = new System.Windows.Forms.Button();
            this.b_asciiread = new System.Windows.Forms.Button();
            this.b_fsave = new System.Windows.Forms.Button();
            this.b_f_read2 = new System.Windows.Forms.Button();
            this.tb_file = new System.Windows.Forms.TextBox();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.comboboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기로이름을해서ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_text
            // 
            this.lb_text.FormattingEnabled = true;
            this.lb_text.ItemHeight = 18;
            this.lb_text.Location = new System.Drawing.Point(107, 114);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(446, 94);
            this.lb_text.TabIndex = 0;
            this.lb_text.SelectedIndexChanged += new System.EventHandler(this.lb_text_SelectedIndexChanged);
            // 
            // b_fcopy
            // 
            this.b_fcopy.Location = new System.Drawing.Point(605, 126);
            this.b_fcopy.Name = "b_fcopy";
            this.b_fcopy.Size = new System.Drawing.Size(146, 45);
            this.b_fcopy.TabIndex = 1;
            this.b_fcopy.Text = "파일 복사";
            this.b_fcopy.UseVisualStyleBackColor = true;
            this.b_fcopy.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_finfo
            // 
            this.b_finfo.Location = new System.Drawing.Point(793, 126);
            this.b_finfo.Name = "b_finfo";
            this.b_finfo.Size = new System.Drawing.Size(146, 45);
            this.b_finfo.TabIndex = 2;
            this.b_finfo.Text = "파일 정보";
            this.b_finfo.UseVisualStyleBackColor = true;
            this.b_finfo.Click += new System.EventHandler(this.b_finfo_Click);
            // 
            // b_alphawrite
            // 
            this.b_alphawrite.Location = new System.Drawing.Point(121, 320);
            this.b_alphawrite.Name = "b_alphawrite";
            this.b_alphawrite.Size = new System.Drawing.Size(146, 45);
            this.b_alphawrite.TabIndex = 4;
            this.b_alphawrite.Text = "알파벳 저장";
            this.b_alphawrite.UseVisualStyleBackColor = true;
            this.b_alphawrite.Click += new System.EventHandler(this.b_fwrit_Click);
            // 
            // b_asciiread
            // 
            this.b_asciiread.Location = new System.Drawing.Point(344, 320);
            this.b_asciiread.Name = "b_asciiread";
            this.b_asciiread.Size = new System.Drawing.Size(146, 45);
            this.b_asciiread.TabIndex = 3;
            this.b_asciiread.Text = "ascii로 읽기";
            this.b_asciiread.UseVisualStyleBackColor = true;
            this.b_asciiread.Click += new System.EventHandler(this.b_f_read1_Click);
            // 
            // b_fsave
            // 
            this.b_fsave.Location = new System.Drawing.Point(605, 320);
            this.b_fsave.Name = "b_fsave";
            this.b_fsave.Size = new System.Drawing.Size(146, 45);
            this.b_fsave.TabIndex = 6;
            this.b_fsave.Text = "파일 저장";
            this.b_fsave.UseVisualStyleBackColor = true;
            this.b_fsave.Click += new System.EventHandler(this.b_fsave_Click);
            // 
            // b_f_read2
            // 
            this.b_f_read2.Location = new System.Drawing.Point(793, 320);
            this.b_f_read2.Name = "b_f_read2";
            this.b_f_read2.Size = new System.Drawing.Size(146, 45);
            this.b_f_read2.TabIndex = 5;
            this.b_f_read2.Text = "파일 읽기";
            this.b_f_read2.UseVisualStyleBackColor = true;
            this.b_f_read2.Click += new System.EventHandler(this.b_f_read2_Click);
            // 
            // tb_file
            // 
            this.tb_file.Location = new System.Drawing.Point(85, 398);
            this.tb_file.Multiline = true;
            this.tb_file.Name = "tb_file";
            this.tb_file.Size = new System.Drawing.Size(448, 288);
            this.tb_file.TabIndex = 7;
            this.tb_file.TextChanged += new System.EventHandler(this.tb_file_TextChanged);
            // 
            // tb_text
            // 
            this.tb_text.Location = new System.Drawing.Point(553, 398);
            this.tb_text.Multiline = true;
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(448, 288);
            this.tb_text.TabIndex = 8;
            this.tb_text.TextChanged += new System.EventHandler(this.tb_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "파일 정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "FileStream byte 단위 처리";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "텍스트 입출력";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1409, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboboxToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1409, 33);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // comboboxToolStripMenuItem
            // 
            this.comboboxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기로이름을해서ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.종료ToolStripMenuItem,
            this.저장하기ToolStripMenuItem});
            this.comboboxToolStripMenuItem.Name = "comboboxToolStripMenuItem";
            this.comboboxToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.comboboxToolStripMenuItem.Text = "파일";
            this.comboboxToolStripMenuItem.Click += new System.EventHandler(this.comboboxToolStripMenuItem_Click);
            // 
            // 새로만들기로이름을해서ToolStripMenuItem
            // 
            this.새로만들기로이름을해서ToolStripMenuItem.Name = "새로만들기로이름을해서ToolStripMenuItem";
            this.새로만들기로이름을해서ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.새로만들기로이름을해서ToolStripMenuItem.Text = "새로만들기";
            this.새로만들기로이름을해서ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기로이름을해서ToolStripMenuItem_Click);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 저장하기ToolStripMenuItem
            // 
            this.저장하기ToolStripMenuItem.Name = "저장하기ToolStripMenuItem";
            this.저장하기ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.저장하기ToolStripMenuItem.Text = "저장하기";
            this.저장하기ToolStripMenuItem.Click += new System.EventHandler(this.저장하기ToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "텍스트 입출력";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 815);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_text);
            this.Controls.Add(this.tb_file);
            this.Controls.Add(this.b_fsave);
            this.Controls.Add(this.b_f_read2);
            this.Controls.Add(this.b_alphawrite);
            this.Controls.Add(this.b_asciiread);
            this.Controls.Add(this.b_finfo);
            this.Controls.Add(this.b_fcopy);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_text;
        private System.Windows.Forms.Button b_fcopy;
        private System.Windows.Forms.Button b_finfo;
        private System.Windows.Forms.Button b_alphawrite;
        private System.Windows.Forms.Button b_asciiread;
        private System.Windows.Forms.Button b_fsave;
        private System.Windows.Forms.Button b_f_read2;
        private System.Windows.Forms.TextBox tb_file;
        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem comboboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기로이름을해서ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장하기ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}

