using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterQuestData", menuName = "QuestScriptable/Monster", order = 1)]
public class MonsterQuestDataSO : QuestDataSO
{
    [Header("Monster Quest Info")]
    public string MonsterName;
}
