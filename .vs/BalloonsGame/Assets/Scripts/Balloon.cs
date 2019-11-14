using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1.0f;
    [SerializeField]
    private float _upspeed = 5.0f;
    [SerializeField]
    private GameObject _balloonPrefab;

    public int score = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello!");
        //transform.position = new Vector3(Random.Range(-10.0f, 10.0f), -8.5f, 0);
    }

   
    void Update()
    {
        transform.Translate(Vector3.left * _speed * Mathf.Cos(Time.time) * Time.deltaTime);
        transform.Translate(Vector3.up * _upspeed * Time.deltaTime * (score / 5 + 1));

        if (transform.position.y > 8.5f)
            transform.position = new Vector3(Random.Range(-10.0f, 10.0f), -8.5f, 0);

        
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2d = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2d, Vector2.zero);

            if(hit.collider.gameObject == gameObject)
            {
                transform.position = new Vector3(Random.Range(-10.0f, 10.0f), -8.5f, 0);
                score++;
            }
            //Instantiate(_pointPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            //Debug.Log("Pressed");

        }
    }
    
}
