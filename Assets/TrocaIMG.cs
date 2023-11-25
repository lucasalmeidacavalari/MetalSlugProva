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
    private int direcao = 0;

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

    }

    public void Direita()
    {
        direcao = -2;
    }

    public void Esquerda()
    {
        direcao = 2;
    }

    public void Parado()
    {
        direcao = -0;
    }

    void Mover()
    {
        transform.Translate(direcao * Time.deltaTime, 0, 0);
    }
}
