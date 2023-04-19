using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adofai.gg_level
{
    public partial class Form1 : Form
    {
        Random level = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void levelBtn_Click(object sender, EventArgs e)
        {
            int level2 = level.Next(1, 4734);
            levelcur.Text = "adofai.gg/levels" + level2;
            System.Diagnostics.Process compiler = new System.Diagnostics.Process();
            compiler.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            compiler.StartInfo.Arguments = "https://adofai.gg/levels/" + level2;
            compiler.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. 버튼 클릭 후 뜨는 창에서 파일 다운로드\n2. 파일 압축 풀고 얼불춤 실행\n3. 레벨 에디터 들어간 후 열기");
        }
    }
}
