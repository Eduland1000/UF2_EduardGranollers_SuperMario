using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SriptDePrueba : MonoBehaviour
{

    public int vidasPersonaje = 5;

    public int vidasPersonaje2 = 3;

    public float numeroDecimal = 4.5f;

    public string nombrePersonaje = "Nombre de nuestro personaje";

    private bool interruptor = false;


    // Start is called before the first frame update
    void Start()
    {
        vidasPersonaje = 10;
        numeroDecimal = 7.5f;
        nombrePersonaje = "Mario";
        interruptor = true;

        int Suma = vidasPersonaje + vidasPersonaje2;
        Debug.Log(Suma);
        string sumaTextos = nombrePersonaje + "Super mario";
        Debug.Log(sumaTextos);

        Debug.Log(nombrePersonaje);
        Debug.Log(vidasPersonaje);
        Debug.Log(numeroDecimal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 