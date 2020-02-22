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
    /// <summary>
    /// 
    /// </summary>
    public partial class FormTimer : Form
    {

        int endTime; // 終了時間
        int nowTime; // 経過時間
        int remainingTime; // 残り時間

        /// <summary>
        /// 
        /// </summary>
        public FormTimer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // ボタンクリック時の処理
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // 時間設定のTextBoxの内容を終了時間の変数に取得
            if(!int.TryParse(textSetTime.Text, out endTime)) 
            {
                endTime = 1;
            }
            // 残り時間を計算するため経過時間の変数を0で初期化
            nowTime = 0;

            // タイマースタート
            timerControll.Start();


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerControll_Tick(object sender, EventArgs e)
        {
            //　残り時間の変数を整数型で定義
            int remainingTime;
            //　経過時間に1秒を加える
            nowTime++;
            //　残り時間を計算して表示
            remainingTime = endTime - nowTime;
            textRemainingTime.Text = remainingTime.ToString();
            //　＜判定＞設定時間になった？
            if(endTime == nowTime) 
            {
                //　「Yes」の場合の処理
                //　タイマーを止める
                timerControll.Stop();
                //　終了時間になったことを知らせる
                MessageBox.Show("時間になりました！");

            } else 
            {
                // 「No」の場合の処理
            }
        }
    }
}
