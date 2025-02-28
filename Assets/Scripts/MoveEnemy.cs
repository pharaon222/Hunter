using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    [Range(0, 50)] public int speed = 5;
    public int zRange = 195;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z > zRange)
        {
            Time.timeScale = 0;
            Debug.Log("Скелет убежал. Вы проиграли");
        }
    }
}
