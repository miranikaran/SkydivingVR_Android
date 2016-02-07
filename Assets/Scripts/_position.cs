using UnityEngine;
using System.Collections;

public class _position : MonoBehaviour {

    public GameObject obj;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	void Update () {
        
           transform.position = obj.transform.position;
	}
}
