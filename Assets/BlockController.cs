using System;
using System.Collections;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    private void Start()
    {

        StartCoroutine(routine: MoveDown());

    }

    IEnumerator MoveDown()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            var position = transform.position;
            position.y--;
            transform.position = position;
        }
        
    }
}