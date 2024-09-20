using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteMovimiento : MonoBehaviour
{
    public float limiteYpositivo;
    public float limiteYnegativo;
    public float limiteXpositivo;
    public float limiteXnegativo;
    void Update()
    {
        //if es una pregunta,
        //entre los () ponemos la pregunta,
        //entre los {} ponemos qué ejecutamos si la pregunta da verdadero
        if (transform.position.y > limiteYpositivo)
        {
            transform.position = new Vector3(transform.position.x, limiteYpositivo);
        }
        if (transform.position.y < limiteYnegativo)
        {
            transform.position = new Vector3(transform.position.x, limiteYnegativo);
        }
        if (transform.position.x > limiteXpositivo)
        {
            transform.position = new Vector3(limiteXpositivo, transform.position.y);
        }
        if (transform.position.x < limiteXnegativo)
        {
            transform.position = new Vector3(limiteXnegativo, transform.position.y);
        }
    }
}
