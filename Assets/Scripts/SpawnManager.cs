using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Ball Spawner
/// </summary>
public class SpawnManager : MonoBehaviour
{
    #region Spawner Variables
    [Header("Falling Objects")]
    [SerializeField] GameObject balls;
    [SerializeField] float spawnRangeZ = 24;
    [SerializeField] float spawnTime = 4;
    

    #endregion


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BallSpawnTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    #region Spawner Controls
    void BallSpawn()
    {
        Vector3 randomSpawnPos = new Vector3(0, 24, Random.Range(-spawnRangeZ, spawnRangeZ));

        Instantiate(balls, randomSpawnPos, balls.transform.rotation);
    }

    #region Spawn Timer
    IEnumerator BallSpawnTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            BallSpawn();
        }

    }
    #endregion

    #endregion
}
