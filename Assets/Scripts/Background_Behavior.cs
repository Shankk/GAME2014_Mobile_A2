using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Behavior : MonoBehaviour
{
    public int Speed;
    public int HorizontalBoundary;
    public int HorizontalStart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBackground();
        ResetBackground();
    }
    void MoveBackground()
    {
        transform.position -= new Vector3(Speed * Time.deltaTime, 0, 0);
    }

    void ResetBackground()
    {
        if(transform.position.x < HorizontalBoundary)
        {
            transform.position = new Vector3(HorizontalStart, 0, 0);
        }
    }
}
