using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class createVert : MonoBehaviour {
    public GameObject vert;
    float dclick_threshold = 0.25f;
    double timerdclick = 0;
    Vector3 mousePos = new Vector3(0,0,0);

    
	
	// Update is called once per frame
	void Update () {
    if (Input.GetMouseButtonDown(0)) 
        {
            if ((Time.time - timerdclick) > dclick_threshold)
            {
                Debug.Log("single click");
                //call the SingleClick() function, not shown
            }
            else
            {
               Debug.Log("double click");
                //call the DoubleClick() function, not shown
                createKnoten();
            }
            timerdclick = Time.time;
        }
      
    }


    public void createKnoten()
    {
        mousePos = Input.mousePosition;
        mousePos.z = 5;
        Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(vert, objectPos, spawnRotation);
        Debug.Log("erstellt");
    }

   


}
