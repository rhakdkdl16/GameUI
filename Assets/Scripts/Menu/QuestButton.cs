using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestButton : ButtonViewManager
{
    [SerializeField] GameObject questPrefab;

    private void Start()
    {

    }
    public void OnclickQuest()
    {
        if (!GameObject.FindGameObjectWithTag("PANEL"))
        {
            QuestPanel chrarter = Instantiate(questPrefab, transform.parent.parent).GetComponent<QuestPanel>();
        }
    }




}
