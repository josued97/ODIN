using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choque : MonoBehaviour
{
    [SerializeField] GameObject panelmsg;
    void Start()
    {
        GetComponent<Collider>().isTrigger = true;
        panelmsg.SetActive(false);

        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "player")
        {
            panelmsg.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "player")
        {
            panelmsg.SetActive(false);
        }
    }
}
