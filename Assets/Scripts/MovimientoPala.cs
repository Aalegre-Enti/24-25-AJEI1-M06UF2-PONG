using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPala : MonoBehaviour
{
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 dir = new Vector3(horizontal, vertical) * speed * Time.deltaTime;

        transform.position = transform.position + dir;
    }
}
