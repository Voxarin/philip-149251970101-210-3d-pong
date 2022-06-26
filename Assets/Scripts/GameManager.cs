using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public BallSpawner[] spawnerList;

    public float shotInterval;
    private float timer;
    internal int ballCounter = 0;
    Dictionary<ScoreManager, bool> deadPlayerList = new Dictionary<ScoreManager, bool>();

    public static string winnerName;

    void Update()
    {
        timer += Time.deltaTime;
        if (ballCounter < 5)
        {
            if (timer > shotInterval)
            {
                int spawnPoint = Random.Range(0, spawnerList.Length-1);
                spawnerList[spawnPoint].SpawnBall();
                ballCounter++;
                timer -= shotInterval;
            }
        }
    }

    internal void playerRegister(ScoreManager player)
    {
        deadPlayerList.Add(player, false);
    }

    internal void setDead(ScoreManager deadPlayer)
    {
        deadPlayerList[deadPlayer] = true;
        Debug.Log(deadPlayerList.Count(x => x.Value));
        if (deadPlayerList.Count(x=>x.Value) == 3)
        {
            winnerName = deadPlayerList.First(x => !x.Value).Key.playerName;
            SceneManager.LoadScene("Game over");
        }
    }
}
