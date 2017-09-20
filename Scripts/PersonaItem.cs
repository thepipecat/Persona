using UnityEngine;

namespace ThePipeCat.Persona
{
  class PersonaItem : MonoBehaviour
  {
    private ItemProfile m_Profile;

    public ItemProfile Profile
    {
      get { return m_Profile; }
    }
  }
}
