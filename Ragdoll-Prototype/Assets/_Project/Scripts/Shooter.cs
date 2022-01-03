using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float shootForce = 20f;

    private void Update()
    {
        if (Input.GetMouseButton(0))
            Shoot();
    }

    private void Shoot()
    {
        var proj = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);

        Ray shootRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        var rigidbodies = proj.GetComponentsInChildren<Rigidbody>();

        foreach (var rb in rigidbodies)
            rb.AddForce(shootRay.direction * shootForce, ForceMode.Impulse);
    }
}