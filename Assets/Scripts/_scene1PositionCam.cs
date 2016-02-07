using UnityEngine;
using System.Collections;

public class _scene1PositionCam : MonoBehaviour {
    public GameObject obj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = obj.transform.position + new Vector3(0.0f, 1.0f, 0.0f);
	}
}
