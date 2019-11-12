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
        else
        {
            PanelManager game = GameObject.FindGameObjectWithTag("PANEL").GetComponent<PanelManager>();
            game.Close();
            SkillPanel skillPanel = Instantiate(skillPrefab, transform.parent.parent).GetComponent<SkillPanel>();
        }
      }  
}
