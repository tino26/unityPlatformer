using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

	public float dy=0.0f;
    public bool isJump=false;
    public float x=0.0f;
    public float y=0.0f;


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
    	transform.position = new Vector2(x, y);

    	float moveX=0.0f;
    	float moveY=0.0f;
    	
    	if (Input.GetKeyUp(KeyCode.Space))
    	{
    		dy=0.0f;
    		isJump=true;
    	}

    	if (dy<0.25f && isJump==true)
    	{
    		dy=dy+0.01f;
    	}

    	if (dy>=0.25f)
    	{
    		isJump=false;
    	}

    	if (dy>-0.25f && isJump==false)
    	{
    		dy=dy-0.01f;
    	}

    	if (y<=-2.0f)
    	{
    		y=-2.0f;
    	}

    	if (Input.GetKey(KeyCode.A))
        {
            moveX=-0.2f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveX=0.2f;
        }

        x+=moveX;
        y+=dy;	
    }
}
