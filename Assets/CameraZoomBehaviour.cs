using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CameraZoomBehaviour : MonoBehaviour
{
    private Camera _camera;
    [SerializeField]
    private Vector2 _referenceAspectRatio;
    private Vector3 _startPos;
    private float _refRatio;
    [SerializeField]
    private Vector3 _zoomScale = Vector3.one;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponent<Camera>();
        _refRatio = _referenceAspectRatio.x / _referenceAspectRatio.y;
        _startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Get the ratio of the reference screen to the current screen
        double ratio = _refRatio / _camera.aspect;
        ratio = Math.Round(ratio, 4);

        //Scale the starting position by the new ratio to get the new camera position
        //Scaling the new position by the zoom scale vector allows control over how much the camera zooms in
        Vector3 positionDifference = Vector3.Scale((_startPos * (float)ratio), _zoomScale);

        //Update camera position
        transform.position = positionDifference;
    }
}
