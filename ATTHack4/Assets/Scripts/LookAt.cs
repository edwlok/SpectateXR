﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("OVRCameraRig").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(camera);
    }
}
