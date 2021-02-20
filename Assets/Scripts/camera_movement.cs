using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    public GameObject playerObject;

    void SetPosition()
    {
        transform.position = new Vector3(playerObject.transform.position.x,0,-10);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        SetPosition();
    }
}
