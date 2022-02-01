using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class times : MonoBehaviour
{
    float currentTime;
    public int startSec;
    public Text currentTimeText;
    void Start()
    {
        currentTime = startSec;
    }

    // Update is called once per frame
    void Update()
    {
        currentTimeText.text = currentTime.ToString();
    }
}
