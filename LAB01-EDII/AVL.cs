using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB01_EDII
{
    public class AVL<Person>
    {
        public Node<Person> Root;
        public int count;
        public List<Person> NodeList;
        Func<Person, Person, int> Comparer;
        Func<Person, Person, int> NameComparer;
        Action<Person, Person> EditInformation;


        public AVL(Func<Person, Person, int> Comparer)
        {
            Root = null;
            count = 0;
            NodeList = new List<Person>();
            this.Comparer = Comparer;

        }



        public AVL(Func<Person, Person, int> Comparer, Func<Person, Person, int> NameComparer, Action<Person, Person> EditInformation)
        {
            Root = null;
            count = 0;
            NodeList = new List<Person>();
            this.Comparer = Comparer;
            this.NameComparer = NameComparer;
            this.EditInformation = EditInformation;
        }



        public Node<Person> Insert(Node<Person> root, Node<Person> newNode)
        {
            //Base case
            if (root == null)
            {
                count++;
                return newNode; //retorna el nodo que se quiere insertar
            }

            if (Comparer(root.Record, newNode.Record) == 1)   //If it's lesser, go to left subtree
                root.Left = Insert(root.Left, newNode);
            else if (Comparer(root.Record, newNode.Record) == -1) //If it's greater, go to right subtree
                root.Right = Insert(root.Right, newNode);
            else return root;


            //balance factor analysis

            int BalanceFactor = CalculateBalanceFactor(root);

            if (BalanceFactor > 1)
            {
                if (Comparer(root.Left.Record, newNode.Record) == 1) //Single right rotation
                    return RightRotation(root);
                else if (Comparer(root.Left.Record, newNode.Record) == -1) //Double right rotation
                {
                    root.Left = LeftRotation(root.Left);
                    return RightRotation(root);
                }
            }
            if (BalanceFactor < -1)
            {

                if (Comparer(root.Right.Record, newNode.Record) == -1) //Single right rotation 
                    return LeftRotation(root);
                else if (Comparer(root.Right.Record, newNode.Record) == 1)  //Double left rotation
                {
                    root.Right = RightRotation(root.Right);
                    return LeftRotation(root);
                }
            }
            return root;
        }

        public int GetHeight(Node<Person> node)
        {
            if (node == null)
                return -1;
            return Max(GetHeight(node.Left), GetHeight(node.Right));

        }

        public int Max(int leftHeight, int rightHeight)
        {
            return (leftHeight > rightHeight) ? leftHeight + 1 : rightHeight + 1;
        }

        public int CalculateBalanceFactor(Node<Person> node)
        {
            if (node == null)
                return -1;
            return GetHeight(node.Left) - GetHeight(node.Right);
        }


        public Node<Person> RightRotation(Node<Person> node)
        {
            Node<Person> newRoot = node.Left;
            Node<Person> rightAux = newRoot.Right;
            newRoot.Right = node;
            node.Left = rightAux;

            return newRoot;
        }

        public Node<Person> LeftRotation(Node<Person> node)
        {
            Node<Person> newRoot = node.Right;
            Node<Person> leftAux = newRoot.Left;
            newRoot.Left = node;
            node.Right = leftAux;

            return newRoot;
        }

       /* public void InOrder(Node<T> root)
        {
            if (root == null) return;

            InOrder(root.Left);
            NodeList.Add(root.Record);
            InOrder(root.Right);
        }*/

        public void SearchInOrder(Node<Person> root, Node<Person> node)
        {
            if (root == null) return;

            SearchInOrder(root.Left, node);
           
            Person persona1 = root.Record;
            Person persona2 = node.Record;

            if (NameComparer(root.Record, node.Record) == 0)
            {
                NodeList.Add(root.Record);
            }           
            SearchInOrder(root.Right, node);
        }

        /*public Node<T> Search(Node<T> root, Node<T> Data)
        {
            if (root != null)
            {
                if (Comparer(root.Record, Data.Record) == 0) //Evaluate if they are the same
                {
                    return root;
                }
                else if ((Comparer(root.Record, Data.Record) == 1) && (Root.Left != null))   //Evaluate if it is smaller
                {
                    //If it is, go left
                    return Search(root.Left, Data);
                }
                else if ((Comparer(root.Record, Data.Record) == -1) && (Root.Right != null))
                {
                    //If it isn't, go right
                    return Search(root.Right, Data);
                }
            }
            return Data;
        }*/

        public bool Contains(Node<Person> root, Node<Person> newNode)
        {
            if (root != null)
            {
                if (Comparer(root.Record, newNode.Record) == 0) //Evaluate if they are the same
                {
                    return true;
                }
                else if ((Comparer(root.Record, newNode.Record) == 1) && (Root.Left != null))   //Evaluate if it is smaller
                {
                    //If it is, go left
                    return Contains(root.Left, newNode);
                }
                else if ((Comparer(root.Record, newNode.Record) == -1) && (Root.Right != null))
                {
                    //If it isn't, go right
                    return Contains(root.Right, newNode);
                }
            }
            return false;
        }

        public void EditData(Node<Person> root, Node<Person> nodeToEdit)
        {
            if (root != null)
            {
                if (Comparer(root.Record, nodeToEdit.Record) == 0) //Evaluate if they are the same
                {
                    EditInformation(root.Record, nodeToEdit.Record);
                }
                else if ((Comparer(root.Record, nodeToEdit.Record) == 1) && (Root.Left != null))   //Evaluate if it is smaller
                {
                    //If it is, go left
                    EditData(root.Left, nodeToEdit);
                }
                else if ((Comparer(root.Record, nodeToEdit.Record) == -1) && (Root.Right != null))
                {
                    //If it isn't, go right
                    EditData(root.Right, nodeToEdit);
                }
            }
        }

        public Node<Person> Delete(Node<Person> root, Node<Person> DeleteNode)
        {
            if (root == null)
                return root;

            if (Comparer(root.Record, DeleteNode.Record) == 1)
            {
                root.Left = Delete(root.Left, DeleteNode);
            }

            else if (Comparer(root.Record, DeleteNode.Record) == -1)
            {
                root.Right = Delete(root.Right, DeleteNode);
            }

            else
            {
                if (root.Left == null || root.Right == null)
                {
                    Node<Person> aux = (root.Left != null) ? root.Left : root.Right;

                    if (aux == null)
                    {
                        aux = root;
                        root = null;
                    }
                    else
                    {
                        root = aux;
                        aux = null;

                    }
                }
                else
                {
                    Node<Person> aux = minValueNode(root.Right);
                    root.Record = aux.Record;
                    root.Right = Delete(root.Right, DeleteNode);
                }


            }


            return root;

            int balance = CalculateBalanceFactor(root);

            if (balance > 1)
            {
                if (Comparer(root.Record, DeleteNode.Record) == 1)
                {
                    //single right rotation
                    return RightRotation(root);
                }
                else if (Comparer(root.Record, DeleteNode.Record) == -1)
                {
                    //double roght rotation
                    root.Left = LeftRotation(root.Left);
                    return RightRotation(root);
                }
            }

            if (balance < -1)
            {
                if (Comparer(root.Record, DeleteNode.Record) == -1)
                {
                    //single left rotation
                    return LeftRotation(root);
                }
                else if (Comparer(root.Record, DeleteNode.Record) == 1)
                {
                    //double left rotation
                    root.Right = RightRotation(root.Right);
                    return LeftRotation(root);
                }
            }

        }

        Node<Person> minValueNode(Node<Person> node)
        {
            Node<Person> aux = node;
            if (node.Left != null)
            {
                aux = aux.Left;
            }
            return aux;
        }

    }
}
