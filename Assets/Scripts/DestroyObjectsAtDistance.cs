using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectsAtDistance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origen = transform.position;
        Vector3 direccion = transform.forward;
        float largoRayo = 5;

        RaycastHit hit; //almacena la informacion de la colision de RayCast

        bool rayoGolpeaObjeto = Physics.Raycast(origen, direccion,
            out hit, largoRayo);

        if (rayoGolpeaObjeto)
        {
            Debug.Log("El rayo impacto!");
            Debug.DrawRay(origen, direccion * hit.distance, Color.red);

            Destroy(hit.collider.gameObject);
        }
        else
        {
            Debug.DrawRay(origen, direccion * largoRayo, Color.blue);
        }
    }
}
