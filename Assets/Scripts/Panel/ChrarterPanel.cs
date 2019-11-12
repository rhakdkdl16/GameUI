using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChrarterPanel : PanelManager
{
    [SerializeField] GameObject skillPanel;
    [SerializeField] GameObject settingPanelprefab;
    private void Start()
    {
        Open();
        LeftButtonSetTitle("설정");
        RightButtonSetTitle("스킬");
        Title("아이템");
    }

    public void OnClickRightButton()
    {
        Close();
        SkillPanel skillPanela = Instantiate(skillPanel, transform.parent).GetComponent<SkillPanel>();        
       
    }
    public void OnClickLeftButton()
    {
        Close();
        SettingPanel settingPanel = Instantiate(settingPanelprefab, transform.parent).GetComponent<SettingPanel>();
    }
}
