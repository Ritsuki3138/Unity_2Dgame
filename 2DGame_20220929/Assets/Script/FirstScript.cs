﻿using UnityEngine;

namespace Rin
{ 
    /// <summary>
  /// 第一個腳本
  /// 2022.10.13
  /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region 註解區域

        // 縮排 快捷鍵：Tab
        // 格式化文件 快捷鍵： Ctrl + K D
        // 單行註解

        /* 多行註解
         * 
         */

        // A a 是不同的字

        #endregion

        #region 事件區域
        //喚醒事件：遊戲開始時執行一次
        private void Awake()
        {
            //輸出(訊息)：
            print("Hello World !!");
        }

        //開始事件：Awake 後執行一次
        private void Start()
        {
            print("<color=green> 開始事件 </color>");
        }

        //更新事件：Start 之後持續每幀執行，執行約 60 FPS
        private void Update()
        {
            print("<color=blue> 更新事件 </color>");
        }
        #endregion
    }
}
