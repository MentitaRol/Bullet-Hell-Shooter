using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    private const float MaxLifeTime = 4f;
    private float lifeTime = 0f;

    public Vector2 Velocity;

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)Velocity * Time.deltaTime;
        lifeTime += Time.deltaTime;

        if(lifeTime > MaxLifeTime)
        {
            Disable();
        }
    }

    private void Disable()
    {
        lifeTime = 0f;
        gameObject.SetActive(false);
    }
}
