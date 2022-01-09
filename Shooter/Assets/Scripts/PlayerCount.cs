using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(PlayerMotor))]
public class PlayerCount : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float lookSpeed = 7f;

    private PlayerMotor motor;

    void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }

    void Update()
    {
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        Vector3 movHor = transform.right * xMov;
        Vector3 movVer = transform.forward * zMov;

        Vector3 velocity = (movHor + movVer).normalized * speed;

        motor.Move(velocity);

        float yRot = Input.GetAxisRaw("Mouse X");
        Vector3 rotation = new Vector3(0f, yRot, 0f) * lookSpeed;

        motor.Rotate(rotation);



        float xRot = Input.GetAxisRaw("Mouse Y");
        Vector3 camRotation = new Vector3(xRot, 0f, 0f) * lookSpeed;

        motor.RotateCam(camRotation);

    }
}
