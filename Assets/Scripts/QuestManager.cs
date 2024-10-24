using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager instance = null;
    public List<QuestDataSO> Quests;

    public static QuestManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<QuestManager>();
            }

            if (instance == null)
            {
                GameObject go = new GameObject();
                instance = go.AddComponent<QuestManager>();
                DontDestroyOnLoad(go);
            }
            return instance;
        }
        set
        {
            instance = value;
        }
    }

    private void Awake() 
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        for (int i = 0; i < Quests.Count; i++)
        {
            QuestDataSO quest = Quests[i];
            Debug.Log($"Quest {i + 1} - {quest.QuestName} (최소 레벨 {quest.QuestRequiredLevel})");

            if (quest is MonsterQuestDataSO)
            {
                MonsterQuestDataSO monsterQuest = (MonsterQuestDataSO)quest;
                Debug.Log($"{monsterQuest.MonsterName}을(를) {monsterQuest.SweepMonsterCount}마리 소탕");
            }
            else if (quest is EncounterQuestDataSO)
            {
                EncounterQuestDataSO encounterQuest = (EncounterQuestDataSO)quest;
                Debug.Log($"{encounterQuest.encounterName}과 대화하기");
            }
        }
    }
}
