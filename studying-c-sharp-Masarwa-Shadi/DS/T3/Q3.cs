using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_Masarwa_Shadi.DS.T3
{
    public class Q3
    {
        public static void Run()
        {
            Node<Garbage> lst = new Node<Garbage>(new Garbage("6", 100, 90, "F"));
            lst = new Node<Garbage>(new Garbage("5", 87.5, 20.1, "F"), lst);
            lst = new Node<Garbage>(new Garbage("4", 85, 85, "D"), lst);
            lst = new Node<Garbage>(new Garbage("3", 96.2, 70.5, "D"), lst);
            lst = new Node<Garbage>(new Garbage("2", 50, 45.5, "B"), lst);
            lst = new Node<Garbage>(new Garbage("1", 100, 87.2, "B"), lst);
            lst = new Node<Garbage>(new Garbage("1", 1001, 870, "B"), lst);
            lst = new Node<Garbage>(new Garbage("1", 1215, 1200, "B"), lst);
            lst = new Node<Garbage>(new Garbage("1", 1400, 800, "A"), lst);
            lst = new Node<Garbage>(new Garbage("1", 1500, 1300, "A"), lst);

            Node<Garbage> garbageToEmpty = GetGarbageToEmptyList(lst);
            Node<Garbage> garbageInNeighbor = GetgarbagesInNeighbor(lst, "D");
            Node<Garbage> bigGarbage = GetSmallGarbage(lst);
            Console.WriteLine("Grabage To Empty:");
            PrintList(garbageToEmpty);
            Console.WriteLine("\nGarbge In Neighbor D:");
            PrintList(garbageInNeighbor);
            Console.WriteLine("\nBig Garbage: ");
            PrintList(bigGarbage);
            Neighbor n = GetNeighborWithMaxGarbage(lst);
            Console.WriteLine($"\nNeighbor: {n.Name} has max garbage of {n.Count}");
        }

        private static Node<Garbage> GetGarbageToEmptyList(Node<Garbage> lst)
        {
            Node<Garbage> newLst = null;
            while(lst != null)
            {
                if (lst.GetValue().Quantity >= lst.GetValue().Capacity * 0.8)
                {
                    if (newLst == null)
                        newLst = new Node<Garbage>(lst.GetValue());
                    else
                        newLst = new Node<Garbage>(lst.GetValue(),newLst); 
                }
                lst = lst.GetNext();
            }
            return newLst;
        }

        private static Node<Garbage> GetgarbagesInNeighbor(Node<Garbage> lst, string n)
        {
            Node<Garbage> newLst = null;
            while (lst != null)
            {
                if (lst.GetValue().Neighbor == n)
                {
                    if (newLst == null)
                        newLst = new Node<Garbage>(lst.GetValue());
                    else
                        newLst = new Node<Garbage>(lst.GetValue(), newLst);
                }
                lst = lst.GetNext();
            }
            return newLst;
        }

        private static Node<Garbage> GetSmallGarbage(Node<Garbage> lst)
        {
            Node<Garbage> newLst = null;
            while (lst != null)
            {
                if (lst.GetValue().Capacity < 1000)
                {
                    if (newLst == null)
                        newLst = new Node<Garbage>(lst.GetValue());
                    else
                        newLst = new Node<Garbage>(lst.GetValue(), newLst);
                }
                lst = lst.GetNext();
            }
            return newLst;
        }

        private static void PrintList(Node<Garbage> lst)
        {
            while (lst != null)
            {
                Console.WriteLine(lst);
                lst = lst.GetNext();
            }
        }

        private static Neighbor GetNeighborWithMaxGarbage(Node<Garbage> lst)
        {
            //Count nodes
            int all = 0;
            Node<Garbage> pos = lst;
            while (pos != null)
            {
                all++;
                pos = pos.GetNext();
            }
            //Build an array - long as nodes lonng and fill it with neighbor names and 1
            Neighbor[] neighbors = new Neighbor[all];
            pos = lst;
            int i = 0;
            while (pos != null)
            {
                neighbors[i] = new Neighbor(pos.GetValue().Neighbor, 1);
                i++;
                pos = pos.GetNext();
            }

            //Count garbage in each neighbor
            for(i=0; i<neighbors.Length-1; i++)
            {
                if (neighbors[i].Name != "")
                {
                    for (int j=i+1; j<neighbors.Length; j++)
                    {
                        if (neighbors[j].Name == neighbors[i].Name)
                        {
                            neighbors[i].Count++;
                            neighbors[j].Name = "";
                        }
                    }
                }
            }
            //Find neighbor with max garbage number and return it
            int maxNum = neighbors[0].Count;
            string neighbor = neighbors[0].Name;
            for (i=1; i < neighbors.Length; i++)
                if (neighbors[i].Name !="")
                    if (neighbors[i].Count > maxNum)
                    {
                        neighbor = neighbors[i].Name;
                        maxNum = neighbors[i].Count;
                    }
            return new Neighbor(neighbor, maxNum);
        }
    }

    public class Neighbor
    {
        private string name;
        private int count;

        public Neighbor(string name, int count)
        {
            this.name = name;
            this.count = count;
        }

        public string Name { get => name; set => name = value; }
        public int Count { get => count; set => count = value; }
    }

    public class Garbage
    {
        private string num;
        private double capacity;
        private double quantity;
        private string neighbor;

        public Garbage(string num, double capacity, double quantity, string neighbor)
        {
            this.num = num;
            this.capacity = capacity;
            this.quantity = quantity;
            this.neighbor = neighbor;
        }

        public string Num { get => num; set => num = value; }
        public double Capacity { get => capacity; set => capacity = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public string Neighbor { get => neighbor; set => neighbor = value; }

        public override string ToString()
        {
            return $"Num: {num}, Capacity: {capacity}, Quantity: {quantity}, Neighbor: {neighbor}";
        }
    }
}
