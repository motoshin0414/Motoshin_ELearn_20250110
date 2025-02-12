using UnityEngine;
using UnityEngine.SceneManagement;

namespace motoshin
{
    /// <summary>
    /// 靜態 static
    /// </summary>
    
    public class Class7_2_static : MonoBehaviour
    {   
        #region 
        //非靜態變數
        public int Itembug = 10;
        //靜態變數:修飾詞後面添加關鍵字 static
        //靜態變數部會顯示在面板上
        public static int Itembug2 = 20;

        //非靜態屬性
        public string skillMain => "火球術";
        //靜態屬性
        public static string skillsecned => "冰凍術";

        private float attack = 10;
        private static float MP = 100;
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
            Debug.Log("非靜態方法:使用拳擊");
            //非靜態方法內可以存取所有成員
            Debug.Log($"非靜態攻擊力:{attack}");
            Debug.Log($"靜態魔力:{MP}");
        }

        public static void Kick()
        {
            Debug.Log("靜態方法:使用踢擊");
            //靜態方法內只能存取靜態成員
            //由於attack 是非靜態成員所以無法存取
            //Debug.Log($"非靜態攻擊力:{attack}");
            Debug.Log($"靜態魔力:{MP}");
        }

        private void Start()
        {
            //在Unity內的差異
            //切換場景時
            //非靜態成員會被釋放(還原為預設值)
            Itembug++;
            Debug.Log(Itembug);
            //靜態成員不會被釋放
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

