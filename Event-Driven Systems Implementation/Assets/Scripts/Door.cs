using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.U2D;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite Opened;
    public SpriteRenderer LightningSigil;
    public Sprite SigilOn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ItHasOpened()
    {
        this.GetComponent<SpriteRenderer>().sprite = Opened;
        LightningSigil.sprite = SigilOn;
    }
}
