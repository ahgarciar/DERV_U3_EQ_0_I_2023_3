using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_MoveTowards : MonoBehaviour
{
    [SerializeField] GameObject obj_a_mirar;
    [SerializeField] float velocidad;

    // Start is called before the first frame update
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origen = transform.position; //ilustrativo
        Vector3 destino = obj_a_mirar.transform.position;

        transform.position =
            Vector3.MoveTowards(origen, destino,
                velocidad * Time.deltaTime);

    }
}
