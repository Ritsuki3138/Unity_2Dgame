using UnityEngine;

namespace Ritsuki
{
    /// <summary>
    /// ���a�o�g�t��
    /// </summary>
    public class PlayerFireSystem : FireSystemBase
    {
        // �������a��J�欰�G��L�A�ƹ��AĲ���P�n��
        private void Update()
        {
            // �p�G ���a���U Z �� �N�ͦ��l�u
            if (Input.GetKeyDown(KeyCode.Z))
            {
                //�I�s��k
                SpawnBullet();
            }
        }
    }

}
