﻿using System;
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
        public TestButton(int id,int x,int y,int width ,int height)
        {
            ///コンストラクタ
            ///クラスを生成したときに呼び出される
            //ClickイベントにOnClick 関数を登録
            //ボタンをクリックしたときに登録した関数を実行する
            Click += OnClick;

            //ボタン内に文字を表示させる
            Text = id.ToString();

            //ボタンの生成場所を指定する
            Location = new Point(x,y);

            //ボタンの大きさを設定する
            Size = new Size(width,height);
            

        }

        public void OnClick(object sender, EventArgs e) 
        {
            MessageBox.Show("三代目雷影　佐久間唯斗");
        }
    }
}
