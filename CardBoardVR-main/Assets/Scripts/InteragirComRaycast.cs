using UnityEngine;

public class InteragirComRaycast : MonoBehaviour
{
    public Renderer objetoRenderer;

    void Update()
    {

    }

    public void OnPointerEnter()
    {
        objetoRenderer.material.color = Color.red;
    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public void OnPointerExit()
    {
        objetoRenderer.material.color = Color.green;
    }

    /// <summary>
    /// This method is called by the Main Camera when it is gazing at this GameObject and the screen
    /// is touched.
    /// </summary>
    public void OnPointerClick()
    {
        objetoRenderer.material.color = Color.blue;
    }
}
