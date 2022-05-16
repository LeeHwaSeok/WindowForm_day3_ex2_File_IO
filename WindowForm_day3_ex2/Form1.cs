using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowForm_day3_ex2
{
    public partial class Form1 : Form
    {   //경로를 전역변수로 선언
        string path = @"C:\Users\82102\Desktop\휴스타\Window_form_example\test.txt";
        byte[] data = new byte[52];
        //A TO Z and a TO z 출력

        public Form1() { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e)
        {   //b_fcopy

            try
            {
                lb_text.Items.Clear();
                if (File.Exists(path))  //파일에 경로가 존재하는지 확인 
                {
                    File.Copy(path, @"C:\Users\82102\Desktop\휴스타\Window_form_example\test_copy.txt"); //파일 자체를 복사
                    lb_text.Items.Add("복사 완료");
                }
                else
                {
                    lb_text.Items.Clear();
                    lb_text.Items.Add("파일 없음");
                }
            }
            catch (Exception) //예외처리
            {
                lb_text.Items.Clear();
                lb_text.Items.Add("이미 파일 존재");
            }
        }

        private void b_finfo_Click(object sender, EventArgs e)
        {
            //Fileinfo, test.txt
            lb_text.Items.Clear();

            //dirinfo는 인스턴스 형식이라 new로 할당해줘야함.
            //file, dir은 정적형식이라 할당이 필요없음
            FileInfo fileinfo = new FileInfo(path);

            lb_text.Items.Clear();

            //예외처리 생성정보 확인 => Exists
            if (fileinfo.Exists)
            { //파일 대략 정보
                lb_text.Items.Add("전체경로 : " + fileinfo.Directory);
                lb_text.Items.Add("파일 이름 : " + fileinfo.Name);
                lb_text.Items.Add("확장자 : " + fileinfo.Extension);
                lb_text.Items.Add("생성일 : " + fileinfo.CreationTime);
                lb_text.Items.Add("크기 : " + fileinfo.Length);
            }
        }

        private void b_fwrit_Click(object sender, EventArgs e)
        {   //ascii code로 실행

            //파일 스트림 
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            //경로
            //파일모드 열기, 생성
            //파일권한 읽기, 쓰기
            //python -> f.write, f.read --> FileStream

            for (int i = 0; i < 26; i++)
            {
                data[i] = (byte)(i + 65);
                //대문자를 ascii 단위로 표현 
            }

            for (int i = 0; i < 26; i++)
            {
                data[i + 26] = (byte)(i + 97);
                //소문자를 ascii 단위로 표현 
            }

            fs.Write(data, 0, data.Length);
            fs.Close();
            MessageBox.Show("파일 기록");
        }

        private void b_f_read1_Click(object sender, EventArgs e)
        {   //단어를 하나의 바이트로 읽어오기 
            tb_file.Clear();
            try
            {
                FileStream fr = new FileStream(path, FileMode.Open, FileAccess.Read);

                fr.Read(data, 0, data.Length);
                fr.Close();

                for (int i = 0; i < data.Length; i++)
                {
                    // tb_file.Text += data[i].ToString() + " , ";
                    tb_file.Text += Convert.ToChar(data[i]) + " , ";
                    if (i == 25) tb_file.Text += "\r\n \r\n";
                }
            }
            catch (FileNotFoundException)
            {

                label2.Text = "파일을 찾을 수 없습니다.";
                //MessageBox.Show("파일을 찾을 수 없습니다.");
            }
        }

        private void tb_file_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }

        private void b_f_read2_Click(object sender, EventArgs e)
        {   //읽기
            StreamReader sr = new StreamReader(path);
            tb_text.Text = sr.ReadToEnd(); //path의 글을 Text로 읽어온다.

            //or 한 줄씩 읽어오기         +=하면 한줄에 다 적을 수 있음.
            /*            while (!sr.EndOfStream)
                        { tb_text.Text = sr.ReadLine(); }*/

            sr.Close();
        }

        private void b_fsave_Click(object sender, EventArgs e)
        {   //쓰기
            StreamWriter sw = new StreamWriter(path);
            sw.Write(tb_text.Text);  //tb_Text의 글을 path에 저장한다.
            sw.Close();
        }

        private void tb_text_TextChanged(object sender, EventArgs e) { }

        private void comboboxToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void toolStripComboBox1_Click(object sender, EventArgs e) { }

        private void 새로만들기로이름을해서ToolStripMenuItem_Click(object sender, EventArgs e) { label4.Text = " 새파일 "; }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e) { label4.Text = "열기"; }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e) { Application.Exit(); }

        private void 저장하기ToolStripMenuItem_Click(object sender, EventArgs e) { label4.Text = "저장"; }

        private void lb_text_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
