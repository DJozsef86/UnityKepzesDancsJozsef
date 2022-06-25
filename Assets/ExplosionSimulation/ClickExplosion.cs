using UnityEngine;

public class ClickExplosion : MonoBehaviour
{

    [SerializeField] Camera camera;
    [SerializeField] float explosionForce;
    [SerializeField] float explosionRadius;
    [SerializeField] float explosionUp;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray mouseRay = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(mouseRay, out RaycastHit hitInfo))
            {
                Rigidbody[] allRgbds = FindObjectsOfType<Rigidbody>();

                foreach (var rgbd in allRgbds)
                {
                   rgbd.AddExplosionForce(explosionForce, hitInfo.point, explosionRadius, explosionUp, ForceMode.Impulse);
                }

                Debug.Log(hitInfo.point);
            }
            
        }
    }
}
