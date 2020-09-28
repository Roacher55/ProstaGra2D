using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wynik : MonoBehaviour
{
    // Start is called before the first frame update
    float wynik;
    public static string tekst;
    void Start()
    {
        wynik = 0;
        this.gameObject.GetComponent<TextMesh>().text = "Wynik: " + wynik;
    }

    // Update is called once per frame
    void Update()
    {
        wynik = wynik + 0.001f;
        this.gameObject.GetComponent<TextMesh>().text = "Wynik: " + wynik;
        tekst = textWynik();
    }

    public float ZwrocWynik()
    {
        return wynik;
    }

   public string textWynik()
    {
       return this.gameObject.GetComponent<TextMesh>().text = "Wynik: " + wynik;
    }
}
