using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float speed;
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        float moveY = Input.GetAxis("Vertical");
        float moveX = Input.GetAxis("Horizontal");
        if(moveX > 0)
        {
            //transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 0, 0);
            transform.RotateAround(target.transform.position, target.transform.right, speed * Time.deltaTime * 5);
        }

        if (moveY < 0)
        {
            transform.RotateAround(target.transform.position, target.transform.forward, speed * Time.deltaTime * 5);
        }

        if (moveX < 0)
        {
            //transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed, 0, 0);
            transform.RotateAround(target.transform.position, target.transform.right * -1, speed * Time.deltaTime * 5);
        }
        if (moveY > 0)
        {
            transform.RotateAround(target.transform.position, target.transform.forward * -1, speed * Time.deltaTime * 5);
        }

    }
}
