using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject[] weaponsPlacements;
    public GameObject laserPrefab = null;
    public GameObject misslePrefab = null;
    public GameObject shield = null;
    public bool isUsingShield = false;
    public Rigidbody rb;
    public Vector3 StartPosition;
    // Start is called before the first frame update
    void Start()
    {
        shield.SetActive(false);
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (GameObject weaponPlacement in weaponsPlacements)
            {
                Instantiate(laserPrefab, weaponPlacement.transform.position, weaponPlacement.transform.rotation);
            }
            
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            shield.SetActive(true);
            isUsingShield = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            shield.SetActive(false);
            isUsingShield = false;
        }
        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            foreach (GameObject weaponPlacement in weaponsPlacements)
            {
                Instantiate(misslePrefab, weaponPlacement.transform.position, weaponPlacement.transform.rotation);
            }
        }
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = StartPosition;
    }
}
