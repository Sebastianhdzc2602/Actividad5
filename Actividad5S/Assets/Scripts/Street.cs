using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Street : MonoBehaviour
{
    [SerializeField] Transform InitialPositionTransform;
    [SerializeField] Transform FinalPositionTransform;
    [SerializeField] float speed;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.fixedDeltaTime);
        if (transform.position.x <= FinalPositionTransform.position.x)
        {
            transform.position = InitialPositionTransform.position;
        }
    }
}
