﻿using UnityEngine;

namespace Ritsuki
{
    /// <summary>
    /// 學習欄位 Field
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        // 欄位 Field：儲存資料
        // 語法：
        // 修飾詞 資料類型 欄位名稱；

        // 定義了一筆資料，名稱是Level，類型是整數
        private int level;

        // = 指定符號：將右邊的結果給左邊
        // 修飾詞：設定資料權限
        // 私人：僅允許此類別存取
        private int enemy = 7;
        // 公開：允許所有類別存取
        public int hp = 100;

        // 整數
        public int countProp = 7;

        // 浮點數
        public float speed = 3.5f;
        public float jump = 7.7F;

        // 字串
        public string namePlayer = "小騎士";
        public string content = "嗨，你好~";

        // 布林值
        public bool inPass = true;
        public bool inDead = false;

        //標題
        [Header("武器數量")]
        public int weaponCount = 10;

        //提示
        [Tooltip("這是補充 100 滴 HP 的紅色藥水，一罐 999 元。")]
        public string propName = "紅色藥水";

        //範圍
        [Range(0, 100)]
        public int Score = 60;
        [Range(1f, 10.5f)]
        public float walkSpeed = 3.7f;
        [Range(1, 7)]
        public string weaponPlayer = "打火機";

        //序列化欄位
        [SerializeField]
        private string password = "1@3a978321";

        [Header("數字")]
        [Range(0, 100)]
        [SerializeField]
        private int number = 77;

        [SerializeField, Header("是否開門")]
        private bool isOpen = false;
    }
}
