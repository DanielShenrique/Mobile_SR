﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternsManager : MonoBehaviour {
    public bool Desaparece = false;
    public float speed;


    void Update()
    {
        StartCoroutine(Patterns());
        if (Desaparece == true)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            if (transform.position.x < Camera.main.transform.position.x - 22)
            {
                Destroy(gameObject);
            }
        }
    }
    IEnumerator Patterns()
    {
        yield return new WaitForSeconds(4);
        Desaparece = true;
        StopCoroutine(Patterns());
    }
}
