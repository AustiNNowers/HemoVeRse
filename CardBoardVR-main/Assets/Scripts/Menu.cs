using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Unity.VisualScripting;

public class Menu : MonoBehaviour
{
    private Renderer chao;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chao = GetComponent<Renderer>();
    }

    public void Clicou()
    {
        chao.material.color = Color.cyan;
    }
}
