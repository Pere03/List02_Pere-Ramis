using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1_Sphere : MonoBehaviour
{
    public Exercise1 ex1;
    void Start()
    {
        ex1 = FindObjectOfType<Exercise1>();
    }

    private void OnMouseDown() 
    {
        ex1.enemiesLeft -= 1;
        Destroy(gameObject);
    }
}
