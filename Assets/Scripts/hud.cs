
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{

   
    int health;
    int maxhealth;
    int coins;
    public Coin purse;
    public TextMeshProUGUI coinText;
    public HealthManager healthManager;
    public TextMeshProUGUI healthText;
    void Update()
    {
        coinText.text = "coins " + healthManager;
        healthText.text = "Health " + healthManager;
    }
}
