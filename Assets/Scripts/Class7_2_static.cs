using UnityEngine;
using UnityEngine.SceneManagement;

namespace motoshin
{
    /// <summary>
    /// �R�A static
    /// </summary>
    
    public class Class7_2_static : MonoBehaviour
    {   
        #region 
        //�D�R�A�ܼ�
        public int Itembug = 10;
        //�R�A�ܼ�:�׹����᭱�K�[����r static
        //�R�A�ܼƳ��|��ܦb���O�W
        public static int Itembug2 = 20;

        //�D�R�A�ݩ�
        public string skillMain => "���y�N";
        //�R�A�ݩ�
        public static string skillsecned => "�B��N";
        #endregion
        private void Awake()
        {
            //Itembug = 7;
            //Itembug2 = 15;
            Debug.Log(Itembug);
            Debug.Log(Itembug2);
        }

        public void Punch()
        {
            Debug.Log("�ϥή���");
        }
        public void Kick()
        {
            Debug.Log("�ϥν���");
        }

        private void Start()
        {
            //�bUnity�����t��
            //����������
            //�D�R�A�����|�Q����(�٭쬰�w�]��)
            Itembug++;
            Debug.Log(Itembug);
            //�R�A�������|�Q����
            Itembug2++;
            Debug.Log(Itembug2);
        }
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                SceneManager.LoadScene("Class07_property");
            }
        }
    }
}

