using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemList : MonoBehaviour
{
    Sprite[] items;
    public GameObject item;
    
    private void Start()
    {
        items = Resources.LoadAll<Sprite>("Item");
        for(int i = 0; i < items.Length;)
        {
            Item Itema = Instantiate(item, transform).GetComponent<Item>();
            Image img =   Itema.GetComponent<Image>();
            img.sprite = items[i];
            i++;
        }
    }

}
