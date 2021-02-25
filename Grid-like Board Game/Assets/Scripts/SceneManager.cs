using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public static void StartToMain()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
    }
}
