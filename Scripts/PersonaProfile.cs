using UnityEngine;

namespace ThePipeCat.Persona
{
  /// <summary>
  /// Persona profile.
  /// </summary>
  [CreateAssetMenuAttribute(fileName = "New Persona Profile", menuName = "Persona/Profile")]
  public class PersonaProfile : ScriptableObject
  {
    [SerializeField]
    private PersonaType m_Type;
    [SerializeField]
    private string m_ProfileName = "Profile Name";
    [SerializeField]
    private PersonaStats m_Stats;
    [SerializeField]
    private PersonaInventory m_Inventory;

    public PersonaType Type
    {
      get { return m_Type; }
    }

    public string Name
    {
      get { return m_ProfileName; }
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
