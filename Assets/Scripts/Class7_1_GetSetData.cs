using UnityEngine;

namespace motoshin
{
    public class Class7_1_GetSetData : MonoBehaviour
    {
        public Class7_1_Property property;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log(property.MoveSpeed);  //�i�H
            //Debug.Log(property.TurnSpeed);//�����\

            Debug.Log(property.runspeed);       //�i�H���o���}���ݩ�
            //Debug.Log(property.springspeed);  //���i���o�p�H���ݩ�

            property.runspeed = 50.2f;
            //property.jumpspeed = 99.5f;       //���i�]�w�A�S��set�ݩ�(��Ū)
        }

    
    }
}


