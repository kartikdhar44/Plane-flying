using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*This Script was made for disabling the linedraw script when the mouse hovers over the Playbutton and Instantiating the gameobject at the time of clicking*/
public class PlayDebug : MonoBehaviour
{
    [SerializeField]GameObject Plane;
    
    private void OnMouseEnter()
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<linedraw>().enabled = false;
        
    }
    private void OnMouseOver()
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<linedraw>().enabled = false;
        
    }
    private void OnMouseExit()
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<linedraw>().enabled = true;
    }
    private void OnMouseDown()
    {
        Instantiate(Plane, Vector2.zero, Quaternion.identity);
    }

}
