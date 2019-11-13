using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed = 1000;
    public int str;
    Transform tr;
    private void Start()
    {
        tr = GetComponent<Transform>();
    }
    private void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 moveir = (Vector3.forward * v) + (Vector3.right * h);
        tr.Translate(moveir.normalized * speed * Time.deltaTime, Space.Self);
    }
}
