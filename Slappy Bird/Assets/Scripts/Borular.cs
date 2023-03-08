using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borular : MonoBehaviour
{
   
    public float hiz = 5f;

    private float SolKenar;


    // Start is called before the first frame update
    void Start()
    {
        SolKenar = Camera.main.ScreenToWorldPoint(Vector3.zero).x -1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * hiz * Time.deltaTime;
        if(transform.position.x < SolKenar)
        {
            Destroy(this.gameObject);
        }
    }
   
}
