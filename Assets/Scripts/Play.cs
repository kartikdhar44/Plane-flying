using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*This Script was made for moving the Plane*/
public class Play : MonoBehaviour
{
    linedraw ldi;


  
    public float speed = 0.5f;
    float fraction = 0;
    int indexNum = 0;
     void Start()
    {
        ldi = GameObject.FindGameObjectWithTag("GameController").GetComponent<linedraw>();
       
     }
    void Update()
    {
        if (fraction < 1)
        {
            fraction += Time.deltaTime * speed;
            gameObject.transform.position = Vector2.Lerp(ldi.PPositions[indexNum], ldi.PPositions[indexNum + 1], fraction);
            indexNum += 1;
        }
        else
        {
            fraction = 0.1f;
        }
    }

    
        
}
