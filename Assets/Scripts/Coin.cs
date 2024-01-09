
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coins;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coins += 1;
            // destroy coin
            other.gameObject.SetActive(false);
        }
    }
}
