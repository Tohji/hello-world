using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
    public CController getshittest;

    


    public void Start()
    {
        int testtest = 0;
        GameObject testspeicher = GameObject.FindWithTag("Controller");
        getshittest = testspeicher.GetComponent<CController>();
      //  GameObject gameControllerObject = GameObject.FindWithTag("GameController");
     //gameController = gameControllerObject.GetComponent<Gamecontroller>();

        testtest = getshittest.getInt();
        Debug.Log(testtest);
    } 

 



}
