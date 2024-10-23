using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EncounterQuestData", menuName = "QuestScriptable/Encounter", order = 2)]
public class EncounterQuestDataSO : QuestDataSO
{
    [Header("Encounter Quest Info")]
    public string encounterName;
}
