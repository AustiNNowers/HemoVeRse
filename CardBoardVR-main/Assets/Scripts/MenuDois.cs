using UnityEngine;

public class MenuDois : MonoBehaviour
{
    public Renderer parede;


    private void OnPointerEnter()
    {
        parede.material.color = Color.white;
    }

    private void OnPointerExit()
    {
        parede.material.color = Color.black;
    }

    private void OnPointerClick()
    {
        parede.material.color = Color.grey;
    }

}
