using UnityEngine;
using TMPro;

public class BulletsUI : MonoBehaviour
{

    public TextMeshProUGUI bulletsBossText;

    private void Update()
    {
        UpdateBossBulletsCount();
    }

    private void UpdateBossBulletsCount()
    {
        int activeBossBullets = BulletPool.Instance.ActiveBossBulletsCount();
        bulletsBossText.text = $"Balas del Jefe: {activeBossBullets}";
    }

}
