using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public float speed;
    public float maxspeed;
    public GameObject referencia;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorinzontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if(rb.velocity.magnitude > maxspeed)
        {
            rb.velocity = rb.velocity.normalized * maxspeed;

        }

        rb.AddForce(moveVertical * referencia.transform.forward * speed);
        rb.AddForce(moveHorinzontal * referencia.transform.right * speed);
        
    }
}
