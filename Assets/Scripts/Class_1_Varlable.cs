using UnityEngine;
//2025/2/7

/*第一行
第二行
 
 */

//修飾詞 類別關鍵詞(腳本) 類別名稱(腳本名稱)
//在腳本後添加 :MonoBehaviour 讓此腳本可以掛在Unity的物件上上
public class Class_1_Varlable : MonoBehaviour
{
    //公開:允許其他類別存取 public
    //私人:不允許其他類別存取 private(預設)
    public int cost = 999;
    private float jumphight = 77.5f;
    public string weapon = "三項之力";
    private bool dragensoul = true;

}
