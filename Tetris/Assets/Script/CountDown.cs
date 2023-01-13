using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDown : MonoBehaviour
{
    
    public float startingTime = 0;
    int number;

    [SerializeField] TextMeshPro countdownText;
    
   
    private void Update()
    {
        
        startingTime += 1 * Time.deltaTime;
        countdownText.text = startingTime.ToString("0");

    }
}
