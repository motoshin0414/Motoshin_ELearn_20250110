using UnityEngine;
namespace motoshin
{
    public class Class7_1_Property : MonoBehaviour
    {
        //公開的變數:可以讓外部存取與寫入
        public float MoveSpeed = 3.5f;

        //私人的變數:不允許外部讀取與寫入
        private float TurnSpeed = 12.5f;

        //公開的屬性:允許存取
        public float runspeed { get; set; }
        //私人的屬性:不許存取
        private float springspeed { get; set; }
        //公開的屬性:只有get代表唯讀(只有讀取不能寫入)
        public float jumpspeed { get; }

        //prop + Tab  快速寫法
        //有預設值的屬性
        public byte LV { get; set; } = 1;

        private void Awake()
        {
            #region 認識屬性 Property
            Debug.Log("---取得變數與屬性---");
            Debug.Log(MoveSpeed);
            Debug.Log(TurnSpeed);
            Debug.Log(TurnSpeed);
            Debug.Log(springspeed);
            Debug.Log(jumpspeed);
            Debug.Log(LV);
            Debug.Log("---設定變數與屬性---");
            MoveSpeed = 11.5f;
            TurnSpeed = 14.5f;          //私人變數在類別內可以設定
            runspeed = 30f;
            springspeed = 60.2f;
            //jumpspeed = 44.2f;        沒有set的屬性在類別內也無法設定
            LV = 100;
            #endregion
        }

            //屬性簡寫
            public float hp { get; set; } = 100;

        //屬性標準寫法
        //_mp 用來裝屬性 mp 值得容器
        private float _mp = 50;
        //屬性是給予外部存取權限的窗口
        public float mp
        {
            get
            {
                return _mp;
            }
            set
            {
                _mp = value;
            }
        }

        //取得屬性的簡寫(箭頭 => Lambda)
        //唯讀屬性 防禦值 30
        public int defence { get; } = 30;
        //唯讀屬性 攻擊值 50
        public int Attack => 50;

        private void Start()
        {
            Debug.Log(mp);
            mp = 500;
            Debug.Log(mp);
        }
    }
    
}

