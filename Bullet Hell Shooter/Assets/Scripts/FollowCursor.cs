using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    private Camera cam;
    public float rotationSpeed;
    public BulletPlayer projectilePrefab;
    public Transform shootPosition;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Vector2 mouseWorldPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mouseWorldPoint - (Vector2)shootPosition.position).normalized;

        if(Input.GetMouseButtonDown(0))
        {
            BulletPlayer projectile = Instantiate(projectilePrefab, shootPosition.position, Quaternion.identity);

            projectile.LauchProjectile(direction);
        }
    }
}
