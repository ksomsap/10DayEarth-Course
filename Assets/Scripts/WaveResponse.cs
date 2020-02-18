using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveResponse : MonoBehaviour
{

    public GameObject enemy;
    public GameObject[] pointer;
    float count = 0f;
    public float waveTime;
    void Update()
    {
        if(SceneManagerScript.startGame)
        {
            GameObject randomPoint = pointer[Random.Range(0, pointer.Length)];
            count += Time.deltaTime;
            if (count > waveTime)
            {
                Instantiate(enemy, randomPoint.transform.position, Quaternion.identity);
                count = 0f;
            }
        }
    }
}
