﻿using UnityEngine;

namespace Ritsuki
{
    /// <summary>
    /// 發射系統基底
    /// </summary>
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("子彈預製物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;
        [SerializeField, Header("發射音效")]
        private AudioClip soundFire;

        // 自訂方法
        // 子彈生成
        // 保護級別：允許子類別存取
        protected void SpawnBullet() 
        {
            // 實例化(生成物件，座標，角度);
            // 生成 子彈預製物 座標與角度跟生成點相同
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
            SoundManager.instance.Playsound(soundFire, new Vector2(0.4f, 0.9f));
        }
    }
}
