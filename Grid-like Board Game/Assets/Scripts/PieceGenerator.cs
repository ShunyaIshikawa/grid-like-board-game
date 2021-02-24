using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceGenerator : MonoBehaviour
{
    public BoardGenerator b;
    public GameObject piecePrefab;

    private float len;

    void Start()
    {
        len = b.GetLen() * 0.8f;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            GameObject g = Instantiate(piecePrefab) as GameObject;
            g.transform.localScale = new Vector2(len, len);
            g.transform.position = new Vector3(7, 0, -1);
        }
    }
}
