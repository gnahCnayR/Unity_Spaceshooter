using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerLose : MonoBehaviour
{
    private int Player1Score = 3;
    public GameObject Player1Text;
    public GameObject Player;
    public GameObject LoserText;
    
    void Start()
    {
        LoserText.SetActive(false);
    }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Player.GetComponent<Player>().Reset();
            Player1Score--;
            Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        }
        if (Player1Score == 0)
        {
            LoserText.SetActive(true);
        }
    }
}
            
