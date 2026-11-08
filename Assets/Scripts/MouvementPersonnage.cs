using UnityEngine;
using UnityEngine.InputSystem;

public class MouvementPersonnage : MonoBehaviour
{
    [SerializeField] InputAction deplacementPerso;

    [SerializeField] float vitesseDeplacement = 7.5f;

    CharacterController characterController;

    void OnEnable()
    {
        deplacementPerso.Enable();
    }

    void OnDisable()
    {
        deplacementPerso.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position);
    Vector2 deplacement = deplacementPerso.ReadValue<Vector2>();

        Vector3 mouvement = transform.right * deplacement.x + transform.forward * deplacement.y;

        characterController.Move(mouvement * vitesseDeplacement * Time.deltaTime);
    }
}
