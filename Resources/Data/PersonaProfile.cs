using UnityEngine;

namespace ThePipeCat
{
  /// <summary>
  /// Persona profile.
  /// </summary>
  [CreateAssetMenuAttribute(fileName = "New Persona Profile", menuName = "Persona/Profile")]
  public class PersonaProfile : ScriptableObject
  {
    private string m_name = "Profile Name";
    private PersonaStats m_stats;
    private PersonaInventory m_inventory;

    public string Name
    {
      get { return m_name; }
    }

    public PersonaStats Stats {
      get { return m_stats; }
    }

    public PersonaInventory Inventory {
      get { return m_inventory; }
    }

    // -------------------------------------------------------------------------
    // Unity Lifecycle:
    // -------------------------------------------------------------------------

    private void Awake()
    {

    }

    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }
  }
}
