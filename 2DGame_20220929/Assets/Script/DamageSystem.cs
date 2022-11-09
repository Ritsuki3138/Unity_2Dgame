using UnityEngine;

namespace Ritsuki
{
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�z���w�s��")]
        private GameObject perfabExplosion;
        [SerializeField, Header("�I��|�z�����W��")]
        private string nameTarget;

        //�I���}�l�ɰ���@��
        private void OnCollisionEnter2D(Collision2D collision)
        {
            print(collision.gameObject.name);
            // �p�G�I�쪺����W�� �]�t nameTarget �N�z���çR��
            if (collision.gameObject.name.Contains(nameTarget))
            {
                //�ͦ��z���w�s�� �y�лP���� �򦹪���ۦP
                Instantiate(perfabExplosion, transform.position, transform.rotation);

                // �R�� Destory
                // ������ gameObject
                Destroy(gameObject);
            }
        }

        //�I�����}�ɰ���@��
        private void OnCollisionExit2D(Collision2D collision)
        {

        }

        //�I���ɫ������
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }
}
