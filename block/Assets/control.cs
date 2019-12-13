using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class control : MonoBehaviour
{
	public Material[] mat;
	public Transform sel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetAxis ("rHorizontal")>0) 
         {
             gameObject.GetComponent<Renderer>().material=mat[0];
         }
     if (Input.GetAxis ("rHorizontal")<0) 
         {
		 gameObject.GetComponent<Renderer>().material=mat[1];
         }
	 if(Input.GetAxis("Vertical") > 0)
	 {
		 print(Input.GetAxis("Vertical"));
		Vector3 movement =  new Vector3 (0.0f,1,0.0f);
		 transform.position += movement;
	 }
	 else if(Input.GetAxis("Vertical") < 0)
	 {
		 print(Input.GetAxis("Vertical"));
		Vector3 movement =  new Vector3 (0.0f,-1,0.0f);
		 transform.position += movement;
	 }
	 else
	 {
	 }
    }
}
