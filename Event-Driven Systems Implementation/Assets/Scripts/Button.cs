using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isOn;
    public UnityEvent ButtonPress;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            GameObject Player = FindObjectOfType<PlayerController>().GameObject();
            if (Mathf.Abs(Player.transform.position.x - transform.position.x) + Mathf.Abs(Player.transform.position.y - transform.position.y) < 3)
            {
                Pressed();
            }
        }
    }

    void Pressed()
    {
        ButtonPress.Invoke();
    }
}
