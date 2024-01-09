
using UnityEngine;

public class CaveMovement : MonoBehaviour
{
    public float walkSpeed;

    public float xDirection;

    public float xVector;
    // Start is called before the first frame update
    void Start()
    {
        walkSpeed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        xVector = xDirection * walkSpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xVector, y: 0, z: 0);
    }
}
