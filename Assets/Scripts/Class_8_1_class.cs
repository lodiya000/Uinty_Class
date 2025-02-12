using UnityEngine;

namespace Lodiya
{
    public class Class_8_1_class : MonoBehaviour
    {
        private void Awake()
        {
            Class_8_1_NPC npcJake = new Class_8_1_NPC("Jake");
            Class_8_1_NPC npcAnn = new Class_8_1_NPC("Ann","hollo~");

            npcJake.LogName();
            npcJake.Talk();
            npcAnn.LogName();
            npcAnn.Talk();
        }
    }
}
