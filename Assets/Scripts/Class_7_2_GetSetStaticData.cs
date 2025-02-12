using UnityEngine;

public class Class_7_2_GetSetStaticData : MonoBehaviour
{
    public Class_7_2_Static class_7_2;

    private void Awake()
    {
        Debug.Log($"<color=#f3d>非靜態成員 : {class_7_2.inventoryWater}</color>");
        Debug.Log($"<color=#f3d>非靜態成員 : {class_7_2.skillMain}</color>");

        class_7_2.Punch();

        Debug.Log($"<color=#f3d>靜態成員 : {Class_7_2_Static.inventoryProp}</color>");
        Debug.Log($"<color=#f3d>靜態成員 : {Class_7_2_Static.skillSecond}</color>");
        Class_7_2_Static.Kick();
    }

    public Class_7_2_Slime slimeGreen,slimeBlue;

    private void Start()
    {
        slimeBlue.hp -= 5;
        Debug.Log($"<color = #3f3>綠史萊姆 HP : {slimeGreen.hp}</color>");
        slimeGreen.hp -= 5;
        Debug.Log($"<color = #3f3>藍史萊姆 HP : {slimeBlue.hp}</color>");

        Class_7_2_Slime.moveSpeed = 3.5f;
        Debug.Log($"<color = #3f3>史萊姆移動速度 : {Class_7_2_Slime.moveSpeed}</color>");
    }
}
