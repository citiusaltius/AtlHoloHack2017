using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugInfo : MonoBehaviour {

    public TextMesh DebugtetMesh;
    public GameObject debugObject;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        DebugtetMesh.text = debugObject.transform.position.ToString() + Camera.main.transform.position;
		
	}
}
