using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaser : MonoBehaviour
{
    public float movespeed = 3f;
    public Rigidbody rb;
    Player target;
    Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindObjectOfType<Player>();
        moveDirection = (target.transform.position - transform.position).normalized * movespeed;
        rb.velocity = new Vector3(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Hit");
            Destroy(gameObject);
        }
    }
}
