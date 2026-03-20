using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class IceIceBabey : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent Melt;
    bool hasCollided = false;
    public ZappedWater LinkedScript;
    void Start()
    {
        LinkedScript = FindObjectOfType<ZappedWater>();
        Melt.AddListener(LinkedScript.DeadOlaf);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GameObject Player = FindObjectOfType<PlayerController>().GameObject();
            if (Mathf.Abs(Player.transform.position.x - transform.position.x) + Mathf.Abs(Player.transform.position.y - transform.position.y) < 3)
            {
                Melted();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Wimdy();
        }
    }

    //Fuck Ice
    //Fuck Trump
    public void AddIce()
    {
        this.GetComponent<SpriteRenderer>().enabled = true;
    }

    public void Melted()
    {
        if (hasCollided)
        {
            Melt.Invoke();
        }
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            hasCollided = true;
        }
    }

    public void Wimdy()
    {
        GameObject Player = FindObjectOfType<PlayerController>().GameObject();
        //Shoutout to Alice for explaining this to me
        //I hate math
        //so much
        //"imaginary numbers" tf does that even mean?
        if (Mathf.Abs(Player.transform.position.x - transform.position.x) + Mathf.Abs(Player.transform.position.y - transform.position.y) < 3)
        {
            if (Mathf.Abs(Player.transform.position.x - transform.position.x) > Mathf.Abs(Player.transform.position.y - transform.position.y))
            {
                if (Player.transform.position.x < transform.position.x)
                {
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(5, 0), ForceMode2D.Impulse);
                }
                else
                {
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(-5, 0), ForceMode2D.Impulse);
                }
            }
            else
            {
                if (Player.transform.position.y < transform.position.y)
                {
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
                }
                else
                {
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -5), ForceMode2D.Impulse);
                }
            }
        }
    }
}
