using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class PleyerController : MonoBehaviour
{
    float velX;
    float angeVel;

    void Update()
    {
        float newVelX = 0f;
        if (Input.GetKey(KeyCode.D))
            newVelX += 30f;
        if (Input.GetKey(KeyCode.A))
            newVelX -= 30f;
        velX = Mathf.Lerp(velX, newVelX, Time.deltaTime / 1f);
        transform.position += Time.deltaTime * new Vector3(velX, 0f, 0f);
    }
}
