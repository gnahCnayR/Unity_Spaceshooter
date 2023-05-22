using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int totalScore = 0;
    public GameObject ScoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            totalScore += 1000;
            ScoreDisplay.GetComponent<TextMeshProUGUI>().text = totalScore.ToString();
        }
    }
}
