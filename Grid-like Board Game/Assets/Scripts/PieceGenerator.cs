using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceGenerator : MonoBehaviour
{
    [SerializeField] BoardGenerator b;
    [SerializeField] GameObject redPiecePrefab;
    [SerializeField] GameObject blackPiecePrefab;

    private float len;

    void Start()
    {
        len = b.GetLen() * 0.8f;
    }

    void Update()
    {
        // generate a red piece
        if(Input.GetKeyDown(KeyCode.D))
        {
            GameObject g = Instantiate(redPiecePrefab) as GameObject;
            g.transform.localScale = new Vector2(len, len);
            g.transform.position = new Vector3(7, 0, -1);
        }

        // generate a black piece
        if(Input.GetKeyDown(KeyCode.A))
        {
            GameObject g = Instantiate(blackPiecePrefab) as GameObject;
            g.transform.localScale = new Vector2(len, len);
            g.transform.position = new Vector3(-7, 0, -1);
        }
    }
}
