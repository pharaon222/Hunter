using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    [Range(0, 50)] public int speed = 10;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        if (transform.position.x > -65)
        {
            Destroy(gameObject);
        }
    }
}
