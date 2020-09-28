using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pomoc : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject meteores;
   
    Scene scene;
    void Start()
    {
        Application.targetFrameRate = 30;
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
        for (int i = 0; i < 5; i++)
        { 
             if(player.gameObject.GetComponent<PolygonCollider2D>().IsTouching(meteores.transform.GetChild(i).gameObject.GetComponent<PolygonCollider2D>()))
             {
                  Debug.Log("Dziala");
            
                  SceneManager.LoadScene(scene.name);
             }
    }
        }
}
