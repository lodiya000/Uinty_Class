using UnityEngine;

public class Class_3_Operator : MonoBehaviour
{
    #region 
    // C# 變數 = 欄位 Field 
    // 欄位屬性 Field Attritube 
    // [標題(標題文字)]:在屬性面板上顯示標題文字 
    [Header("等級")]
    public int lv = 1;
    // [提示(提示文字)]:在屬性面板滑鼠停留在變數上時顯示
    [Tooltip("這是角色的移動速度,不建議超過 100。")]
    public float moveSpeed = 2.5f;
    // [範圍(最小,最大)]:幫數值類型添加範園(面板上改為滑桿)
    [Range(1, 100)] public byte count = 10;
    // 範圍不能使用在非數值類型上,會顯示"Use Range With ... "
    [Range(0, 10)]
    public string weapon = "匕首";
    //[文字範圍(最小行,最大行)]:使用在字串上,設定面板上的文字框範圍
    [TextArea(2, 5)]
    public string itemDescription = "這裡是道具的描述，這裡是道具的描述，這裡是道具的描述。";
    #endregion

    [Header("血量")][Range(0, 999)]
    public int hp = 100;
    [Header("攻擊力"), Range(0,100)]
    public float attack = 100;

    [HideInInspector]
    public string password = "密碼";
    [SerializeField]
    private float mp = 500;

    private void Awake()
    {
        Debug.Log("hollo world!");

        Debug.Log("生命 = " + hp);

        Debug.Log("<b>粗體</b>");
        Debug.Log("<color=yellow>黃色</color>");

        int number1 = 10, number2 = 3;

        Debug.Log(number1 + number2);
        Debug.Log(number1 - number2);
        Debug.Log(number1 * number2);
        Debug.Log(number1 / number2);
        Debug.Log(number1 % number2);

        Debug.Log(1 + 1 != 2);
        Debug.Log(1 + 1 == 2);
    }
}
