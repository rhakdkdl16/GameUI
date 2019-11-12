using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillButton : ButtonViewManager
{
    [SerializeField] GameObject skillPrefab;


    public void OnclickBT()
    {

        if (!GameObject.FindGameObjectWithTag("PANEL"))
        {
            SkillPanel skillPanel = Instantiate(skillPrefab, transform.parent.parent).GetComponent<SkillPanel>();
        }
    }  
}
