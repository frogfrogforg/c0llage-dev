using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHand : MonoBehaviour
{
	public float speed = 1f;
	public float maxDelta = 1f;
	private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Clamp(Input.GetAxis("Mouse X"), -1f, 1f);
        float y = Mathf.Clamp(Input.GetAxis("Mouse Y"), -1f, 1f);
        Vector3 movement = new Vector3(x, 0f, y);
        movement = Vector3.ClampMagnitude(movement, maxDelta);
        rb.AddForce(movement*speed);
    }
}
