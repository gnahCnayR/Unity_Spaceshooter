using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreCoutner : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "HeroLaser")
        {
            Destroy(gameObject);
        }
    }
}
