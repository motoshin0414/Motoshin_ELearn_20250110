using UnityEngine;

public class Class7_1_Property : MonoBehaviour
{
    //公開的變數:可以讓外部存取與寫入
    public float MoveSpeed = 3.5f;

    //私人的變數:不允許外部讀取與寫入
    private float TurnSpeed = 12.5f;
}
