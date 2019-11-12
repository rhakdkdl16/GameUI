using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingManager : ButtonViewManager
{
    [SerializeField] GameObject settingPrefab;

    private void Start()
    {

    }
    public void OnclickSetting()
    {
        if (!GameObject.FindGameObjectWithTag("PANEL"))
        {
            SettingPanel chrarter = Instantiate(settingPrefab, transform.parent.parent).GetComponent<SettingPanel>();
        }
    }
}
