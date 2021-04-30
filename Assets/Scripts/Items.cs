using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    // Start is called before the first frame update
    Color original;
    [SerializeField]  private float force = 0.0f;
   
    Rigidbody rb;
    void Start()
    {
        original = GetComponent<MeshRenderer>().material.color;

        rb = GetComponent< Rigidbody > ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    private void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = original;
    }

    private void OnMouseDown()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitinfo;

        Physics.Raycast(camRay, out hitinfo);

        if (rb)
            rb.AddForceAtPosition(-hitinfo.normal * force, hitinfo.point,ForceMode.Impulse);
    }
}
