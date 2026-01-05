using UnityEngine;
using TMPro;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] private string _cointag = "Coin";
    [SerializeField] private int value = 1;
    [SerializeField] private TextMeshProUGUI scoreText;

    private int score = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(_cointag))
        {
            score += value;
            scoreText.text = "Coins: " + score;
            Destroy(other.gameObject);
        }
    }
}
