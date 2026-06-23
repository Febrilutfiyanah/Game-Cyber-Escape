using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.AddChip(); // Menambah DataChip

            AudioManager.instance.PlayCollectSound(); // Suara

            Destroy(gameObject);
        }
    }
}