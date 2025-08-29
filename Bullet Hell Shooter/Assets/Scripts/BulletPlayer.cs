using UnityEngine;

public class BulletPlayer : MonoBehaviour
{

    public float speed;
    private Rigidbody2D projectileRb;
    private float lifeTime = 2f;
    public static int activePlayerBullets = 0;

    private void Awake()
    {
        projectileRb = GetComponent<Rigidbody2D>();
        activePlayerBullets++;
    }

    public void LauchProjectile(Vector2 direction)
    {
        projectileRb.linearVelocity = direction * speed;
        Destroy(gameObject, lifeTime);
    }

    private void OnDestroy()
    {
        activePlayerBullets--;
    }

}
