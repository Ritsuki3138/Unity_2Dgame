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
    }
}
