using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThePipeCat
{
  [ExecuteInEditMode]
  public class PersonaPatrol : MonoBehaviour
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

#if UNITY_EDITOR

    private void OnDrawGizmosSelected()
    {
      if (m_WayPoints != null)
      {
        string wayPointIcon = "PersonaWaypoint.png";
        int wayPointsCount = m_WayPoints.Length;

        for (int i = 0; i < wayPointsCount; i++)
        {
          Vector3 wayPoint = m_WayPoints[i];

          Gizmos.DrawIcon(wayPoint, wayPointIcon);
        }
      }
    }

#endif

  }
}
