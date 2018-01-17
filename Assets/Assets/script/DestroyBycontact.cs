using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBycontact : MonoBehaviour {
    public GameObject asteroidExplosion;
    public GameObject playerExplosion;
    public int scoreValue;
    private Gamecontroller gameController;
    public int hitPoints;

    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<Gamecontroller>();

        }
        if(gameController == null)
        {
            Debug.Log("Nicht da 'Gamecontroller'");
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag =="Boundary")
        {
            return;
        }
                
            
        
        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            gameController.GameOver();
        }
        if (hitPoints == 0)
        {
        Instantiate(asteroidExplosion, transform.position, transform.rotation);
        gameController.AddScore(scoreValue);
        Destroy(gameObject);
            
        }
        else
        {
            hitPoints = hitPoints - 1;
        }
        Destroy(other.gameObject);

    }
}
