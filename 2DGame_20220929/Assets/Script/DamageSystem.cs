using UnityEngine;

namespace Ritsuki
{
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("爆炸預製物")]
        private GameObject perfabExplosion;
        [SerializeField, Header("碰到會爆炸的名稱")]
        private string nameTarget;
        [Header("受傷與爆炸音效")]
        [SerializeField]
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;

        //碰撞開始時執行一次
        private void OnCollisionEnter2D(Collision2D collision)
        {
            print(collision.gameObject.name);
            // 如果碰到的物件名稱 包含 敵機 就爆炸
            if (collision.gameObject.name.Contains(nameTarget))
            {
                //生成爆炸預製物 座標與角度 跟此物件相同
                Instantiate(perfabExplosion, transform.position, transform.rotation);

                SoundManager.instance.Playsound(soundHit, new Vector2(0.7f, 0.9f));
                SoundManager.instance.Playsound(soundExplosion, new Vector2(1.2f, 1.5f));

                // 刪除 Destory
                // 此物件 gameObject
                Destroy(gameObject);
            }
        }

        //碰撞離開時執行一次
        private void OnCollisionExit2D(Collision2D collision)
        {

        }

        //碰撞時持續執行
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }
}
