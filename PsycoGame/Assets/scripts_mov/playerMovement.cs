using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //Variables
    public float speed = 5;
    public float sensivility = 3;
    public Camera mainCam;
    public float limitMax = 90;
    public float limitMin = -60;

    //Se llama el script playermotor
    PlayerMotor motor;

    float limitRotation;

    // Start is called before the first frame update
    void Start()
    {
        //Se inicializa el playermotor 
        motor = GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        //Variables para tomar los botones y el mouse
        float zMove = Input.GetAxisRaw("Vertical");
        float xMove = Input.GetAxisRaw("Horizontal");
        float yRot = Input.GetAxisRaw("Mouse X");
        float xRot = Input.GetAxisRaw("Mouse Y");

        //Operaciones para realizar el movimento del player
        Vector3 directionZ = transform.forward * zMove;
        Vector3 directionX = transform.right * xMove;

        //Velocidad de movimiento del player
        Vector3 velocity = (directionZ + directionX).normalized * speed;

        //Se llama la funcion Movement del Script PlayerMotor
        motor.Movement(velocity);

        //Rotacion de la camara 
        Vector3 rotation = new Vector3(0, yRot, 0) * sensivility;

        //Se llama la funcion Rotation del Script PlayerMotor
        motor.Rotation(rotation);
        //Variable para la rotacion de la camara
        float camRot = xRot * sensivility;
         limitRotation -= camRot;

        limitRotation = Mathf.Clamp(limitRotation, limitMin, limitMax);

        //Movimiento de la camara con el mouse
        mainCam.transform.localEulerAngles = new Vector3(limitRotation, 0, 0);


    }
}
