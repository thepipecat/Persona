using UnityEngine;

namespace ThePipeCat
{
  /// <summary>
  /// Persona profile.
  /// </summary>
  [CreateAssetMenuAttribute(fileName = "New Persona Profile", menuName = "Persona/Profile")]
  public class PersonaProfile : ScriptableObject
  {
    private string m_Name = "Profile Name";
    private PersonaStats m_Stats;
    private PersonaInventory m_Inventory;

    public string Name
    {
      get { return m_Name; }
    }

    public PersonaStats Stats {
      get { return m_Stats; }
    }

    public PersonaInventory Inventory {
      get { return m_Inventory; }
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
