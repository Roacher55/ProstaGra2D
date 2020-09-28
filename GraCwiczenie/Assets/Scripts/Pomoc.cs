using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pomoc : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject meteores;
    public GameObject poziom;
    int hardLevel= 1;
    public int scoreNextLevel = 3;
    public int plusScoreNextLevel = 3;
    public float plusSpeed = 0.01f;
    Meteor[] meteor = new Meteor[5];

    public static string tekst;

  //  Scene scene;
    
    void Start()
    {
       
        
        Application.targetFrameRate = 30;
     //   scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {


        GameObject objectWynik = GameObject.Find("Wynik");
        Wynik wynik = objectWynik.GetComponent<Wynik>();

        if(wynik.ZwrocWynik()> scoreNextLevel)
        {
            scoreNextLevel = scoreNextLevel + plusScoreNextLevel;
            poziom.GetComponent<TextMesh>().text = "Poziom: " + scoreNextLevel;
            GameObject objectMeteores = GameObject.Find("Meteores");
            for (int i= 0; i<5;i++)
            {
                meteor[i] = objectMeteores.transform.GetChild(i).GetComponent<Meteor>();
                meteor[i].speed = meteor[i].speed - plusSpeed;
            }
        }

        if(wynik)

      

        for (int i = 0; i < 5; i++)
        { 
             if(player.gameObject.GetComponent<PolygonCollider2D>().IsTouching(meteores.transform.GetChild(i).gameObject.GetComponent<PolygonCollider2D>()))
             {

                    tekst = textLevel();

                    SceneManager.LoadScene("Koniec");
             }
    }
        }

   public string textLevel()
    {
        
        return poziom.GetComponent<TextMesh>().text = "Poziom: " + scoreNextLevel;
    }
}
