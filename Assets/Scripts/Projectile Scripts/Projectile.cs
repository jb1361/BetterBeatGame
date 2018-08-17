using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {


    public GameObject projectile;
    public int velocity = 1;

    public enum AcceptedCollision{
        TOP,
        BOTTOM,
        FRONT,
        BACK,
        LEFT,
        RIGHT
    }
    public AcceptedCollision CollisionSide;

    // GameObject activeSide;

   // GameObject[] children = new GameObject[5];

    // Use this for initialization
    void Start () {
        //We iterate through the children and setup the child objects components propertys
        foreach (Transform child in projectile.transform)
        {
            // getChildren(child.gameObject);
            ChildColliderController childComponent = child.GetComponent<ChildColliderController>();
            childComponent.SetParentObject(projectile);
            if(child.gameObject.tag == "CUBE_" + CollisionSide.ToString()) childComponent.SetActive();
        }
        
	}
	
    void FixedUpdate()
    {
        projectile.transform.position += projectile.transform.forward * Time.deltaTime * velocity;
    }

    /*
    void getChildren(GameObject child)
    {
        for(int i = 0; i < children.Length; i++)
        {
            if (!children[i]) children[i] = child;
        }
    }
    */
    bool canBeDestroyed = true;

    public void CollisionDetected(ChildColliderController childScript)
    {
        if (childScript.gameObject.tag == "CUBE_" + CollisionSide.ToString() && canBeDestroyed) Destroy(this.gameObject);
        else canBeDestroyed = false; 
    }

}
