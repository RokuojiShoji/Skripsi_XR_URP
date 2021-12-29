using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(HandPhysics))]
public class ControllerHider : MonoBehaviour
{

    //[SerializeField] private XR
    [SerializeField] private GameObject controllerObject = null;

    private HandPhysics handPhysics = null;
    private XRDirectInteractor interactor = null;

    private void Awake()
    {
        handPhysics = GetComponent<HandPhysics>();
        interactor = GetComponent<XRDirectInteractor>();
    }

    private void OnEnable()
    {
        interactor.onSelectEntered.AddListener(Hide);
        interactor.onSelectExited.AddListener(Show);
    }

    private void OnDisable()
    {
        interactor.onSelectEntered.RemoveListener(Hide);
        interactor.onSelectExited.RemoveListener(Show);
    }

    private void Hide(XRBaseInteractable interactable)
    {
        controllerObject.SetActive(false);
    }

    private void Show(XRBaseInteractable interactable)
    {
        StartCoroutine(WaitForRange());
    }

    private IEnumerator WaitForRange()
    {
        yield return new WaitWhile(handPhysics.InRange);
        controllerObject.SetActive(true);
    }
}