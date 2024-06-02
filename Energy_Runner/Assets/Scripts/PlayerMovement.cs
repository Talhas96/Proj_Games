using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f; // Velocidade de movimento do jogador

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Verifica se a tecla da seta para cima está pressionada
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Move o jogador para a frente na direção em que está virado
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        // Movimento para a direita
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        // Movimento para a esquerda
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        // Movimento para a trás
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
    }
}
