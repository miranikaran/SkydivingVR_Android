﻿using UnityEngine;
using System.Collections;

public class positionCam : MonoBehaviour {

    public GameObject go;
        // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = go.transform.position;
	}
}
