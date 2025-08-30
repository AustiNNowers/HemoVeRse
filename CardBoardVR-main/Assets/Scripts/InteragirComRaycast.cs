using UnityEngine;

public class InteragirComRaycast : MonoBehaviour
{
    public Renderer objetoRenderer;

    void Update()
    {
        /*Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject == gameObject)
            {
                objetoRenderer.material.color = Color.red;
            }
            else
            {
                objetoRenderer.material.color = Color.white;
            }
        }
        else
        {
            objetoRenderer.material.color = Color.white;
        }*/
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
