using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Jika yang menyentuh adalah Player
        if (other.CompareTag("Player"))
        {
            // Hapus Data Chip
            Destroy(gameObject);
        }
    }
}