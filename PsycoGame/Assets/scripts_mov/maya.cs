using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maya : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent guia;
    public Transform objetivo;
    void Start()
    {
        if (guia == null)
        {
            guia = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        guia.SetDestination(objetivo.position);
    }
}
