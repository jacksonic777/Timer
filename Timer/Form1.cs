using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class FormTimer : Form
    {

        int endTime; // 終了時間
        int nowTime; // 経過時間
        int remainingTime; // 残り時間

        public FormTimer()
        {
            InitializeComponent();
        }

        // ボタンクリック時の処理
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // 時間設定のTextBoxの内容を終了時間の変数に取得
            // 残り時間を計算するため経過時間の変数を0で初期化
            // タイマースタート

        }
    }
}
