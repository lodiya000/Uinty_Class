using UnityEngine;
using UnityEngine.SceneManagement;

public class Practice_7 :�@MonoBehaviour
{
    public static float HP = 5;

    private void Start()
    {
        HP--;
        Debug.Log($"<color=#7f7>�ͩR��:{HP}</color>");
        if (HP == 0) Debug.Log("You are Died");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("�ҵ{_7_�����P�R�A");
        }
    }
}
