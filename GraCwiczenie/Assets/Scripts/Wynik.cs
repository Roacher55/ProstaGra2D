using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wynik : MonoBehaviour
{
    // Start is called before the first frame update
    float wynik;
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
    }
}
