using UnityEngine;

//Serializar esta clase en otras partes de Unity
[System.Serializable]

public class RadialShoot
{

    [Header("Base Settings")]
    public int NumberOfBullets = 5;
    public float BulletSpeed = 10f;
    public float CooldownAfterShot;

    [Header("Offsets")]
    [Range(-1f, 1f)] public float PhaseOffset = 0f;
    [Range(-180f, 180f)] public float AngleOffset = 0f;

}
