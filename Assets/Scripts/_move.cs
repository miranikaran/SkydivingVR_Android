﻿using UnityEngine;
using System.Collections;

public class _move : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position +=  new Vector3(0.0f, 0.0f, -1f);

	}
}
