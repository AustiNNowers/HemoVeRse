using UnityEngine;
using UnityEngine.UI;
public class CameraSeguirMouse : MonoBehaviour
{
    public float sensibilidade = 100f;
    private float rotacaoX = 0f;
    private float rotacaoY = 0f;
    public Camera vrCamera;
    public float rayLength = 10f;
    private Button botao;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Captura entrada do mouse
        float mouseX = Input.GetAxis("Mouse X") * sensibilidade * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidade * Time.deltaTime;

        rotacaoY += mouseX;
        rotacaoX -= mouseY;

        transform.localRotation = Quaternion.Euler(rotacaoX, rotacaoY, 0f);

        Ray ray = new Ray(vrCamera.transform.position, vrCamera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayLength))
        {
            Button btn = hit.collider.GetComponent<Button>();

            if (btn != null)
            {
                botao = btn;

                if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
                {
                    btn.onClick.Invoke();
                }
            }
        }
        else
        {
            botao = null;
        }
    }
}