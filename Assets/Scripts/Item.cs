using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item  : MonoBehaviour
{
   public  Sprite itemImage;
   public int ItemStr;
   public int ItemPrice;
   public RectTransform equipSword;
   public RectTransform content;
   bool equip = false;

    public void OnClickEquipItem()
    {
        if (equipSword.childCount < 1)
        {
            RectTransform item = Instantiate(gameObject, equipSword).GetComponent<RectTransform>();

            item.anchorMin = new Vector2(0, 0);
            item.anchorMax = new Vector2(1, 1);
            Destroy(gameObject);
          
        }
        else 
        {
            RectTransform[] obj = equipSword.GetComponentsInChildren<RectTransform>();
            obj[1].SetParent(content);
            
        }
    }
}


