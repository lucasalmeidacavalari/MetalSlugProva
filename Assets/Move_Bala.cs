using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Bala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(5 * Time.deltaTime, 0, 0);
    }
}