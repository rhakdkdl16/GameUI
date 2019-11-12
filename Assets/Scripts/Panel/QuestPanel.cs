using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestPanel : PanelManager
{
    [SerializeField] GameObject skillPrefab;
    [SerializeField] GameObject settingPrefab;
    private void Start()
    {
        Open();
        LeftButtonSetTitle("스킬");
        RightButtonSetTitle("설정");
        Title("퀘스트");
    }
    public void OnclickLeftBT()
    {
        Close();
        SkillPanel skillPanel = Instantiate(skillPrefab, transform.parent).GetComponent<SkillPanel>();
        
    }
    public void OnclickRightBT()
    {
        Close();
        SettingPanel settingPanel = Instantiate(settingPrefab, transform.parent).GetComponent<SettingPanel>();
    }
}
