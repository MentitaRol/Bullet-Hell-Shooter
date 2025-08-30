using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Death : MonoBehaviour
{

    public GameObject BulletPlayer;
    public int life = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("BulletPlayer"))
        {
            life--;
            Destroy(collision.gameObject);

            if (life <= 0){
                Destroy(gameObject);
            }
        }
    }
}
