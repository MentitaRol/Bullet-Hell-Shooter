using UnityEngine;

public static class ShootAtack
{
    public static void SimpleShoot(Vector2 origin, Vector2 velocity)
    {
        //Donde spawnea la bala
        BulletEnemy bullet = BulletPool.Instance.RequestBullet();
        //Con que direccion
        bullet.transform.position = origin;
        //Con que velocidad
        bullet.Velocity = velocity;
    } 

    public static void RadialShoot(Vector2 origin, Vector2 aimDirection, RadialShoot settings)
    {
        //Angulo entre cada bala
        float angleBetweenBullets = 360f / settings.NumberOfBullets;

        if(settings.AngleOffset != 0f || settings.PhaseOffset != 0f)
            aimDirection = aimDirection.Rotate(settings.AngleOffset + (settings.PhaseOffset * angleBetweenBullets));

        //Generar todas las balas del disparo
        for(int i = 0; i < settings.NumberOfBullets; i++)
        {
            //Angulo especifico por bala
            float bulletDirectionAngle = angleBetweenBullets * i;

            //Tranformar angulo a vector
            Vector2 bulletDirection = aimDirection.Rotate(bulletDirectionAngle);
            SimpleShoot(origin, bulletDirection * settings.BulletSpeed);
        }
    }
}

