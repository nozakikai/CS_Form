using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CS_From
{
    class TestButton:Button
    {
        Form1 _form1;

        public TestButton(Form1 form1,string moji,int x,int y,int width ,int height)
        {
            _form1 = form1; 
            ///コンストラクタ
            ///クラスを生成したときに呼び出される
            //ClickイベントにOnClick 関数を登録
            //ボタンをクリックしたときに登録した関数を実行する
            Click += OnClick;

            //ボタン内に文字を表示させる
            Text = moji.ToString();

            //ボタンの生成場所を指定する
            Location = new Point(x,y);

            //ボタンの大きさを設定する
            Size = new Size(width,height);
            

        }

        public void OnClick(object sender, EventArgs s) 
        {
              _form1.LabelTextUpdate(Text);

              
        }


    }

}
