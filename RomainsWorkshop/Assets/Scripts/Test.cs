using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float timing = 1f;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnStuff", 0f, timing);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnStuff()
    {
        Instantiate(cube);
    }
}
