using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeBossMechanics : MonoBehaviour
{

    public float NextSpawnTime;
    public float spawnDelay = 3;

    public GameObject EnemySlime;
    public Transform Spawnpoint;
    public Vector3 Pos;
    public Quaternion Rot;
    

    void Update()
    {
        if (shouldSpawn())
        {
            spawn();
        }
    }

    private void spawn()
    {
        NextSpawnTime = Time.time + spawnDelay;

        Pos = Spawnpoint.position;
        Rot = Spawnpoint.rotation;
        GameObject enemy = Instantiate(EnemySlime, Pos, Rot) as GameObject;
    }

    private  bool shouldSpawn()
    {
        return Time.time > NextSpawnTime;
    }
}
