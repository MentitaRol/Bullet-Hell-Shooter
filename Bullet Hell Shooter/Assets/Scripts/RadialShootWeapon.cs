using System.Collections; 
using UnityEngine;

public class RadialShootWeapon : MonoBehaviour
{
    public RadialShootPattern shootPattern;
    private bool onShoot = false;


    void Update()
    {
        if (!onShoot && shootPattern != null)
        {
            StartCoroutine(ExecuteRadialShootPattern(shootPattern));
        }
    }

    private IEnumerator ExecuteRadialShootPattern(RadialShootPattern pattern)
    {
        onShoot = true;
        int lap = 0;
        Vector2 aimDirection = transform.up;
        Vector2 center = transform.position;

        yield return new WaitForSeconds(pattern.StartWait);

        while(lap < pattern.Repetitions)
        {

            if(lap > 0 && pattern.AngleOffsetBetweenReps != 0f)
                aimDirection = aimDirection.Rotate(pattern.AngleOffsetBetweenReps);

            for(int i = 0; i < pattern.PatternSettings.Length; i++)
            {
                ShootAtack.RadialShoot(center, aimDirection, pattern.PatternSettings[i]);
                yield return new WaitForSeconds(pattern.PatternSettings[i].CooldownAfterShot);
            }
            lap++;
        }

        yield return new WaitForSeconds(pattern.EndtWait);

        onShoot = false;
    }

}
