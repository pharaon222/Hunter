using UnityEngine;

public class GunController : MonoBehaviour
{
    public float sensitivity = 2;
    private float _horizontal;
    private float _vertical;

    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxis("Mouse X") * sensitivity;
        transform.Rotate(0, _horizontal, 0);

        _vertical = Input.GetAxis("Mouse Y") * sensitivity;
        transform.Rotate(0, 0, _vertical);
    }
}
