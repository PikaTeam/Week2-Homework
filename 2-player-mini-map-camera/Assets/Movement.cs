using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public string UpKey = "w";
    public string DownKey = "s";
    public string LeftKey = "a";
    public string RightKey = "d";
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        float moveDistance = speed * Time.deltaTime;

        if (Input.GetKey(UpKey))
        {
            pos.y += moveDistance;
        }
        else if (Input.GetKey(DownKey))
        {
            pos.y -= moveDistance;
        }

        if (Input.GetKey(RightKey))
        {
            pos.x += moveDistance;
        }
        else if (Input.GetKey(LeftKey))
        {
            pos.x -= moveDistance;
        }

        transform.position = pos;
    }
}
