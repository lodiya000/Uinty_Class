using UnityEngine;

namespace Lodiya
{
    public class Class_8_1_NPC
    {
        private string name;
        private string dialogue;

    public Class_8_1_NPC()
        {
            Debug.Log("�w�]�غc��");
        }
    public Class_8_1_NPC(string _name) => name = _name;
    public Class_8_1_NPC(string _name,string _dialogue)
        {
            name = _name;
            dialogue = _dialogue;
            Debug.Log("���Ѽƪ��غc��");
        }

        public void LogName()
        {
            Debug.Log($"NPC ���W�� : {name}");

        }

        public void Talk()
        {
            Debug.Log($"{dialogue}");

        }
    }

}