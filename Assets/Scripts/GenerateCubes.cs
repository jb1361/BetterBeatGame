using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCubes : MonoBehaviour {

    public GameObject projectile;
    Vector3 spawnVector;
    int timer = 0;
	// Use this for initialization
	void Start () {
        spawnVector = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        timer--;
        if (timer < 0)
        {
            createProjectile();         
            timer = Random.Range(50,250);
        }
	}

    void createProjectile()
    {
        GameObject clone = Instantiate(projectile, spawnVector, Quaternion.identity) as GameObject;
        Projectile comp = clone.GetComponent<Projectile>();
        comp.velocity = 5;
        comp.projectile = clone;
        int side = Random.Range(0, 2);

        switch (side)
        {
            case 0:
                comp.CollisionSide = Projectile.AcceptedCollision.FRONT;
                break;
            case 1:
                comp.CollisionSide = Projectile.AcceptedCollision.LEFT;
                break;
            case 2:
                comp.CollisionSide = Projectile.AcceptedCollision.RIGHT;                
                break;
            case 3:
                comp.CollisionSide = Projectile.AcceptedCollision.TOP;
                break;
            case 4:                
                comp.CollisionSide = Projectile.AcceptedCollision.BACK;
                break;
            case 5:                
                comp.CollisionSide = Projectile.AcceptedCollision.BOTTOM;
                break;
            default:
                comp.CollisionSide = Projectile.AcceptedCollision.FRONT;

                break;
        }        
    }


}
