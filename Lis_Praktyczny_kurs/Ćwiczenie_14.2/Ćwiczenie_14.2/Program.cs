using System;

namespace Ćwiczenie_14._2
{
    class Prostokat
    {
        int[] vertexA = new int[2] { 1, 1 };
        int[] vertexB = new int[2] { 3, 1 };
        int[] vertexC = new int[2] { 5, 3 };
        int[] vertexD = new int[2] { 5, 1 };
        public int GetVertexAX()
        {
            return vertexA[0];
        }
        #region Metody zwracające wierzchołki
        public int GetVertexAY()
        {
            return vertexA[1];
        }
        public int GetVertexBX()
        {
            return vertexB[0];
        }
        public int GetVertexBY()
        {
            return vertexB[1];
        }
        public int GetVertexCX()
        {
            return vertexC[0];
        }
        public int GetVertexCY()
        {
            return vertexC[1];
        }
        public int GetVertexDX()
        {
            return vertexD[0];
        }
        public int GetVertexDY()
        {
            return vertexD[1];
        }
        #endregion
        public void WriteVertexesCordinates()
        {
            Console.WriteLine("A: {0},{1}", vertexA[0], vertexA[1]);
            Console.WriteLine("B: {0},{1}", vertexB[0], vertexB[1]);
            Console.WriteLine("C: {0},{1}", vertexC[0], vertexC[1]);
            Console.WriteLine("D: {0},{1}", vertexD[0], vertexD[1]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
