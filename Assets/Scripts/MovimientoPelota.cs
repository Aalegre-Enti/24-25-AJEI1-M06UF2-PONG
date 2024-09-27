using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    public float speed = 10;

    public SistemaPuntuacion puntuacion;

    float x = 0;
    float y = 0;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(x, y) * speed * Time.deltaTime;
        transform.position = transform.position + dir;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.gameObject.tag);
        if (collision.gameObject.tag == "Horizontal")
        {
            y = y * -1;
        }
        if (collision.gameObject.tag == "Vertical")
        {
            x = x * -1;
        }
        if (collision.gameObject.tag == "Porteria_A")
        {
            puntuacion.puntuacionB = puntuacion.puntuacionB + 1;
            //puntuacion.puntuacionB += 1;
            //puntuacion.puntuacionB++;
            Spawn();
        }
        if (collision.gameObject.tag == "Porteria_B")
        {
            puntuacion.puntuacionA = puntuacion.puntuacionA + 1;
            Spawn();
        }
    }

    void Spawn()
    {
        transform.position = new Vector3(0, 0);
        x = Random.Range(-1.0f, 1.0f);
        if (x > 0)
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        y = Random.Range(-1.0f, 1.0f);
    }
}
