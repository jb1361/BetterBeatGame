using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {


    public GameObject projectile;
    public int velocity = 1;

    public enum AcceptedCollision{
        TOP,
        FRONT,
        BOTTOM,
        LEFT,
        RIGHT
    }
    public AcceptedCollision CollisionSide;

    GameObject activeSide;

    GameObject[] children = new GameObject[5];

    // Use this for initialization
    void Start () {
        foreach (Transform child in projectile.transform)
        {         
            getChildren(child.gameObject);
        }
        
	}
	
    void FixedUpdate()
    {
        projectile.transform.position += projectile.transform.forward * Time.deltaTime * velocity;
    }

    void getChildren(GameObject child)
    {
        for(int i = 0; i < children.Length; i++)
        {
            if (!children[i]) children[i] = child;
        }
    }

    public void CollisionDetected(ChildColliderController childScript)
    {
        if (childScript.gameObject.tag == "CUBE_" + CollisionSide.ToString())
        {
            Debug.Log("right side");
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("wrong side");          
        }
    }

}
