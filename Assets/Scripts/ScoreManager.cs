using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    internal int score;
    public int maxScore;
    public TextMeshProUGUI scoreCounter;
    public GameManager manager;
    public Rigidbody padStop;

    public string playerName;

    public void addScore()
    {
        score++;
        scoreCounter.text = score.ToString();
        if (score == maxScore)
        {
            manager.setDead(this);
            padStop.isKinematic = true;
            padStop.GetComponent<BoxCollider>().isTrigger = true;
            GetComponent<BoxCollider>().isTrigger = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        addScore();
        Destroy(other.gameObject);
        manager.ballCounter --;
    }

    private void Start()
    {
        manager.playerRegister(this);
    }
}
