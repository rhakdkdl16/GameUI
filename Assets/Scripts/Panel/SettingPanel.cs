using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPanel : PanelManager
{
    [SerializeField] GameObject questPrefab;
    [SerializeField] GameObject charPrefab;
    private void Start()
    {
        Open();
        LeftButtonSetTitle("퀘스트");
        RightButtonSetTitle("아이템");
        Title("설정");
    }
    public void OnclickLeftBT()
    {
        Close();
        SkillPanel skillPanel = Instantiate(questPrefab, transform.parent).GetComponent<SkillPanel>();

    }
    public void OnclickRightBT()
    {
        Close();
        ChrarterPanel chrarterPanel = Instantiate(charPrefab, transform.parent).GetComponent<ChrarterPanel>();
    }

}
