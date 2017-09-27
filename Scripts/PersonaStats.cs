using UnityEngine;

namespace ThePipeCat.Persona
{
    [System.Serializable]
    public class PersonaStats : System.Object
    {
        [SerializeField]
        protected float m_Life;
        [SerializeField]
        protected float m_LifeMax;
        [SerializeField]
        protected float m_Attack;
        [SerializeField]
        protected float m_Defense;

        public float Life
        {
            get { return m_Life; }
            set { m_Life = value; }
        }

        public float LifeMax
        {
            get { return m_LifeMax; }
            set { m_LifeMax = value; }
        }

        public float Attack
        {
            get { return m_Attack; }
            set { m_Attack = value; }
        }

        public float Defense
        {
            get { return m_Defense; }
            set { m_Defense = value; }
        }

    }
}