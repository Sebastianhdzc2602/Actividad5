using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    [SerializeField] float speed;
   
    

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.fixedDeltaTime);
    }

   

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            Destroy(gameObject);
         
        }

        if (collision.CompareTag("Trash"))
        {
            Destroy(gameObject);
        }
    }
}
