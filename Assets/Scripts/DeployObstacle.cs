using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployObstacle : MonoBehaviour
{
    public GameObject[] obstacles;

    private float respawnTime = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        obstacles = GameObject.FindGameObjectsWithTag("Respawn");
        StartCoroutine(enemyWave());
    }

    private void spawnObstacle()
    {
        int whichObstacle = Random.Range(0, obstacles.Length);
        int whereObstacle = Random.Range(-8, 8);

        GameObject obstacle = Instantiate(obstacles[whichObstacle]) as GameObject;
        obstacle.transform.position = new Vector3(whereObstacle, -0.008765578f, 165f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator enemyWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnObstacle();
        }
    }
}
