using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private float _coins = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);

            _coins += 1;
        }
    }
}
