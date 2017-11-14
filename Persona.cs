using UnityEngine;

namespace ThePipeCat.Persona
{
  /// <summary>
  /// Persona.
  /// </summary>
  [ExecuteInEditMode]
  public class Persona : MonoBehaviour
  {
    PersonaProfile m_Profile;

    public PersonaProfile Profile
    {
      get { return m_Profile; }
    }

    // -------------------------------------------------------------------------
    // Unity Lifecycle:
    // -------------------------------------------------------------------------

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


#endif

  }
}
