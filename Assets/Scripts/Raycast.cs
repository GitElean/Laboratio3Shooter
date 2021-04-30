using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{
    // Start is called before the first frame update
    private int score=0;
    public Text scoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitinfo;
        Ray camRay = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        Physics.Raycast(camRay);

        if (Physics.Raycast(camRay, out hitinfo) && Input.GetMouseButtonDown(0)) 
        {
            if (hitinfo.collider.CompareTag("Target"))
            {
                Destroy(hitinfo.collider.gameObject);
                score++;
            }
            
        }

        scoreText.text = "Score: " + score.ToString();
    }
}
