using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPala : MonoBehaviour
{
    public float speed = 10;
    public bool jugadorA = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // = es para igualar/asignar un valor
        float vertical;
        float horizontal;

        // == es para preguntar 
        if (jugadorA == true)
        {
            //JUGADOR A
            vertical = Input.GetAxis("VerticalA");
            horizontal = Input.GetAxis("HorizontalA");
        }
        else
        {
            //JUGADOR B
            vertical = Input.GetAxis("VerticalB");
            horizontal = Input.GetAxis("HorizontalB");
        }

        Vector3 dir = new Vector3(horizontal, vertical) * speed * Time.deltaTime;

        transform.position = transform.position + dir;
    }
}
