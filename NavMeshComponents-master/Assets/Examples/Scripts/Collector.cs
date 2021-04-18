using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    public Text scoreText;
    
    private int count = 0;
    
    void Update()
    {
        scoreText.text = "Score: " + count;
    }    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count += 10;
            
        }
    }
}
