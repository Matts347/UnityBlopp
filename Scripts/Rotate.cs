﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float rotateInterval;

    void Update () {
        transform.Rotate (new Vector3(0.0f, 0.0f, rotateInterval)*Time.deltaTime);
	}
}
