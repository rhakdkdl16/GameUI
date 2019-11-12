using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterButton : ButtonViewManager
{
   [SerializeField] GameObject chararcterPrefab;
  
    private void Start()
    {

    }
    public void OnclickItem()
    {
        if (!GameObject.FindGameObjectWithTag("PANEL"))
        {
            ChrarterPanel chrarter = Instantiate(chararcterPrefab, transform.parent.parent).GetComponent<ChrarterPanel>();
        }
        else
        {
            PanelManager game = GameObject.FindGameObjectWithTag("PANEL").GetComponent<PanelManager>();
            game.Close();
            ChrarterPanel chrarter = Instantiate(chararcterPrefab, transform.parent.parent).GetComponent<ChrarterPanel>();
        }
    }
   
  
   
   

}
