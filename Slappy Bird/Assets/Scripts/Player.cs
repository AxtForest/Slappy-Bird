using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    public float gravity = -9.8f ;
    public float guc = 5f;
    public AudioSource kaynak;
    public AudioClip bom,gameover;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up*guc;
            kaynak.PlayOneShot(bom,0.5f);// bom sesi yerine bizimkiler
        }
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up*guc;
                kaynak.PlayOneShot(bom,0.5f);// bom sesi yerine bizimkiler

            }
        }
        direction.y += gravity*Time.deltaTime;
        transform.position += direction*Time.deltaTime;
    }
    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direction = Vector3.zero;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Engel")
        {
            FindObjectOfType<GameManager>().GameOver();
            kaynak.PlayOneShot(gameover, 5f);

        }
        else if (collision.gameObject.tag == "Score")
        {
            FindObjectOfType<GameManager>().IncreaseScore();
        }
    }
   


}
