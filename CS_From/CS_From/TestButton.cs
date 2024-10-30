using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CS_From
{
    class TestButton:Button
    {
        public TestButton()
        {
            //ClickイベントにOnClick 関数を登録
            //ボタンをクリックしたときに登録した関数を実行する
            Click += OnClick;


        }

        public void OnClick(object sender, EventArgs e) 
        {
            MessageBox.Show("三代目雷影　佐久間唯斗");
        }
    }
}
