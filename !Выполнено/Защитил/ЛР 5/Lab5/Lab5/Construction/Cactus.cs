using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Xml.Schema;

namespace Lab5.Construction
{
    sealed class Cactus : Plant
    {   private sbyte difficulty;
        public override double Size { get; set; }
        public sbyte Difficulty {
            get
            {
                return this.difficulty;
            }
            set
            {
                if(value > 0 && value < 4)
                {
                    this.difficulty = value;
                }
            }
        }

        public string DetectDifficulty(sbyte difficulty)
        {
            string detector = null;
            switch (difficulty)
            {
                case 1:
                    detector = "Легкая";
                    break;
                case 2:
                    detector = "Средняяя";
                    break;
                case 3:
                    detector = "Сложная";
                    break;
            }

            return detector;
        }

        public override void Note()
        {
            Console.WriteLine("Это кактус.");
        }

        public override string ToString()
        {
            return $"{{{nameof(Size)}={Size.ToString()}, {nameof(Difficulty)}={Difficulty.ToString()}, {nameof(Name)}={Name}}}";
        }
    }
}
