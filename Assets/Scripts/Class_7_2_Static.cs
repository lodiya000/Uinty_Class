using UnityEngine;
using UnityEngine.SceneManagement;

public class Class_7_2_Static : MonoBehaviour
{
    public int inventoryWater = 10;
    public static int inventoryProp = 20;

    public  string skillMain = "���K�b";
    public static string skillSecond = "�v¡�N";

    private float attatk = 10;
    private static float mp = 10;

    private void Awake()
    {
        //inventoryWater = 7;
        //inventoryProp = 15;
        Debug.Log($"<color=#7f7>�Ĥ�:{inventoryWater}</color>");
        Debug.Log($"<color=#7f7>�D��:{inventoryProp}</color>");
    }

    public void Punch()
    {
        Debug.Log("<color=#7f7>�ϥή���</color>");
        Debug.Log($"<color=#f9e>�����O{attatk}</color>");
        Debug.Log($"<color=#f9e>�]�O{mp}</color>");

    }

    public static void Kick()
    {
        Debug.Log("<color=#7f7>�ϥν���</color>");
        //Debug.Log($"<color=#f9e>�����O{attatk}</color>");
        Debug.Log($"<color=#f9e>�]�O{mp}</color>");
    }

    private void Start()
    {
        inventoryWater++;
        Debug.Log($"<color=#7f7>�Ĥ�:{inventoryWater}</color>");
        inventoryProp++;
        Debug.Log($"<color=#7f7>�D��:{inventoryProp}</color>");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("�ҵ{_7_�����P�R�A");
        }
    }

}
