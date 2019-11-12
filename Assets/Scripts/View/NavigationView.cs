using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NavigationView : MonoBehaviour
{
    [SerializeField] Text titletext;

    public string Title
    {
        get
        {
            return titletext.text;
        }
        set
        {
            titletext.text = value;
        }
    }
}
