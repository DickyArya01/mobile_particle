using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Joystick joystick;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float turnAngle;

    private int rightScreen = Screen.width / 2;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MoveControlller();
        RotationController();
    }


    private void MoveControlller() 
    {

        Vector3 inpuHorizontal = transform.right * joystick.Horizontal * speed * Time.deltaTime;
        Vector3 inputVertical = transform.up * joystick.Vertical * speed * Time.deltaTime;

        transform.position += inpuHorizontal + inputVertical;

    }

    private void RotationController()
    {
        float angle = Mathf.Atan2(joystick.Horizontal, joystick.Vertical) * Mathf.Rad2Deg;


        transform.rotation = Quaternion.Euler(new Vector3(0, 0, transform.rotation.z - angle));

    }


}
