using UnityEngine;

public class BulletPlayer : MonoBehaviour
{

    public float speed;
    private Rigidbody2D projectileRb;
    private float lifeTime = 2f;

    private void Awake()
    {
        projectileRb = GetComponent<Rigidbody2D>();
    }

    public void LauchProjectile(Vector2 direction)
    {
        projectileRb.linearVelocity = direction * speed;
        Destroy(gameObject, lifeTime);
    }
}
