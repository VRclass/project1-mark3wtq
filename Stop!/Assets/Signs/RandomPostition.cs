using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPostition : MonoBehaviour
{


    public GameObject prefab;

    // Instantiate the Prefab somewhere between -10.0 and 10.0 on the x-z plane
    void Start()
    {
        Vector3 position = new Vector3(Random.Range(-250.0f, 250.0f), 1.77f, Random.Range(-250.0f, 250.0f));
        Vector3 rotation = new Vector3(0f, Random.Range(-360.0f, 360.0f), 0f);
        Instantiate(prefab, position, Quaternion.identity);
        Instantiate(prefab, rotation, Quaternion.identity);
    }
}
