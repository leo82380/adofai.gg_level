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
            levelcur.Text = "adofai.gg/" + level2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. 나오는 링크 복사\n2. 브라우저의 주소창에 붙여넣기\n3. 다운로드 받기\n4. 압축파일 압축 풀고 얼불춤 레벨 에디터 들어가기\n5. 레벨에디터에서 방금 다운로드한 파일을 열기\n6. 즐기기");
        }
    }
}
