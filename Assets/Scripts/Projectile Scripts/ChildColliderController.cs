using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildColliderController : MonoBehaviour {

   // GameObject parentObject;
    Projectile parentComponent;

    //Sets parent object and parent component
    public void SetParentObject(GameObject _parent)
    {
       // parentObject = _parent;
        parentComponent = _parent.GetComponent<Projectile>();
    }
    public void SetActive()
    {
        foreach (Transform child in gameObject.transform)
        {
            if (child.gameObject.tag == "CUBE_MESH") child.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }

    void OnCollisionEnter(Collision collision)
    {
        //We check to make sure only a weapon can destroy the projectile
        if (collision.transform.gameObject.tag == "weapon") parentComponent.CollisionDetected(this);      
    }

    void Start()
    {
        Physics.IgnoreLayerCollision(8, 10, true);
    }
}
