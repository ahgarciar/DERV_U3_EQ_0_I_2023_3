using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEnemigo2 : MonoBehaviour
{
    [SerializeField] GameObject obj_a_mirar;
    [SerializeField] float velocidad;

    public bool jugadorIsDetected;

    // Start is called before the first frame update
    void Start()
    {
        obj_a_mirar = GameObject.Find("Jugador");
        jugadorIsDetected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (jugadorIsDetected)
        {

            //Coordenadas de los Gameobjects
            Vector3 origen = transform.position;
            Vector3 destino = obj_a_mirar.transform.position;

            //Distancia
            float distancia = Vector3.Distance(origen, destino);
            Debug.Log(distancia);

            //LookAT
            transform.LookAt(destino);

            if (distancia > 1.5)
            {
                //MoveTowards
                transform.position =
                    Vector3.MoveTowards(origen, destino,
                        velocidad * Time.deltaTime);
            }
        }
    }

    }
