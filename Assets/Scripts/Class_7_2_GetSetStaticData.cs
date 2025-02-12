using UnityEngine;

public class Class_7_2_GetSetStaticData : MonoBehaviour
{
    public Class_7_2_Static class_7_2;

    private void Awake()
    {
        Debug.Log($"<color=#f3d>�D�R�A���� : {class_7_2.inventoryWater}</color>");
        Debug.Log($"<color=#f3d>�D�R�A���� : {class_7_2.skillMain}</color>");

        class_7_2.Punch();

        Debug.Log($"<color=#f3d>�R�A���� : {Class_7_2_Static.inventoryProp}</color>");
        Debug.Log($"<color=#f3d>�R�A���� : {Class_7_2_Static.skillSecond}</color>");
        Class_7_2_Static.Kick();
    }

    public Class_7_2_Slime slimeGreen,slimeBlue;

    private void Start()
    {
        slimeBlue.hp -= 5;
        Debug.Log($"<color = #3f3>��v�ܩi HP : {slimeGreen.hp}</color>");
        slimeGreen.hp -= 5;
        Debug.Log($"<color = #3f3>�ťv�ܩi HP : {slimeBlue.hp}</color>");

        Class_7_2_Slime.moveSpeed = 3.5f;
        Debug.Log($"<color = #3f3>�v�ܩi���ʳt�� : {Class_7_2_Slime.moveSpeed}</color>");
    }
}
