using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEdge : MonoBehaviour {

    public GameObject vert;
    
    Vector3 mousePos = new Vector3(0, 0, 0);

    // Use this for initialization

    public void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            createEdge(); 
        }
    }


    public void createEdge()
    {
        mousePos = Input.mousePosition;
        mousePos.z = 5;
        Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(vert, objectPos, spawnRotation);
        Debug.Log("erstellt");

    }
}
