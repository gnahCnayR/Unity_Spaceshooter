using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class HomingLaser : MonoBehaviour
{
    public Transform Target;
    public Rigidbody Enemyrb;

    public float turn;
    public float laserVelocity;

    private void FixedUpdate()
    {
        Enemyrb.velocity = transform.forward * laserVelocity;

        var laserTargetRotation = Quaternion.LookRotation(Target.position - transform.position);
        Enemyrb.MoveRotation(Quaternion.RotateTowards(transform.rotation, laserTargetRotation, turn));
        Destroy(gameObject, 4f);
    }

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
