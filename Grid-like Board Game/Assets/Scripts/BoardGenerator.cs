using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardGenerator : MonoBehaviour
{
    [SerializeField] GameObject boardPrefab;

    // Set grid numbers
    [SerializeField] static int width;
    [SerializeField] static int height;

    private static float len;

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

    public static float GetLen()
    {
        return len;
    }

    public static void SetWidth(int w)
    {
        width = w;
    }

    public static void SetHeight(int h)
    {
        height = h;
    }
}
