using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectaJugador : MonoBehaviour
{
    GameObject comEnemigo; //Enlace de comunicacion del area con el enemigo
    LogicaEnemigo2 logica;


    // Start is called before the first frame update
    void Start()
    {
        comEnemigo = GameObject.Find("Enemigo");
        logica = comEnemigo.GetComponent<LogicaEnemigo2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Jugador"))
        {
            logica.jugadorIsDetected = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Equals("Jugador"))
        {
            logica.jugadorIsDetected = false;
        }
    }
}
