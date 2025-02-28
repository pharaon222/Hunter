using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("NPC"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Time.timeScale = 0;
            Debug.Log("Вы проиграли");
        }
    }
}
