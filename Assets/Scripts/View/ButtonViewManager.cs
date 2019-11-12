using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonViewManager : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        animator.SetTrigger("on");
    }
    public void Off()
    {
        animator.SetTrigger("off");
    }
    public void Delete()
    {
        Destroy(gameObject);
    }
}
