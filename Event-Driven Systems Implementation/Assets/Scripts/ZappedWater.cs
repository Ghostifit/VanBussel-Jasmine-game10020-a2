using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ZappedWater : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent OpenTheDoor;
    public Sprite Zapped;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GameObject Player = FindObjectOfType<PlayerController>().GameObject();
            if (Mathf.Abs(Player.transform.position.x - transform.position.x) + Mathf.Abs(Player.transform.position.y - transform.position.y) < 3)
            {
                Electrified();
            }
        }
    }

    public void DeadOlaf()
    {
        this.GetComponent<SpriteRenderer>().enabled = true;
    }

    public void Electrified()
    {
        this.GetComponent<SpriteRenderer>().color = Color.cyan;
        OpenTheDoor.Invoke();
        this.GetComponent <SpriteRenderer>().sprite = Zapped;
    }
}
