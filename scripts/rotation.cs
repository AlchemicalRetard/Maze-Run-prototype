using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    void fixedUpdate()
    {
        transform.Rotate(new Vector3(15, 45, 30)* Time.deltaTime);
    }
}
