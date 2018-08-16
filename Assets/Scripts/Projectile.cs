using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {


    public GameObject _cube;
    public int velocity = 1;
    // Use this for initialization
    void Start () {
		
	}
	
    void FixedUpdate()
    {
        _cube.transform.position += _cube.transform.forward * Time.deltaTime * velocity;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "weapon") Destroy(this.gameObject);
    }

   
}
