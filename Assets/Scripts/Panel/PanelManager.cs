using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public Text title;
    public Text rightbutton;
    public Text leftbutton;

    Animator animator;

  

    protected void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void Open()
    {
        animator.SetTrigger("open");
    }
    public void Close()
    {
        animator.SetTrigger("close");
    }
   
    public void DeletePanel()
    {
        Destroy(gameObject);
    }

    public string Title(string titlee)
    {
       title.text = titlee;
        return title.text;
    }
    public string RightButtonSetTitle(string title)
    {
        rightbutton.text = title;
        return rightbutton.text;
    }
    public string LeftButtonSetTitle(string title)
    {
        leftbutton.text = title;
        return leftbutton.text;
    }
    //public void SetOnClickAction(UnityAction action)
    //{
    //    GetComponent<Button>().onClick.AddListener(action);
    //}

    public void SetOnClickAction(UnityAction action)
    {
        GetComponent<Button>().onClick.AddListener(action);
    }
}
