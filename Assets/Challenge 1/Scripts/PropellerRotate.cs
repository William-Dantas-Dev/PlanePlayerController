using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotate : MonoBehaviour
{
    [SerializeField] private float speed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}
