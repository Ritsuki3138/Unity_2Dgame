using UnityEngine;

namespace Rin
{ 
    /// <summary>
  /// �Ĥ@�Ӹ}��
  /// 2022.10.13
  /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region ���Ѱϰ�

        // �Y�� �ֱ���GTab
        // �榡�Ƥ�� �ֱ���G Ctrl + K D
        // ������

        /* �h�����
         * 
         */

        // A a �O���P���r

        #endregion

        #region �ƥ�ϰ�
        //����ƥ�G�C���}�l�ɰ���@��
        private void Awake()
        {
            //��X(�T��)�G
            print("Hello World !!");
        }

        //�}�l�ƥ�GAwake �����@��
        private void Start()
        {
            print("<color=green> �}�l�ƥ� </color>");
        }

        //��s�ƥ�GStart �������C�V����A����� 60 FPS
        private void Update()
        {
            print("<color=blue> ��s�ƥ� </color>");
        }
        #endregion
    }
}
