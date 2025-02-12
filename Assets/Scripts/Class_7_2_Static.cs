using UnityEngine;
using UnityEngine.SceneManagement;

public class Class_7_2_Static : MonoBehaviour
{
    public int inventoryWater = 10;
    public static int inventoryProp = 20;

    public  string skillMain = "火焰箭";
    public static string skillSecond = "治癒術";

    private float attatk = 10;
    private static float mp = 10;

    private void Awake()
    {
        //inventoryWater = 7;
        //inventoryProp = 15;
        Debug.Log($"<color=#7f7>藥水:{inventoryWater}</color>");
        Debug.Log($"<color=#7f7>道具:{inventoryProp}</color>");
    }

    public void Punch()
    {
        Debug.Log("<color=#7f7>使用拳擊</color>");
        Debug.Log($"<color=#f9e>攻擊力{attatk}</color>");
        Debug.Log($"<color=#f9e>魔力{mp}</color>");

    }

    public static void Kick()
    {
        Debug.Log("<color=#7f7>使用踢擊</color>");
        //Debug.Log($"<color=#f9e>攻擊力{attatk}</color>");
        Debug.Log($"<color=#f9e>魔力{mp}</color>");
    }

    private void Start()
    {
        inventoryWater++;
        Debug.Log($"<color=#7f7>藥水:{inventoryWater}</color>");
        inventoryProp++;
        Debug.Log($"<color=#7f7>道具:{inventoryProp}</color>");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("課程_7_場景與靜態");
        }
    }

}
