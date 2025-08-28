using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class EntregarRotacao : MonoBehaviour
{
    public TextMeshProUGUI textoCart;
    public TextMeshProUGUI textoPlayer;
    public TextMeshProUGUI textoCamera;
    public TextMeshProUGUI textoPointer;

    public Transform cart;
    public Transform player;
    public Transform cameraObj;
    public Transform pointer;
    
    void Update()
    {
        if (cart != null)
            textoCart.text = "Dolly Cart\nX: " + cart.eulerAngles.x.ToString("F2") +
                             "\nY: " + cart.eulerAngles.y.ToString("F2") +
                             "\nZ: " + cart.eulerAngles.z.ToString("F2");

        if (player != null)
            textoPlayer.text = "Player\nX: " + player.eulerAngles.x.ToString("F2") +
                               "\nY: " + player.eulerAngles.y.ToString("F2") +
                               "\nZ: " + player.eulerAngles.z.ToString("F2");

        if (cameraObj != null)
            textoCamera.text = "Main Camera\nX: " + cameraObj.eulerAngles.x.ToString("F2") +
                               "\nY: " + cameraObj.eulerAngles.y.ToString("F2") +
                               "\nZ: " + cameraObj.eulerAngles.z.ToString("F2");

        if (pointer != null)
            textoPointer.text = "Cardboard ReticlePointer\nX: " + pointer.eulerAngles.x.ToString("F2") +
                                "\nY: " + pointer.eulerAngles.y.ToString("F2") +
                                "\nZ: " + pointer.eulerAngles.z.ToString("F2");
    }
}