using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Koniec : MonoBehaviour
{
    public GameObject textEnd;
    // Start is called before the first frame update
    string tekst = "";
    void Start()
    {
        Application.targetFrameRate = 30;

        tekst = "Koniec gry \n" + Pomoc.tekst  + "\n" + Wynik.tekst + "\n" + "Kliknij Spacje \naby wznowić";
    }

    // Update is called once per frame
    void Update()
    {
        textEnd.GetComponent<TextMesh>().text = tekst;
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Poziom1");
        }

    }
}
