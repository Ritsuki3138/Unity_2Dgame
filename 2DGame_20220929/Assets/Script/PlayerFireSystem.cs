using UnityEngine;

namespace Ritsuki
{
    /// <summary>
    /// 玩家發射系統
    /// </summary>
    public class PlayerFireSystem : FireSystemBase
    {
        // 偵測玩家輸入行為：鍵盤，滑鼠，觸控與搖桿
        private void Update()
        {
            // 如果 玩家按下 Z 鍵 就生成子彈
            if (Input.GetKeyDown(KeyCode.Z))
            {
                //呼叫方法
                SpawnBullet();
            }
        }
    }

}
