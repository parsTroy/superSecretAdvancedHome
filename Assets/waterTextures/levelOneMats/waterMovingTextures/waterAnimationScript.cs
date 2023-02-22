using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterAnimationScript : MonoBehaviour
{

    public float speedX = 0.5f;
    public float speedY = 0.5f;


    // Update is called once per frame
    void FixedUpdate()
    {
        float OffsetX = Time.time * speedX;
        float Offsety = Time.time * speedY;
        GetComponent<Renderer> ().material.mainTextureOffset = new Vector2 (OffsetX, Offsety);
    }
}