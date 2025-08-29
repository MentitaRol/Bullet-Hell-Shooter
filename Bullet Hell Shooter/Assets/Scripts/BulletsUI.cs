using UnityEngine;
using TMPro;

public class BulletsUI : MonoBehaviour
{

    public TextMeshProUGUI bulletsText;

    private void Update()
    {
        UpdateBulletsCount();
    }

    private void UpdateBulletsCount()
    {
        int activeBullets = BulletPool.Instance.ActiveBulletsCount();
        bulletsText.text = $"Balas del Jefe: {activeBullets}";
    }

}
