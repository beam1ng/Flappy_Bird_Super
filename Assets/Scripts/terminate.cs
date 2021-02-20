using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terminate : MonoBehaviour
{
    public GameObject playerObject;

    float offset;

    private void Start()
    {
        offset = transform.position.x - playerObject.gameObject.transform.position.x;
    }

    void SetPosition()
    {
        transform.position = new Vector3(playerObject.transform.position.x+offset, 0, 0);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        SetPosition();
    }

    private void OnTriggerEnter(Collider other)
    {
        //other.transform.parent.gameObject.SetActive(false);
        Destroy(other.gameObject);
    }
}
