using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShell : MonoBehaviour
{
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, Time.deltaTime * speed * 0.5f, Time.deltaTime * speed);
        transform.Translate(0, 0, Time.deltaTime * speed);

    }
}
