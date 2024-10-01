using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPalaIA : MonoBehaviour
{
    public float speed = 10;

    public Transform pelota;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0;
        float vertical = 0;

        if (pelota.position.y > transform.position.y)
        {
            vertical = 1;
        }
        if (pelota.position.y < transform.position.y)
        {
            vertical = -1;
        }

        Vector3 dir = new Vector3(horizontal, vertical) * speed * Time.deltaTime;

        transform.position = transform.position + dir;
    }
}
