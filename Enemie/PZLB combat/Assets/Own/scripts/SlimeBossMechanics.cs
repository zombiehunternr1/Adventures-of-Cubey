using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float nextSpawnTime;

    private GameObject slimeMob;

    [SerializeField]
    private float spawnDelay = 3;

    private void Awake()
    {
        var slime = Resources.Load("Assets / Own / Char / Enemy(slime).prefab");
        slimeMob = slime as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldSpawn())
        {
            spawn();
        }
    }

    private void spawn()
    {
        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(slimeMob);

    }

    private bool shouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }
}
