using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_Distance : MonoBehaviour
{
    [SerializeField] GameObject obj_a_mirar; //INSPECTOR...

    // Start is called before the first frame update
    void Start()
    {
        obj_a_mirar = GameObject.Find("Jugador");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origen = transform.position; 
        Vector3 destino = obj_a_mirar.transform.position;

        float distancia = Vector3.Distance(origen, destino);
        Debug.Log(distancia);


    }
}
