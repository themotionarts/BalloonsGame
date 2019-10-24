using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_script : MonoBehaviour
{

    //public Vector3 pos;
    //public bool pressed, used = false;
    // Start is called before the first frame update
    [SerializeField]
    private float _speed = 2.0f;
    [SerializeField]
    private bool isReleased = false;

    void Start()
    {
        //pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0) && !used)
        {
            pressed = true;
            used = true;
        }
        if(!Input.GetMouseButtonDown(0))
        {
            pressed = false;
        }
        

        if (pressed)
        {
            transform.SetPositionAndRotation(pos, transform.rotation);
        }*/
        if (Input.GetMouseButtonUp(0))
        {
            isReleased = true;
        }
        if (isReleased)
            transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < -8)
            Destroy(this.gameObject);
    }
}
