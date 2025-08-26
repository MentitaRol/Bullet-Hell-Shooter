using UnityEngine;

public class FollowCursor : MonoBehaviour
{

    private Camera cam;
    public float rotationSpeed;
    public BulletPlayer projectilePrefab;
    public Transform shootPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseWorldPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mouseWorldPoint - (Vector2)transform.position;
        //Movimiento suave entre dos vectores
        transform.up = Vector2.MoveTowards(transform.up, direction, rotationSpeed * Time.deltaTime);

        //Lanzar proyectiles cuando de click Izquierdo

        if(Input.GetMouseButtonDown(0))
        {
            BulletPlayer projectile = Instantiate(projectilePrefab, shootPosition.position, transform.rotation);
            projectile.LauchProjectile(transform.up);
        }
    }
}
