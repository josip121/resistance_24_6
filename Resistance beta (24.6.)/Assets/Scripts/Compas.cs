﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compas : MonoBehaviour
{
    public Transform playerTransform;
    Vector3 dir;

private void Update()
    {
        dir.z = playerTransform.eulerAngles.y;
        transform.localEulerAngles = dir;

    }
  
}
