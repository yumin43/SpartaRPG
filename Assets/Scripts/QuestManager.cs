using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager instance;

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
    }

    private void Awake() 
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
