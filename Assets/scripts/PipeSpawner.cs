using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-0.157f, 1.084f), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }   

        timer += Time.deltaTime;
    }
}
