using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    //cube that is going to be spawned
    [Header("Spawn Cube Object")]
    public GameObject spawnCube;
    //difficulty of the game
    [Header("Default Difficulty")]
    public float difficulty = 40f;
    //time for the next cube to be spawned
    float spawn;

    // Update is called once per frame
    void Update()
    {
        spawn += difficulty * Time.deltaTime;
        while (spawn > 0)
        {
            spawn -= 1;
            Vector3 v3Pos = transform.position + new Vector3(Random.value * 40f - 20f, 0, Random.value * 40f - 20f);
            Quaternion qRotation = Quaternion.Euler(0, Random.value * 360f, Random.value * 30f);
            GameObject createObject = Instantiate(spawnCube, v3Pos, qRotation);
        }
    }
}
