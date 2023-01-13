using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public int x, y;
    public bool objectTrigger;
    public static DestroyObject Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
            for (int i = 0; i < x; i++)
            {
                
            }
        
    }
}
