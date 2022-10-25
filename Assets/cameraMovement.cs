using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    [SerializeField]
    private Joystick joystick;

    [SerializeField]
    private float followSpeed;

    private void UpdateCameraPosition()
    {
        Vector3 positonUpdate = new Vector3(player.position.x, player.position.y, -10f);

        transform.position = Vector3.Slerp(transform.position, positonUpdate, followSpeed * Time.deltaTime);
    }

    private void Update()
    {
        UpdateCameraPosition();    
    }
}
