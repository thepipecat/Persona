using UnityEditor;
using UnityEngine;

namespace ThePipeCat.Persona
{
  public class PersonaEditor : EditorWindow
  {
    private static Vector2 m_minWindowSize = new Vector2(300, 200);
    private static Vector2 m_maxWindowSize = new Vector2(300, 200);

    [MenuItem("Persona/New")]
    static void New()
    {
      PersonaEditor window = (PersonaEditor)GetWindow(typeof(PersonaEditor));

      window.minSize = PersonaEditor.m_minWindowSize;
      window.maxSize = PersonaEditor.m_maxWindowSize;

      window.Show();
    }

    static void Edit()
    {

    }
  }
}
