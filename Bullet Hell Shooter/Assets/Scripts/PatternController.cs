using System.Collections;
using UnityEngine;

public class PatternController : MonoBehaviour
{

    public RadialShootWeapon weapon;
    public RadialShootPattern[] patterns;
    public float patternDuration = 10f;

    private int currentPatternIndex = 0;

    void Start()
    {
        StartCoroutine(RunPatterns());
    }

    private IEnumerator RunPatterns()
    {
        while (true)
        {
            weapon.shootPattern = patterns[currentPatternIndex];

            yield return new WaitForSeconds(patternDuration);

            currentPatternIndex = (currentPatternIndex + 1) % patterns.Length;
        }
    }
}
