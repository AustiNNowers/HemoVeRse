using UnityEngine;
using Unity.Cinemachine;

public class InteragirComRaycast : MonoBehaviour
{

    public CinemachineSplineCart cart;

    private void Start()
    {
        gameObject.SetActive(true);

        cart.AutomaticDolly.Enabled = false;
    }

    public void OnPointerEnter()
    {
        
    }
    public void OnPointerExit()
    {
        
    }
    public void OnPointerClick()
    {
        gameObject.SetActive(false);

        cart.AutomaticDolly.Enabled = true;
    }
}
