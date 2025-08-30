using UnityEngine;

[CreateAssetMenu(menuName = "BulletHell System/Radial Shot Pattern")]

//ScriptableObject para guardar los distintos patrones de bala y reutilizarlos
public class RadialShootPattern : ScriptableObject
{
    public RadialShoot[] PatternSettings;
    //Numero de repeticiones que hace el patron
    public int Repetitions;
    public float StartWait = 0f;
    public float EndtWait = 0f;
    [Range(-180f, 180f)] public float AngleOffsetBetweenReps = 0f;
}
