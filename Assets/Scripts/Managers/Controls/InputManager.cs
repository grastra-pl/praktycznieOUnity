using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private TouchControls touchControls;

    private void Awake()
    {
        touchControls = new TouchControls();
    }

    private void OnEnable()
    {
        touchControls.Enable();
    }

    private void OnDisable()
    {
        touchControls.Disable();
    }

    private void Start()
    {
        touchControls.Touch.TouchPress.started += ctx => StartTouch(ctx);
        touchControls.Touch.TouchPress.canceled += ctx => EndTouch(ctx);
    }

    private void StartTouch(InputAction.CallbackContext context)
    {
        Debug.Log("Touch started context: " + context.ReadValue<float>());
        Debug.Log("Touch started touchPosition: " + touchControls.Touch.TouchPosition.ReadValue<Vector2>());
    }

    private void EndTouch(InputAction.CallbackContext context)
    {
        Debug.Log("Touch ended " + context.ReadValue<float>());
    }

}
