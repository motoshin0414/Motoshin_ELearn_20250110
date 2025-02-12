using UnityEngine;

namespace motoshin
{
    /// <summary>
    /// NPC 類別:NP名稱與對話內容資料，有輸出NPC名字與說話的功能
    /// </summary>
    public class Class8_1_NPC
    {
        private string name;
        private string dialogue;

        //預設建構子
        public Class8_1_NPC()
        {
            Debug.Log($"預設建構子");
        }
        //建構子的簡寫
        public Class8_1_NPC(string _Name) => name = _Name;

        public Class8_1_NPC(string _Name,string _dialogue)
        {
            name = _Name;
            dialogue = _dialogue;
            Debug.Log($"有參數的建構子");
        }

        public void LogName()
        {
            Debug.Log($"NPC的名稱:{name}");

        }
        public void Talk()
        {
            Debug.Log($"{dialogue}");
        }
    }

}

