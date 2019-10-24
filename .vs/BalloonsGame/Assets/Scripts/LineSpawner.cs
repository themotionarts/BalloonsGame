using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _pointPrefab;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2d = new Vector2(mousePos.x, mousePos.y);
            Instantiate(_pointPrefab, new Vector3(mousePos2d.x, mousePos2d.y, 0) , Quaternion.identity);
            Debug.Log("Pressed" + Input.mousePosition.x);
        }
        
    }
}
