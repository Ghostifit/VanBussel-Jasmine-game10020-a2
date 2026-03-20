using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;
using UnityEditor;
using Unity.VisualScripting;

public class Water : MonoBehaviour
{
    // Start is called before the first frame update
    float timeRemaining = 0;
    bool WaterOn = false;
    public UnityEvent OlafFrozen;
    public GameObject Ice;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().enabled = false;
            WaterOn = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //the cold never bothered me anyway...
            if (WaterOn)
            {
                GameObject Player = FindObjectOfType<PlayerController>().GameObject();
                if (Mathf.Abs(Player.transform.position.x - transform.position.x) + Mathf.Abs(Player.transform.position.y - transform.position.y) < 3)
                {
                    Frozen();
                }
            }
        }
    }
    public void ToggleWater()
    {
        //Debug.Log("ooo its wet");
        this.GetComponent<SpriteRenderer>().enabled = true;

        timeRemaining = 4;
        WaterOn = true;
    }

    public void Frozen()
    {
        OlafFrozen.Invoke();
        Instantiate(Ice, new Vector2(-4,0), Quaternion.Euler(0, 0, 0));
    }


}
