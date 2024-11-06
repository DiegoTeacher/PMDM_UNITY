using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int[] puntuacion;
    public static GameManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        if(!instance)
        {
            // establecemos el nuevo GM
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        puntuacion = new int[2];
    }

    public int GetIndexPuntuacion(int index)
    {
        return puntuacion[index];
    }

    public void SetIndexPuntuacion(int index, int nValue)
    {
        puntuacion[index] = nValue;
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
