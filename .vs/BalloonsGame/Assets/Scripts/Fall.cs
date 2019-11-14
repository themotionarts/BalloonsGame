using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.gravity = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
            Physics2D.gravity = new Vector2(0, 0);

        if (Input.GetMouseButtonUp(0))
            Physics2D.gravity = new Vector2(0, -5);

    }
}
