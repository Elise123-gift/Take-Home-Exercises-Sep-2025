using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenoSystem
{
    public class Opening
    {
        //data members or Fields
        private int _Edging;
        private int _Height;
        private int _Width;

        //Constants
        public const int MINIMUMEDGING = 10;
        public const int MINIMUMHEIGHT = 120;
        public const int MINIMUMWIDTH = 50;

        //implemented properties
        public int Width
        { 
            get 
            { 
                return _Width; 
            }
            set
            {   
                if (!Utilities.IsNonZeroPositive(value))
                {
                    throw new ArgumentException($"{nameof(Width)} must be a positive non-zero value.");
                }

                if(!Utilities.MeetsMinimumCriteria(value, MINIMUMWIDTH))
                {
                    throw new ArgumentException($"{nameof(Width)} must be at least {MINIMUMWIDTH}.");
                }
                
                _Width = value;
            }
        }

        public int Height 
        {
            get 
            { 
                return _Height; 
            }
            
            set 
            { 
                if (!Utilities.IsNonZeroPositive(value))
                {
                    throw new ArgumentException($"{nameof(Height)} must be a positive non-zero value.");
                }
                else 
                { 
                    if (!Utilities.MeetsMinimumCriteria(value, MINIMUMHEIGHT)) 
                    {
                        throw new ArgumentException($"{nameof(Height)} must be at least {MINIMUMHEIGHT}.");
                    }
                }
                
                _Height = value; 
            } 
        }

        public int Edging
        { 
            get 
            { 
                return _Edging; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(Edging)} cannot be negative.");
                }

                if (value != 0 && !Utilities.MeetsMinimumCriteria(value, MINIMUMEDGING))
                {
                    throw new ArgumentException($"{nameof(Edging)} must be 0 or at least {MINIMUMEDGING}.");
                }

                _Edging = value;
            }
            
        }

        public OpeningType Type { get; set; }

        public int Area
        {
            get
            {
            return (Width * Height);
            }
        }

        public int Perimeter
        {
            get
            {
                return (2 * (Width + Height));
            }
        }

        //Greedy Constructor
        public Opening(OpeningType openingType, int width, int height, int edging = 0 )
        {

            Type = openingType;
            Width = width;
            Height = height;
            Edging = edging;
            
        }

        //ToString override
        public override string ToString()
        {
            return $"{Type},{Width},{Height},{Edging}";
        }


    }
}
