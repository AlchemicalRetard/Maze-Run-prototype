using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject player;
    private Vector3 distance;
    void Start()
    {
        distance = transform.position - player.transform.position;
        Debug.Log(SystemInfo.deviceUniqueIdentifier);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + distance;
    }
}
