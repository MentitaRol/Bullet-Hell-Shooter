using UnityEngine;
using System;
using System.Collections.Generic;

public class BulletPool : MonoBehaviour
{
    private static BulletPool instance;
    public static BulletPool Instance
    {
        get
        {
            if(instance == null)
                Debug.LogError("BulletPool Instance missing");
            return instance;
        }
    }

    public BulletEnemy BulletEnemy;
    public int initialPoolSize = 10;

    private List<BulletEnemy> bulletPool = new List<BulletEnemy>();

    private void Awake()
    {

        if(instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }else
        {
            instance = this;
        }

        AddBulletToPool(initialPoolSize);
    }

    private void AddBulletToPool(int amount)
    {

        for(int i = 0; i < amount; i++){
            BulletEnemy bullet = Instantiate(BulletEnemy);
            bullet.gameObject.SetActive(false);
            bulletPool.Add(bullet);
            bullet.transform.parent = transform;
        }

    }

    public BulletEnemy RequestBullet()
    {
        for(int i = 0; i < bulletPool.Count; i++)
        {
            if(!bulletPool[i].gameObject.activeSelf)
            {
                bulletPool[i].gameObject.SetActive(true);
                return bulletPool[i];
            }
        }
        AddBulletToPool(1);
        bulletPool[bulletPool.Count - 1].gameObject.SetActive(true);
        return bulletPool[bulletPool.Count - 1];
    }
}
