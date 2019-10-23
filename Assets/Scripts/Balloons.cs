using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private bool destroyBlock;
    // Update is called once per frame
    void Update()
    {
        transform.SetPositionAndRotation(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")), transform.localRotation);
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider.gameObject == gameObject)
            {
                gameObject.SetActive(false); //hide }
            }
        }
    }
    

}
