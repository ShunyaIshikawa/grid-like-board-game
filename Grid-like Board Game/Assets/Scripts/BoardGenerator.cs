using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardGenerator : MonoBehaviour
{
    public GameObject boardPrefab;

    // Set grid numbers
    public int width;
    public int height;

    private float len;

    void Awake()
    {
        len = 8f / Mathf.Max(width, height);

        // Initialize the scale
        boardPrefab.transform.localScale = new Vector2(3.12f * len, 3.12f * len);
        
        for(int i = 0; i < height; i++)
        {
            for(int j = 0; j < width; j++)
            {
                GameObject newImg = Instantiate(boardPrefab) as GameObject;
                newImg.transform.position = new Vector3(-4f + 8f/(width*2) + j*len, -4f + 8f/(height*2) + i*len, 0);
            }
        }
    }

    public float GetLen()
    {
        return len;
    }
}
