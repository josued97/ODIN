using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private Vector3 velocity = Vector3.zero;
    private Vector3 rotation = Vector3.zero;

    public Rigidbody rb;

    public void Movement(Vector3 _velocity)
    {
        velocity = _velocity;
    }
    public void Rotation(Vector3 _rotation)
    {
        rotation = _rotation;
    }
    private void FixedUpdate()
    {
        MovimientoMejorado();
        RotacionMejorada();
    }

    void MovimientoMejorado()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

    }

    void RotacionMejorada()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
    }
}
