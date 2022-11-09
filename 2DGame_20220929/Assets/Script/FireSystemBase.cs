using UnityEngine;

namespace Ritsuki
{
    /// <summary>
    /// �o�g�t�ΰ�
    /// </summary>
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("�l�u�w�s��")]
        private GameObject prefabBullet;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointSpawn;

        // �ۭq��k
        // �l�u�ͦ�
        // �O�@�ŧO�G���\�l���O�s��
        protected void SpawnBullet() 
        {
        // ��Ҥ�(�ͦ�����A�y�СA����);
        // �ͦ� �l�u�w�s�� �y�лP���׸�ͦ��I�ۦP
        Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        }
    }
}
