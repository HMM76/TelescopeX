using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamZoom : MonoBehaviour
{
    public Camera camera;
    private float ZoomTarget;
    private float ZoomFactor = 30;
    private float ZoomLerpSpeed = 10; 
    void Start()
    {
        //camera = Camera.main;
        ZoomTarget = camera.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        float ScrollData = Input.GetAxis("Mouse ScrollWheel");

        ZoomTarget -= ScrollData * ZoomFactor;
        ZoomTarget = Mathf.Clamp(ZoomTarget, 15f, 180f);
        camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, ZoomTarget, Time.deltaTime * ZoomLerpSpeed);
    }
}
