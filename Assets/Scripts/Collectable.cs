using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float num_collected;
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        num_collected += 1;
        
    }
}
