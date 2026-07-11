using UnityEngine;
using UnityEngine.EventSystems;
using StarterAssets;

public class LookTouch : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    public StarterAssetsInputs starterInputs;

    [SerializeField]
    private float sensitivity = 0.2f;

    private Vector2 lastPosition;

    public void OnPointerDown(PointerEventData eventData)
    {
        lastPosition = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 delta = eventData.position - lastPosition;

        starterInputs.LookInput(delta * sensitivity);

        lastPosition = eventData.position;
    }
}