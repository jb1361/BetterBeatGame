using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchDehCube : MonoBehaviour {

    public GameObject _cube;
    public int velocity = 1;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        _cube.transform.position += _cube.transform.forward * Time.deltaTime * velocity;
    }
}
