using UnityEngine;
/// <summary>
/// 陣列 Array
/// </summary>

public class Class6_2_Array : MonoBehaviour
{

    private int[][] numbers = new int[2][];

    private int[][,] counts = new int[2][,];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        //不規則陣列基本寫法
        numbers[0] = new int[] { 1,2,6};
        numbers[1] = new int[] { 9, 0 };

        //取得數字6
        Debug.Log($"<color=#3ff>不規則陣列的數字6:{numbers[0][2]}</color>");
    }

    
}
