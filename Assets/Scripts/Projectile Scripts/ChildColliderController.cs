using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildColliderController : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.gameObject.tag == "weapon") transform.parent.GetComponent<Projectile>().CollisionDetected(this);
    }
}
