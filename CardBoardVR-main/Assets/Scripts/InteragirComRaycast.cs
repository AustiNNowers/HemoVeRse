using UnityEngine;

public class InteragirComRaycast : MonoBehaviour
{
    public Renderer objetoRenderer;

    void Update()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
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
        }
    }
}
