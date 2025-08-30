using UnityEngine;
using TMPro;

public class BulletsPlayerUI : MonoBehaviour
{

    public TextMeshProUGUI bulletsPlayerText;

    void Update()
    {
        bulletsPlayerText.text = $"Balas del Jugador: {BulletPlayer.activePlayerBullets}";
    }
}
