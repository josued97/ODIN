using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    public int opcion1 =0;
    public int opcion2 =0;
    public int opcion3 =0;
    public GameObject objeto;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {

        }
    }

}
