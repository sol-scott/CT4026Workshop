using UnityEngine;
using UnityEngine.AI;
public class AgentController : MonoBehaviour {

    [SerializeField]
    private LayerMask _geometryLayer = new LayerMask();

    private NavMeshAgent _agent = null;

    private void Awake() {
        _agent = GetComponent<NavMeshAgent>();

    }

    private void Update() {
        if (Input.GetMouseButtonDown(1)) {  // right mouse button down

            Ray cursorToWorldRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(cursorToWorldRay, out RaycastHit o_hit, maxDistance: float.PositiveInfinity, _geometryLayer)) {
                _agent.SetDestination(o_hit.point);
            }
        }
    }

}
