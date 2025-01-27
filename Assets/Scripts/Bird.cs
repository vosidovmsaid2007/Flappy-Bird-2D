using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public Canvas MenuCanvas;

    public float force;
    Rigidbody2D BirdRigid;

    void Start()
    {
        Time.timeScale = 1;
        BirdRigid = GetComponent<Rigidbody2D>();
        MenuCanvas.enabled = false;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            BirdRigid.velocity = Vector2.up * force;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            MenuCanvas.enabled = true;
        }
    }
}
