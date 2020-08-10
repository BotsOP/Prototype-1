using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBehavior : MonoBehaviour
{
    private Vector3 move = new Vector3(-1, 0, 0);
    private Vector3 newPos = new Vector3(0, 0, 204.80001f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(move);

        if (transform.position.z <= -24.99001)
        {
            transform.position = transform.position + newPos;
        }
    }
}
