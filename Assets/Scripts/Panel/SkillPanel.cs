using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillPanel : PanelManager
{
    [SerializeField] GameObject charPrefab;
    [SerializeField] GameObject questPrefab;
    private void Start()
    {
        Open();
        LeftButtonSetTitle("아아템");
        RightButtonSetTitle("퀘스트");
        Title("스킬");
    }
    public void OnclickLeftBT()
    {
        Close();
        ChrarterPanel chrarterPanelManager = Instantiate(charPrefab, transform.parent).GetComponent<ChrarterPanel>();
      
    }
    public void OnclickRightBT()
    {
        QuestPanel questPanel = Instantiate(questPrefab, transform.parent).GetComponent<QuestPanel>();
        Close();
    }
  
}
