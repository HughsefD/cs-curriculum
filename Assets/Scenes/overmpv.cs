
using UnityEngine;

public class overmpv : MonoBehaviour
{
    public float walkSpeed;
    
    public float xDirection;

    public float xVector;
    
    public float yDirection;

    public float yVector;

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
        yDirection = Input.GetAxis("Vertical");
        yVector = yDirection * walkSpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xVector, yVector, z: 0);
    }
}