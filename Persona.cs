using UnityEngine;

namespace ThePipeCat
{
  //[ExecuteInEditMode]
  public class Persona : MonoBehaviour
  {
    private Vector3[] m_WayPoints;

    private void Awake()
    {

    }

    private void Start()
    {

    }

    private void Update()
    {

    }

    private void FixedUpdate()
    {

    }

    // -------------------------------------------------------------------------
    // Editor helper:
    // -------------------------------------------------------------------------

    private void OnDrawGizmos()
    {
      if (m_WayPoints != null)
      {
        string wayPointIcon = "";
        int wayPointsCount = m_WayPoints.Length;

        for (int i = 0; i < wayPointsCount; i++)
        {
          Vector3 wayPoint = m_WayPoints[i];

          Gizmos.DrawIcon(wayPoint, wayPointIcon);
        }
      }
    }
  }
}
