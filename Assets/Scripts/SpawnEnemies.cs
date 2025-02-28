using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject[] enemies;

    private int _index;
    public int startSpawn = 3;
    public int spawnRepeat = 20;
    public int spawnCount = 1;
    private Vector3 _position;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        spawnCount = 1;
        InvokeRepeating("Spawn", startSpawn, spawnRepeat);
    }

    private void Spawn()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            _position = new Vector3(Random.Range(-110, -90), 0, Random.Range(140, 145));
            _index = Random.Range(0, enemies.Length);
            Instantiate(enemies[_index], _position, enemies[_index].transform.rotation);
        }
        spawnCount++;
    }
}
