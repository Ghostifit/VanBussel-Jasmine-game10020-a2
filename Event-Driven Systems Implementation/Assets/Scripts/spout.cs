using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class spout : MonoBehaviour
{
    public UnityEvent toggleWater;
    public void ToggleSpout()
    {
        //Debug.Log("test123");
        toggleWater.Invoke();
    }
}
