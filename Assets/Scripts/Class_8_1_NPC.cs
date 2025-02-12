using UnityEngine;

namespace Lodiya
{
    public class Class_8_1_NPC
    {
        private string name;
        private string dialogue;

    public Class_8_1_NPC()
        {
            Debug.Log("預設建構值");
        }
    public Class_8_1_NPC(string _name) => name = _name;
    public Class_8_1_NPC(string _name,string _dialogue)
        {
            name = _name;
            dialogue = _dialogue;
            Debug.Log("有參數的建構值");
        }

        public void LogName()
        {
            Debug.Log($"NPC 的名稱 : {name}");

        }

        public void Talk()
        {
            Debug.Log($"{dialogue}");

        }
    }

}