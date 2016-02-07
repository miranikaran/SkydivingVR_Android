using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour {
    public Cardboard c;
	// Use this for initialization
	void Start () {
	
	}
	public void change()
    {
//      if(c.Triggered)
        Application.LoadLevel("High Resolution Terrain Scene");
    }
	// Update is called once per frame
	void Update () {
	
	}
}
