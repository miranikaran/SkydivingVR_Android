using UnityEngine;
using System.Collections;

public class Position : MonoBehaviour {

    public GameObject obj;
    private int triggerCount = 0;
    public Cardboard cardboard;
    public Rigidbody rb;
    public GameObject ground;
    private bool hasJumped = false;
    private bool parachuteOpen = false;
    
	// Use this for initialization
	void Start () {
        
	}
    
	// Update is called once per frame
	void Update () {
        if(cardboard.Triggered)
            triggerCount++;
        if (triggerCount == 0)
          transform.position = obj.transform.position;
        if(triggerCount == 1 && !hasJumped)
        {
            hasJumped = true;
            transform.position = obj.transform.position + new Vector3(0.0f, 0.0f, 1f);
            
            parachuteOpen = true;
        }
        if(triggerCount == 2)
        {
            rb.AddForce(0.0f, 10f, 0.0f);
        }
        if (rb.transform.position.y - ground.transform.position.y <= 50)
            rb.transform.position = new Vector3(1332f, 141.4f, 1063.8f);


            
	}
}
