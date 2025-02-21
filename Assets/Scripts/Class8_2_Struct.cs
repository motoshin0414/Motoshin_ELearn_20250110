using UnityEngine;

namespace motoshin
{
    /// <summary>
    /// 結構 struct
    /// </summary>
    public class Class8_2_Struct : MonoBehaviour
    {
        private void Awake()
        {
            Class8_2_PlayerData player1 = new Class8_2_PlayerData(2, 30);
            Class8_2_PlayerData player2 = new Class8_2_PlayerData(5, 100);
        }
    }
}


