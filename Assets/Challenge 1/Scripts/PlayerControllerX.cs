using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    private float _propallerSpeed = 600f;
    [SerializeField] GameObject _propaller;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        //verticalInput = -verticalInput;
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime );

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

        _propaller.transform.Rotate(Vector3.forward * _propallerSpeed * Time.deltaTime);
    }
}
