using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Tambah jumlah DataChip
            GameManager.instance.AddChip();

            // Hapus DataChip
            Destroy(gameObject);
        }
    }
}