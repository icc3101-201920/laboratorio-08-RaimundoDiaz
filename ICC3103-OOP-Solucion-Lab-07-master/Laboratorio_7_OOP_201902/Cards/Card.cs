using Laboratorio_7_OOP_201902.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio_7_OOP_201902.Interfaces;

namespace Laboratorio_7_OOP_201902.Cards
{
    [Serializable]
    public abstract class Card:ICharacteristics
    {
        //Atributos
        protected string name;
        protected EnumType type;
        protected string effect;

        //Constructor
        public Card()
        {

        }

        //Propiedades
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public EnumType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        public string Effect
        {
            get
            {
                return this.effect;
            }
            set
            {
                this.effect = value;
            }
        }

        public List<string> GetCharacteristics()
        {
            List<string> granLista = new List<string> { Name, Convert.ToString(Type), Effect };
            return granLista;

        }
    }
}
