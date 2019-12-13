using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlights : MonoBehaviour
{
    // Start is called before the first frame update
	public Material[] mat;
    public float speed = 2.0f;
    void Start()
    {

    }

    // Update is called once per frame
	void Update()
	{

	if ((Input.GetAxis("Vertical") > 0) && ((transform.position.y) >= -1.3))
	{
	
		transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
	
	}
	else if ((Input.GetAxis("Vertical") < 0) && ((transform.position.y) <= 0.33))
	
	{
		transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
	}
	else
	{
	}
	}
	void OnTriggerEnter()
	{
		gameObject.GetComponent<Renderer>().material=mat[0];
	}
	void OnTriggerExit()
	{
		gameObject.GetComponent<Renderer>().material=mat[1];
	}
}
