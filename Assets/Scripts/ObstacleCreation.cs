using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PipePair"))
        {
            GameObject tmp = other.gameObject.transform.parent.gameObject;
            GameObject go = Instantiate(other.gameObject, new Vector3(transform.position.x + 3, Random.Range(-4.5f, 4.5f), 0), new Quaternion(0, 0, 0, 0));
            go.transform.parent = tmp.transform;
            go.transform.name = other.gameObject.transform.name;
        }
    }
}
