using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinaria
{
    class Vector
    {
        int[] vector;
        static Random rand = new Random();
        public int comparaciones { get; private set; }

        public Vector(int tamaño)
        {
            vector = new int [tamaño];
        }

        public void llenar(int limite)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                vector[i] = rand.Next(0, limite - 1);
            }
        }

        public string mostrar()
        {
            string llenar="";
            for (int i = 0; i < vector.Length; i++)
            {
                llenar += "[ " + i + " ]= " + vector[i] + "\r\n";
            }
            return llenar;
        }

        public void ordenar()
        {
            Array.Sort(vector);
        }

        public string busquedaBin(int num)
        {
            int ls = 0, li = 0, m = 0, cont = 0;
            bool encontrado = false;
            ls = vector.Length - 1;
            m = (ls + li) / 2;

            comparaciones++;
            if (num == vector[m])
                return "numero encontrado en la posicion: " + m + "\r\n" + "No. comparaciones: " + Convert.ToString(comparaciones);
            else
                return BusquedaBin(m, num, ls, li, encontrado, cont, 0, 0);
        }

        private string BusquedaBin(int m, int num, int ls, int li,bool encontrado, int cont,int ant, int comp)
        {
            if (m > 0)
            {

                if (cont <= 1 && num > vector[m])
                {
                    comparaciones++;
                    li = m;
                    m = (ls + li) / 2;

                    if (m == li)
                        ant++;
                    if (ant > 1)
                    {
                        li++;
                        m = (ls + li) / 2;
                        ant = 0;
                    }

                    if (cont > 0)
                        return "-1 Numero no encontrado";
                    if (m == vector.Length-1)
                        cont++;

                    if (num == vector[m])
                    {
                        encontrado = true;
                        return "numero encontrado en la posicion: " + m + "\r\nNo. comparaciones: " + Convert.ToString(comparaciones);
                    }
                    else
                        return BusquedaBin(m, num, ls, li, encontrado, cont, ant, comp);
                }
                else
                {
                    comparaciones++;
                    ls = m;
                    m = (ls + li) / 2;

                    if (cont > 1)
                        return "-1 Numero no encontrado";

                    if (comp == m)
                        cont++;
                    comp = m;

                    if (num == vector[m])
                    {
                        encontrado = true;
                        return "numero encontrado en la posicion: " + m + "\r\nNo. comparaciones: " + Convert.ToString(comparaciones);
                    }
                    else
                        return BusquedaBin(m, num, ls, li, encontrado, cont, ant, comp);
                }
            }
            else return "-1 Numero no encontrado";
        }
    }
}
