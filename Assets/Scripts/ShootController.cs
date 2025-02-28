using UnityEngine;
using System.Collections;

public class ShootController : MonoBehaviour
{
    public GameObject bullet;
    public Transform barrel;
    private Quaternion _bulletRotation;

    // Update is called once per frame
    void Update()
    {
        _bulletRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, -90);
        if (Input.GetMouseButtonDown(0))
        { 
            Instantiate(bullet, barrel.position, _bulletRotation);
        }
    }
}
