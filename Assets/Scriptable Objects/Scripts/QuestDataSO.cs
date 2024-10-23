using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultQuestData", menuName = "QuestScriptable/Default", order = 0)]
public class QuestDataSO : ScriptableObject
{
    [Header("Quest Info")]
    public string QuestName;
    public int QuestRequiredLevel;
    public int QuestNPC;
    public  List<int> QuestPrerequisites;
}
