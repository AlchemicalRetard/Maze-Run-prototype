using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody r;
    public float speed;
    private int count;
    float timer;
    public TextMeshProUGUI countText,winText,watch;
   
    void Start()
    {
        r = GetComponent<Rigidbody>();
        count = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        //timer
        if (count < 12)
        {
            timer = timer + Time.deltaTime;
            watch.text = "Time : " + timer.ToString("f1");


            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(x, 0, y);
            r.AddForce(movement * speed);
        }
        else
        {
            watch.color = Color.red;
            return;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {

            other.gameObject.SetActive(false);
            count++;
            countText.text = "Count - " + count.ToString();
            if(count >= 12)
            {
                winText.gameObject.SetActive(true);
            }
        }
    }
}
