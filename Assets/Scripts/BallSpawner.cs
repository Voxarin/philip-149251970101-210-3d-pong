using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;
    public ShotDirection shotDirection;
    public float shotSpd;

    public void SpawnBall()
    {
        Rigidbody ballRig = Instantiate(ball, transform.position, Quaternion.identity).GetComponent<Rigidbody>();

        switch (shotDirection) 
        {
            case ShotDirection.NW:
                {
                    ballRig.AddForce(Quaternion.Euler(0, Random.Range(-22.5f, 22.5f), 0) * new Vector3(1,0,-1) * shotSpd, ForceMode.Impulse);
                    break;
                }
            case ShotDirection.NE:
                {
                    ballRig.AddForce(Quaternion.Euler(0, Random.Range(-22.5f, 22.5f), 0) * new Vector3(-1, 0, -1) * shotSpd, ForceMode.Impulse);
                    break;
                }
            case ShotDirection.SW:
                {
                    ballRig.AddForce(Quaternion.Euler(0, Random.Range(-22.5f, 22.5f), 0) * new Vector3(1, 0, 1) * shotSpd, ForceMode.Impulse);
                    break;
                }
            case ShotDirection.SE:
                {
                    ballRig.AddForce(Quaternion.Euler(0, Random.Range(-22.5f, 22.5f), 0) * new Vector3(-1, 0, 1) * shotSpd, ForceMode.Impulse);
                    break;
                }
        }
    }

    public enum ShotDirection
    {
        NW, NE, SW, SE
    }
}
