using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_From
{
    class TestTextBox : TextBox
    {
        public TestTextBox(string str, int x, int y, int width, int height)
        {


            // ラベル内に文字を表示させる              
            Text = str;

            //ボタンの生成場所を指定する
            Location = new Point(x, y);

            //ボタンの大きさを設定する
            Size = new Size(width, height);


           
        }
    }
}
