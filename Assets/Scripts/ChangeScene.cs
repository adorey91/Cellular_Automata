using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadScene(string name)
    {
        Debug.Log($"Switching to {name}");
        SceneManager.LoadScene(name);
    }
}
