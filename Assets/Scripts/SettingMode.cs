using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingMode : MonoBehaviour
{
    [SerializeField] GameObject charButton;
    [SerializeField] GameObject skillButton;
    [SerializeField] GameObject questButton;
    [SerializeField] GameObject settingButton;
    bool editMode = false;
   public void OnClick()
    {
        editMode = !editMode;
        if (editMode == true)
        {
            Instantiate(charButton, transform);
            Instantiate(skillButton, transform);
            Instantiate(questButton, transform);
            Instantiate(settingButton, transform);

             
        }
        else
        {

            ButtonViewManager[] buttonViewManager = gameObject.GetComponentsInChildren<ButtonViewManager>();
            for (int i = 0; i < buttonViewManager.Length;)
            {
                buttonViewManager[i].Off();
                i++;
            }
        }
    }
}
