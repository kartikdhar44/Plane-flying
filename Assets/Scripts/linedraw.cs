using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*This Script was made for making a line using the mouse*/
public class linedraw : MonoBehaviour
{
     public GameObject line;
     GameObject currentline;
     LineRenderer LineRenderer;
     public List<Vector2> PPositions;
     

   
   
    

    // Update is called once per frame
    void Update()
    {
        
         LineCreator();
   
    }
   public void CreateLine()
    {
        currentline = Instantiate(line, Vector2.zero, Quaternion.identity);
        LineRenderer = currentline.GetComponent<LineRenderer>();
        PPositions.Clear();
        PPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        PPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        LineRenderer.SetPosition(0, PPositions[0]);
        LineRenderer.SetPosition(1, PPositions[1]);
        
    }
   public void UpdateLine(Vector2 newPPos)
    {
        PPositions.Add(newPPos);
        LineRenderer.positionCount++;
        LineRenderer.SetPosition(LineRenderer.positionCount - 1,newPPos);
        
    }
        void LineCreator()
        {
            if (Input.GetMouseButtonDown(0))
            {
                CreateLine();
            
            }
        if (Input.GetMouseButton(0))
        {

            Vector2 tempPpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector2.Distance(tempPpos, PPositions[PPositions.Count - 1]) > .1f)
            {
                UpdateLine(tempPpos);
            }
        }

    }
    
}
