using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aafCodeAbbey
{
    internal class Program
    {
        static List<string> strings = new List<string> { "FAAABEAFAFACB", "DFFEBFEAFDCCFBCBBCDC", "EAEFFAFCDB" , "BFECCFEBBEDBAFDACEFFFB", "CFCABAADACBCBACEFFAEABCCDBFFBCCFB", "BAFDDADDAECEDDBCBDFFA",
       "EDDACACFEEECCDEFBDCBCFBDD", "EFDCCECAFEFF", "DFDAEBEAFCBFAFDFDDCDFCCEAFBFF", "CCDC", "DDBDDA", "EFFFCBBBEC", "ABACADCB", "CEDBFCEDBBAEEBFACDDCDFE", "AAEFEDEAFCECABEBBEBDCEAF", "CEDAFCBCFFFACCCCDFFADDAFBCDAFCF"
        , "EFFBCFCEDCAAEEABCEEACBBEEDC", "EBAEDEDFDCDFFCEAADFDFDFEFC"};



        static void lepesek(string lepesek)
        {
            double x = 0.0;
            double y = 0.0;

            double[][] vektor = new double[][] {
            new double[] {1.0, 0.0},  // A
            new double[] {0.5, Math.Sqrt(3) / 2},  // B
            new double[] {-0.5, Math.Sqrt(3) / 2},  // C
            new double[] {-1.0, 0.0},  // D
            new double[] {-0.5, -Math.Sqrt(3) / 2},  // E
            new double[] {0.5, -Math.Sqrt(3) / 2}  // F
        };

            for (int i = 0; i < lepesek.Length; i++)
            {
                int irany = lepesek[i] - 'A';
                x += vektor[irany][0];
                y += vektor[irany][1];
            }


            double tavolsag = Math.Sqrt(x * x + y * y);

            Console.Write(tavolsag +" ");
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < strings.Count; i++)
            {
                lepesek(strings[i]);
            }
            Console.ReadLine();
        }
        
    }
}
