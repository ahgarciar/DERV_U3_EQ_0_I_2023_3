using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzaProyectil : MonoBehaviour
{
    [SerializeField] GameObject objProyectil;
    [SerializeField] GameObject ubiLanzamiento;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject obj = Instantiate(objProyectil, ubiLanzamiento.transform.position,
                ubiLanzamiento.transform.rotation);

            Destroy(obj, 1);

        }
    }
}
