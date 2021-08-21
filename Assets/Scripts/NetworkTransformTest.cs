using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;
using System;

public class NetworkTransformTest : NetworkBehaviour
{
    void Update()
    {
        if (IsClient)
        {
            float theta = Time.frameCount / 10.0f;
            transform.position = new Vector3((float) Math.Cos(theta), 0.0f, (float)Math.Sin(theta));
        }
    }
}
