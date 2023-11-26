using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaIMG : MonoBehaviour
{
    [SerializeField]
    private Sprite[] imagens;
    [SerializeField]
    private SpriteRenderer sr;
    [SerializeField]
    private int x = 1;
    [SerializeField]
    private GameObject balas;

    private Vector2 dir;
    [SerializeField]
    private JoyControl joyC;

    void Start()
    {
        sr.sprite = imagens[1];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (x == 1)
            {
                x = 0;
            }
            else
            {
                x = 1;
            }

            sr.sprite = imagens[x];
        }

        Mover();
        Move2();

    }

    void Mover()
    {
        transform.Translate((dir * 2) * Time.deltaTime);
    }

    void Move2()
    {
        dir.x = joyC.Hori();
        dir.y = joyC.Verti();
    }

    public void Tiros()
    {
        Instantiate(balas, transform.position, Quaternion.identity);
    }
}
